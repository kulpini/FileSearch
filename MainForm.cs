using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace FileSearch
{
    public partial class MainForm : Form
    {
        Thread searchThread;
        string initFolder, searchMask;
        AutoResetEvent resetEvent;
        int totalFileCount;
        bool stopThread;
        Stopwatch stopwatch;
        BufferedTreeView FileTree;
        public MainForm()
        {
            InitializeComponent();
            InitFolderTextBox.Text = Properties.Settings.Default.InitFolder;
            RegexTextBox.Text = Properties.Settings.Default.RegexText;
            stopwatch = new Stopwatch();
            resetEvent = new AutoResetEvent(true);
            FileTree = new BufferedTreeView()
            {
                Parent = panel2,
                Width = 400,
                Height = 350,
                Left = 10,
                Top = 10
            };
        }

        private void OpenFolderButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDialog = new FolderBrowserDialog();
            folderDialog.SelectedPath = InitFolderTextBox.Text;
            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                InitFolderTextBox.Text = folderDialog.SelectedPath;
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.InitFolder = InitFolderTextBox.Text;
            Properties.Settings.Default.RegexText = RegexTextBox.Text;
            Properties.Settings.Default.Save();
            if (searchThread != null && searchThread.IsAlive)
                searchThread.Abort();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (searchThread != null && (searchThread.IsAlive || searchThread.ThreadState == System.Threading.ThreadState.WaitSleepJoin))
            {
                ClearSearch();
            }
            initFolder = InitFolderTextBox.Text;
            searchMask = $"{RegexTextBox.Text}";
            if (Directory.Exists(initFolder))
            {
                searchThread = new Thread(MakeSearch);
                searchThread.Start();
            }
            else
                MessageBox.Show($"Заданной директории \"{initFolder}\" не существует!!!\n" +
                    $"Поиск невозможен!");
        }
        private void ClearSearch()
        {
            searchThread.Abort();
            searchThread.Interrupt();
            searchThread = null;
            stopThread = false;
            stopwatch.Restart();
            FileTree.Nodes.Clear();
            totalFileCount = 0;
        }
        private void MakeSearch()
        {
            SearchFiles(initFolder, searchMask);
        }

        private void SearchFiles(string folderPath, string fileMask)
        {
            stopwatch.Start();
            string initFolder = new DirectoryInfo(folderPath).Name;
            TreeNode folderNode = new TreeNode(initFolder, 1, 1);
            FileTree.Invoke(new Action(() => FileTree.Nodes.Add(folderNode)));
            AddFolders(folderNode, folderPath);
        }
        private void AddFolders(TreeNode node, string folderPath)
        {
            if (stopThread)
            {
                stopwatch.Stop();
                resetEvent.WaitOne();

            }
            stopwatch.Start();

            foreach (var folder in Directory.GetDirectories(folderPath))
            {

                string currentFolder = new DirectoryInfo(folder).Name;
                CurrentFolderLabel.Invoke(new Action(() => CurrentFolderLabel.Text = folder));
                TreeNode folderNode = new TreeNode(currentFolder, 1, 1);
                FileTree.Invoke(new Action(() => node.Nodes.Add(folderNode)));
                TimeSpan timeSpan = stopwatch.Elapsed;
                ElapsedTimeLabel.Invoke(new Action(() => ElapsedTimeLabel.Text =
                    $"{timeSpan.Hours:00}:{timeSpan.Minutes:00}:{timeSpan.Seconds:00}"));
                if (Directory.GetDirectories(folder) != null)
                    AddFolders(folderNode, folder);
            }
            int filesCount = 0;
            totalFileCount += Directory.GetFiles(folderPath).Length;
            FileTree.Invoke(new Action(() => FileTree.BeginUpdate()));
            foreach (var file in Directory.GetFiles(folderPath))
            {
                string filename = Path.GetFileName(file);
                if (Regex.IsMatch(filename, searchMask))
                {
                    filesCount++;
                    TreeNode filenode = new TreeNode(filename, 0, 0);
                    FileTree.Invoke(new Action(() => node.Nodes.Add(filenode)));
                }
                FileCountLabel.Invoke(new Action(() => FileCountLabel.Text = $"{filesCount} из {totalFileCount}"));
                TimeSpan timeSpan = stopwatch.Elapsed;
                ElapsedTimeLabel.Invoke(new Action(() => ElapsedTimeLabel.Text =
                    $"{timeSpan.Hours:00}:{timeSpan.Minutes:00}:{timeSpan.Seconds:00}"));
            }
            FileTree.Invoke(new Action(() => FileTree.EndUpdate()));
        }

        private void ProceedThreadButton_Click(object sender, EventArgs e)
        {
            stopThread = false;
            resetEvent.Set();
        }

        private void PauseThreadButton_Click(object sender, EventArgs e)
        {
            stopThread = true;
            resetEvent.Reset();
        }
    }
}
