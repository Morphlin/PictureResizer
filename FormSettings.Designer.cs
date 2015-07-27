namespace PictureResizer
{
    partial class FormSettings
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSettings));
            this.TabSettings = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.ErrorSettings = new System.Windows.Forms.ErrorProvider(this.components);
            this.ButtonDefaults = new System.Windows.Forms.Button();
            this.PictureBoxAbout = new System.Windows.Forms.PictureBox();
            this.LabelTitleAbout = new System.Windows.Forms.Label();
            this.LabelBannerAbout = new System.Windows.Forms.Label();
            this.TabSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorSettings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxAbout)).BeginInit();
            this.SuspendLayout();
            // 
            // TabSettings
            // 
            this.TabSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabSettings.Controls.Add(this.tabPage1);
            this.TabSettings.Controls.Add(this.tabPage2);
            this.TabSettings.Location = new System.Drawing.Point(7, 68);
            this.TabSettings.Name = "TabSettings";
            this.TabSettings.SelectedIndex = 0;
            this.TabSettings.Size = new System.Drawing.Size(387, 214);
            this.TabSettings.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(379, 188);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(379, 188);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ButtonSave
            // 
            this.ButtonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonSave.Location = new System.Drawing.Point(232, 288);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(75, 23);
            this.ButtonSave.TabIndex = 1;
            this.ButtonSave.Text = "&Save";
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonCancel.Location = new System.Drawing.Point(315, 288);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(75, 23);
            this.ButtonCancel.TabIndex = 2;
            this.ButtonCancel.Text = "&Cancel";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // ErrorSettings
            // 
            this.ErrorSettings.ContainerControl = this;
            // 
            // ButtonDefaults
            // 
            this.ButtonDefaults.Location = new System.Drawing.Point(8, 288);
            this.ButtonDefaults.Name = "ButtonDefaults";
            this.ButtonDefaults.Size = new System.Drawing.Size(75, 23);
            this.ButtonDefaults.TabIndex = 3;
            this.ButtonDefaults.Text = "&Defaults";
            this.ButtonDefaults.UseVisualStyleBackColor = true;
            this.ButtonDefaults.Click += new System.EventHandler(this.ButtonDefaults_Click);
            // 
            // PictureBoxAbout
            // 
            this.PictureBoxAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PictureBoxAbout.BackColor = System.Drawing.Color.DarkOrange;
            this.PictureBoxAbout.Image = ((System.Drawing.Image)(resources.GetObject("PictureBoxAbout.Image")));
            this.PictureBoxAbout.Location = new System.Drawing.Point(342, 3);
            this.PictureBoxAbout.Name = "PictureBoxAbout";
            this.PictureBoxAbout.Size = new System.Drawing.Size(54, 54);
            this.PictureBoxAbout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PictureBoxAbout.TabIndex = 8;
            this.PictureBoxAbout.TabStop = false;
            // 
            // LabelTitleAbout
            // 
            this.LabelTitleAbout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelTitleAbout.BackColor = System.Drawing.Color.DarkOrange;
            this.LabelTitleAbout.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTitleAbout.Location = new System.Drawing.Point(13, 9);
            this.LabelTitleAbout.Name = "LabelTitleAbout";
            this.LabelTitleAbout.Size = new System.Drawing.Size(323, 44);
            this.LabelTitleAbout.TabIndex = 7;
            this.LabelTitleAbout.Text = "Picture Resizer";
            this.LabelTitleAbout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabelBannerAbout
            // 
            this.LabelBannerAbout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelBannerAbout.BackColor = System.Drawing.Color.DarkOrange;
            this.LabelBannerAbout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LabelBannerAbout.Location = new System.Drawing.Point(0, 0);
            this.LabelBannerAbout.Name = "LabelBannerAbout";
            this.LabelBannerAbout.Size = new System.Drawing.Size(399, 60);
            this.LabelBannerAbout.TabIndex = 6;
            // 
            // FormSettings
            // 
            this.AcceptButton = this.ButtonSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ButtonCancel;
            this.ClientSize = new System.Drawing.Size(399, 319);
            this.Controls.Add(this.PictureBoxAbout);
            this.Controls.Add(this.LabelTitleAbout);
            this.Controls.Add(this.LabelBannerAbout);
            this.Controls.Add(this.ButtonDefaults);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.TabSettings);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSettings";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.FormSettings_HelpButtonClicked);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormSettings_FormClosing);
            this.Load += new System.EventHandler(this.FormSettings_Load);
            this.TabSettings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorSettings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxAbout)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabSettings;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.ErrorProvider ErrorSettings;
        private System.Windows.Forms.Button ButtonDefaults;
        private System.Windows.Forms.PictureBox PictureBoxAbout;
        private System.Windows.Forms.Label LabelTitleAbout;
        private System.Windows.Forms.Label LabelBannerAbout;
    }
}