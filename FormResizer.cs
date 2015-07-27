using System;
using System.IO;
using System.Linq;
using System.ComponentModel;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PictureResizer
{
    public partial class FormResizer : Form
    {
        public FormResizer()
        {
            InitializeComponent();
        }

        private void FormResizer_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            var FormAbout = new FormAbout();
            FormAbout.ShowDialog();
            e.Cancel = true;
        }

        private void FormResizer_Load(object sender, EventArgs e)
        {

        }

        private void FormResizer_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to quit?", "Picture Resizer", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private bool DisableCheckingItems;
        private void ListViewPictures_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (!DisableCheckingItems)
            {
                if (ListViewPictures.CheckedItems.Count > 0)
                {
                    ButtonResize.Enabled = true;
                }
                else
                {
                    ButtonResize.Enabled = false;
                }
            }
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonBrowse_Click(object sender, EventArgs e)
        {
            FolderDialog = new FolderBrowserDialog();
            if (FolderDialog.ShowDialog() == DialogResult.OK)
            {
                TextBoxPath.Text = FolderDialog.SelectedPath;
                LoadFolder();
            }
        }

        private void LoadFolder()
        {
            DisableCheckingItems = true;
            UseWaitCursor = true;
            ListViewPictures.Items.Clear();
            WorkerLoad.RunWorkerAsync(FolderDialog.SelectedPath);
        }

        private void WorkerLoad_DoWork(object sender, DoWorkEventArgs e)
        {
            var ListViewItems = new List<ListViewItem>();
            var SelectedDirectory = new DirectoryInfo(e.Argument.ToString());
            var SelectedDirectoryFiles = SelectedDirectory.GetFiles();
            foreach (var FilesInDirectory in SelectedDirectoryFiles)
            {
                if (FilesInDirectory.Extension.ToUpper().Contains("BMP") || FilesInDirectory.Extension.ToUpper().Contains("JPG") || FilesInDirectory.Extension.ToUpper().Contains("JPEG") || FilesInDirectory.Extension.ToUpper().Contains("GIF") || FilesInDirectory.Extension.ToUpper().Contains("PNG") || FilesInDirectory.Extension.ToUpper().Contains("TIFF"))
                {
                    var FileInDir = new ListViewItem(FilesInDirectory.Name);
                    FileInDir.SubItems.Add(FormatBytes(FilesInDirectory.Length));
                    FileInDir.Tag = FilesInDirectory;
                    ListViewItems.Add(FileInDir);
                }
            }
            e.Result = ListViewItems.ToArray();
        }

        private void WorkerLoad_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ListViewPictures.Items.AddRange(e.Result as ListViewItem[]);
            UseWaitCursor = false;
            DisableCheckingItems = false;
            ListViewPictures_ItemChecked(null, null);
            ButtonSelectAllNone.Enabled = ListViewPictures.Items.Count > 0;
        }

        private bool SelectAllFlag = true;
        private void ButtonSelectAllNone_Click(object sender, EventArgs e)
        {
            DisableCheckingItems = true;
            ListViewPictures.Items.OfType<ListViewItem>().ToList().ForEach(Item => Item.Checked = SelectAllFlag);
            SelectAllFlag = !SelectAllFlag;
            DisableCheckingItems = false;
            ListViewPictures_ItemChecked(null, null);
        }

        private void ButtonResize_Click(object sender, EventArgs e)
        {
            var FilesToResize = new List<FileInfo>();
            foreach (ListViewItem FilesInDirectoryItems in ListViewPictures.CheckedItems)
            {
                var FilesInDirectory = (FileInfo)FilesInDirectoryItems.Tag;
                FilesToResize.Add(FilesInDirectory);
            }
            var ProgressForm = new FormProgress(FilesToResize.ToArray());
            ProgressForm.ShowDialog();
            LoadFolder();
        }

        /// <summary>
        /// Converts the filesize of a file or drive from byte to best displayable unit.
        /// </summary>
        /// <param name="bytes">Filesize in Bytes</param>
        /// <returns></returns>
        private static string FormatBytes(long bytes)
        {
            string[] Suffix = { "B", "KB", "MB", "GB", "TB" };
            int i = 0;
            double dblSByte = bytes;
            if (bytes > 1024)
            {
                for (i = 0; (bytes / 1024) > 0; i++, bytes /= 1024)
                {
                    dblSByte = bytes / 1024.0;
                }
            }
            return String.Format("{0:0.##} {1}", dblSByte, Suffix[i]);
        }
    }
}
