using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XInputScanner
{
    public partial class MainForm : Form
    {
        private readonly XInputScanner _scanner;

        public MainForm()
        {
            InitializeComponent();
            _scanner = new XInputScanner(text =>
            {
                if (textBoxLog.InvokeRequired)
                    textBoxLog.Invoke((MethodInvoker)(() => textBoxLog.AppendText(text)));
            });
            DragEnter += (sender, e) =>
            {
                if (e.Data.GetDataPresent(DataFormats.FileDrop))
                    e.Effect = DragDropEffects.Copy;
            };
            DragDrop += (sender, e) =>
            {
                if (!e.Data.GetDataPresent(DataFormats.FileDrop))
                    return;
                var filePaths = e.Data.GetData(DataFormats.FileDrop) as string[];
                Task.Run(() =>
                {
                    _scanner.ScanFiles(filePaths, checkBoxRecursive.Checked);
                    textBoxLog.AppendText("Finished!\n");
                });
            };
        }

        private void buttonSelectFile_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog
            {
                Filter = "Executables (*.exe)|*.exe|DLLs (*.dll)|*.dll|All files (*.*)|*.*",
                InitialDirectory = AppDomain.CurrentDomain.BaseDirectory,
                Title = "Select file"
            };

            if (dialog.ShowDialog() != DialogResult.OK)
                return;

            Task.Run(() =>
            {
                _scanner.ScanFile(dialog.FileName);
                textBoxLog.AppendText("Finished!\n");
            });
        }

        private void buttonSelectDirectory_Click(object sender, EventArgs e)
        {
            var dialog = new FolderBrowserDialog();

            if (dialog.ShowDialog() != DialogResult.OK)
                return;

            Task.Run(() =>
            {
                _scanner.ScanDirectory(dialog.SelectedPath, checkBoxRecursive.Checked);
                textBoxLog.AppendText("Finished!\n");
            });
        }
    }
}
