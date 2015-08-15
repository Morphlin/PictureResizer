using System;
using System.IO;
using System.Drawing;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PictureResizer
{
    /// <summary>
    /// Form providing progress tracking for the user.
    /// </summary>
    internal partial class FormProgress : Form
    {
        /// <summary>
        /// 
        /// </summary>
        private readonly List<FileInfo> FilesToResize = new List<FileInfo>();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="FilesToResizeRef"></param>
        internal FormProgress(FileInfo[] FilesToResizeRef)
        {
            FilesToResize.AddRange(FilesToResizeRef);
            InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>
        private const int CP_NOCLOSE_BUTTON = 0x200;
        /// <summary>
        /// 
        /// </summary>
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormProgress_Load(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            WorkerResizer.RunWorkerAsync(FilesToResize.ToArray());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormProgress_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (WorkerResizer.IsBusy)
            {
                WorkerResizer.CancelAsync();
                e.Cancel = true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WorkerResizer_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            int Progress = 0;
            var FileList = new List<FileInfo>((FileInfo[])e.Argument);
            foreach (var FileToConvert in FileList)
            {
                if (WorkerResizer.CancellationPending){return;}
                try
                {
                    Progress = Progress + 1;
                    string NewFolderName = "Resized Images";
                    var NewFolder = new DirectoryInfo(FileToConvert.Directory.FullName + "\\" + NewFolderName);
                    if (!NewFolder.Exists) NewFolder.Create();
                    var NewFilePath = NewFolder.FullName + "\\" + Path.GetFileNameWithoutExtension(FileToConvert.Name) + "_S" + FileToConvert.Extension;
                    if (new FileInfo(NewFilePath).Exists) continue; //Add setting to skip or overwrite
                    var FileOriginal = Image.FromFile(FileToConvert.FullName);
                    var FileConvert = (Image)(new Bitmap(FileOriginal, new Size(FileOriginal.Width / 2, FileOriginal.Height / 2)));
                    WorkerResizer.ReportProgress(Progress, new ProgressData((Image)FileConvert.Clone(), FileToConvert.FullName, FileList.Count));
                    FileConvert.Save(NewFilePath, FileOriginal.RawFormat);
                    FileOriginal.Dispose(); //is this necessary???
                    FileConvert.Dispose(); //is this necessary???
                }
                catch(Exception Ex)
                {
                    e.Result = Ex.Message;
                    return;
                }
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WorkerResizer_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            ProgressBarResize.Value = e.ProgressPercentage;
            var Data = (ProgressData) e.UserState;
            PicturePreview.Image = Data.Preview;
            LabelResize.Text = Data.Caption;
            ProgressBarResize.Maximum = Data.Maximum;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WorkerResizer_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            UseWaitCursor = false;
            if (e.Result != null)
            {
                MessageBox.Show(e.Result.ToString());
            }
            Close();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            ButtonCancel.Enabled = false;
            Close();
        }

        /// <summary>
        /// 
        /// </summary>
        private class ProgressData
        {
            private readonly Image _Preview;
            internal Image Preview
            {
                get { return _Preview; }
            }
            private readonly string _Caption;
            internal string Caption
            {
                get { return _Caption; }
            }
            private readonly int _Maximum;
            internal int Maximum
            {
                get { return _Maximum; }
            }
            internal ProgressData(Image Preview, string Caption, int Maximum)
            {
                _Preview = Preview;
                _Caption = Caption;
                _Maximum = Maximum;
            }
        }
    }
}
