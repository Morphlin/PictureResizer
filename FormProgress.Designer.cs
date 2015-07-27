namespace PictureResizer
{
    partial class FormProgress
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProgress));
            this.ProgressBarResize = new System.Windows.Forms.ProgressBar();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.LabelResize = new System.Windows.Forms.Label();
            this.PicturePreview = new System.Windows.Forms.PictureBox();
            this.WorkerResizer = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.PicturePreview)).BeginInit();
            this.SuspendLayout();
            // 
            // ProgressBarResize
            // 
            this.ProgressBarResize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProgressBarResize.Location = new System.Drawing.Point(13, 266);
            this.ProgressBarResize.Name = "ProgressBarResize";
            this.ProgressBarResize.Size = new System.Drawing.Size(312, 23);
            this.ProgressBarResize.TabIndex = 0;
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonCancel.Location = new System.Drawing.Point(132, 297);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(75, 23);
            this.ButtonCancel.TabIndex = 1;
            this.ButtonCancel.Text = "&Cancel";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // LabelResize
            // 
            this.LabelResize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelResize.Location = new System.Drawing.Point(13, 244);
            this.LabelResize.Name = "LabelResize";
            this.LabelResize.Size = new System.Drawing.Size(312, 18);
            this.LabelResize.TabIndex = 2;
            this.LabelResize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PicturePreview
            // 
            this.PicturePreview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PicturePreview.Location = new System.Drawing.Point(16, 16);
            this.PicturePreview.Name = "PicturePreview";
            this.PicturePreview.Size = new System.Drawing.Size(309, 214);
            this.PicturePreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicturePreview.TabIndex = 5;
            this.PicturePreview.TabStop = false;
            // 
            // WorkerResizer
            // 
            this.WorkerResizer.WorkerReportsProgress = true;
            this.WorkerResizer.WorkerSupportsCancellation = true;
            this.WorkerResizer.DoWork += new System.ComponentModel.DoWorkEventHandler(this.WorkerResizer_DoWork);
            this.WorkerResizer.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.WorkerResizer_ProgressChanged);
            this.WorkerResizer.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.WorkerResizer_RunWorkerCompleted);
            // 
            // FormProgress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ButtonCancel;
            this.ClientSize = new System.Drawing.Size(338, 328);
            this.Controls.Add(this.PicturePreview);
            this.Controls.Add(this.LabelResize);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ProgressBarResize);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormProgress";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Resizing";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormProgress_FormClosing);
            this.Load += new System.EventHandler(this.FormProgress_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicturePreview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar ProgressBarResize;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.Label LabelResize;
        private System.Windows.Forms.PictureBox PicturePreview;
        private System.ComponentModel.BackgroundWorker WorkerResizer;
    }
}