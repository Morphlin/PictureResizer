namespace PictureResizer
{
    partial class FormResizer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormResizer));
            this.FolderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.ListViewPictures = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.PanelCommands = new System.Windows.Forms.Panel();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.ButtonResize = new System.Windows.Forms.Button();
            this.ButtonSelectAllNone = new System.Windows.Forms.Button();
            this.TextBoxPath = new System.Windows.Forms.TextBox();
            this.ButtonBrowse = new System.Windows.Forms.Button();
            this.WorkerLoad = new System.ComponentModel.BackgroundWorker();
            this.TableLayout.SuspendLayout();
            this.PanelCommands.SuspendLayout();
            this.SuspendLayout();
            // 
            // FolderDialog
            // 
            this.FolderDialog.ShowNewFolderButton = false;
            // 
            // ListViewPictures
            // 
            this.ListViewPictures.CheckBoxes = true;
            this.ListViewPictures.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.ListViewPictures.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListViewPictures.FullRowSelect = true;
            this.ListViewPictures.GridLines = true;
            this.ListViewPictures.HideSelection = false;
            this.ListViewPictures.Location = new System.Drawing.Point(5, 5);
            this.ListViewPictures.Margin = new System.Windows.Forms.Padding(5, 5, 5, 1);
            this.ListViewPictures.MultiSelect = false;
            this.ListViewPictures.Name = "ListViewPictures";
            this.ListViewPictures.Size = new System.Drawing.Size(565, 307);
            this.ListViewPictures.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.ListViewPictures.TabIndex = 0;
            this.ListViewPictures.UseCompatibleStateImageBehavior = false;
            this.ListViewPictures.View = System.Windows.Forms.View.Details;
            this.ListViewPictures.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.ListViewPictures_ItemChecked);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 427;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Size";
            this.columnHeader2.Width = 110;
            // 
            // TableLayout
            // 
            this.TableLayout.ColumnCount = 1;
            this.TableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TableLayout.Controls.Add(this.ListViewPictures, 0, 0);
            this.TableLayout.Controls.Add(this.PanelCommands, 0, 1);
            this.TableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayout.Location = new System.Drawing.Point(0, 0);
            this.TableLayout.Name = "TableLayout";
            this.TableLayout.RowCount = 2;
            this.TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableLayout.Size = new System.Drawing.Size(575, 346);
            this.TableLayout.TabIndex = 1;
            // 
            // PanelCommands
            // 
            this.PanelCommands.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PanelCommands.Controls.Add(this.ButtonExit);
            this.PanelCommands.Controls.Add(this.ButtonResize);
            this.PanelCommands.Controls.Add(this.ButtonSelectAllNone);
            this.PanelCommands.Controls.Add(this.TextBoxPath);
            this.PanelCommands.Controls.Add(this.ButtonBrowse);
            this.PanelCommands.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelCommands.Location = new System.Drawing.Point(3, 316);
            this.PanelCommands.Name = "PanelCommands";
            this.PanelCommands.Size = new System.Drawing.Size(569, 27);
            this.PanelCommands.TabIndex = 1;
            // 
            // ButtonExit
            // 
            this.ButtonExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonExit.Location = new System.Drawing.Point(2, 2);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(75, 23);
            this.ButtonExit.TabIndex = 4;
            this.ButtonExit.Text = "E&xit";
            this.ButtonExit.UseVisualStyleBackColor = true;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // ButtonResize
            // 
            this.ButtonResize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonResize.Enabled = false;
            this.ButtonResize.Location = new System.Drawing.Point(463, 2);
            this.ButtonResize.Name = "ButtonResize";
            this.ButtonResize.Size = new System.Drawing.Size(104, 23);
            this.ButtonResize.TabIndex = 3;
            this.ButtonResize.Text = "&Resize selected";
            this.ButtonResize.UseVisualStyleBackColor = true;
            this.ButtonResize.Click += new System.EventHandler(this.ButtonResize_Click);
            // 
            // ButtonSelectAllNone
            // 
            this.ButtonSelectAllNone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonSelectAllNone.Enabled = false;
            this.ButtonSelectAllNone.Location = new System.Drawing.Point(382, 2);
            this.ButtonSelectAllNone.Name = "ButtonSelectAllNone";
            this.ButtonSelectAllNone.Size = new System.Drawing.Size(75, 23);
            this.ButtonSelectAllNone.TabIndex = 2;
            this.ButtonSelectAllNone.Text = "All / &None";
            this.ButtonSelectAllNone.UseVisualStyleBackColor = true;
            this.ButtonSelectAllNone.Click += new System.EventHandler(this.ButtonSelectAllNone_Click);
            // 
            // TextBoxPath
            // 
            this.TextBoxPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxPath.Location = new System.Drawing.Point(83, 3);
            this.TextBoxPath.Name = "TextBoxPath";
            this.TextBoxPath.ReadOnly = true;
            this.TextBoxPath.Size = new System.Drawing.Size(212, 21);
            this.TextBoxPath.TabIndex = 1;
            this.TextBoxPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ButtonBrowse
            // 
            this.ButtonBrowse.Location = new System.Drawing.Point(301, 2);
            this.ButtonBrowse.Name = "ButtonBrowse";
            this.ButtonBrowse.Size = new System.Drawing.Size(75, 23);
            this.ButtonBrowse.TabIndex = 0;
            this.ButtonBrowse.Text = "&Browse";
            this.ButtonBrowse.UseVisualStyleBackColor = true;
            this.ButtonBrowse.Click += new System.EventHandler(this.ButtonBrowse_Click);
            // 
            // WorkerLoad
            // 
            this.WorkerLoad.DoWork += new System.ComponentModel.DoWorkEventHandler(this.WorkerLoad_DoWork);
            this.WorkerLoad.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.WorkerLoad_RunWorkerCompleted);
            // 
            // FormResizer
            // 
            this.AcceptButton = this.ButtonResize;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ButtonExit;
            this.ClientSize = new System.Drawing.Size(575, 346);
            this.Controls.Add(this.TableLayout);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormResizer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Picture Resizer";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.FormResizer_HelpButtonClicked);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormResizer_FormClosing);
            this.Load += new System.EventHandler(this.FormResizer_Load);
            this.TableLayout.ResumeLayout(false);
            this.PanelCommands.ResumeLayout(false);
            this.PanelCommands.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog FolderDialog;
        private System.Windows.Forms.ListView ListViewPictures;
        private System.Windows.Forms.TableLayoutPanel TableLayout;
        private System.Windows.Forms.Panel PanelCommands;
        private System.Windows.Forms.Button ButtonBrowse;
        private System.Windows.Forms.TextBox TextBoxPath;
        private System.Windows.Forms.Button ButtonResize;
        private System.Windows.Forms.Button ButtonSelectAllNone;
        private System.ComponentModel.BackgroundWorker WorkerLoad;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button ButtonExit;
    }
}