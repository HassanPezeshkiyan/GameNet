﻿
namespace GameNet.App
{
    partial class mainFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainFrm));
            this.shopSettingBtn = new System.Windows.Forms.Button();
            this.reportsBtn = new System.Windows.Forms.Button();
            this.settingBtn = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.panelItems = new System.Windows.Forms.Panel();
            this.btnStart = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnEditProfile = new System.Windows.Forms.Button();
            this.labelUserName = new System.Windows.Forms.Label();
            this.pictureBoxUser = new System.Windows.Forms.PictureBox();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panelConsoles = new System.Windows.Forms.Panel();
            this.panelMain.SuspendLayout();
            this.panelItems.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).BeginInit();
            this.SuspendLayout();
            // 
            // shopSettingBtn
            // 
            this.shopSettingBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.shopSettingBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.shopSettingBtn.FlatAppearance.BorderSize = 0;
            this.shopSettingBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.shopSettingBtn.Font = new System.Drawing.Font("B Nazanin", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.shopSettingBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.shopSettingBtn.Location = new System.Drawing.Point(0, 87);
            this.shopSettingBtn.Margin = new System.Windows.Forms.Padding(4);
            this.shopSettingBtn.Name = "shopSettingBtn";
            this.shopSettingBtn.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.shopSettingBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.shopSettingBtn.Size = new System.Drawing.Size(259, 51);
            this.shopSettingBtn.TabIndex = 0;
            this.shopSettingBtn.Text = "تنظیمات بوفه";
            this.shopSettingBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.shopSettingBtn.UseVisualStyleBackColor = false;
            this.shopSettingBtn.Click += new System.EventHandler(this.shopSettingBtn_Click);
            // 
            // reportsBtn
            // 
            this.reportsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.reportsBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.reportsBtn.FlatAppearance.BorderSize = 0;
            this.reportsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reportsBtn.Font = new System.Drawing.Font("B Nazanin", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.reportsBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.reportsBtn.Location = new System.Drawing.Point(0, 0);
            this.reportsBtn.Margin = new System.Windows.Forms.Padding(4);
            this.reportsBtn.Name = "reportsBtn";
            this.reportsBtn.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.reportsBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.reportsBtn.Size = new System.Drawing.Size(259, 45);
            this.reportsBtn.TabIndex = 4;
            this.reportsBtn.Text = "گزارشات";
            this.reportsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.reportsBtn.UseVisualStyleBackColor = false;
            // 
            // settingBtn
            // 
            this.settingBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.settingBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.settingBtn.FlatAppearance.BorderSize = 0;
            this.settingBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingBtn.Font = new System.Drawing.Font("B Nazanin", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.settingBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.settingBtn.Location = new System.Drawing.Point(0, 45);
            this.settingBtn.Margin = new System.Windows.Forms.Padding(4);
            this.settingBtn.Name = "settingBtn";
            this.settingBtn.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.settingBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.settingBtn.Size = new System.Drawing.Size(259, 42);
            this.settingBtn.TabIndex = 7;
            this.settingBtn.Text = "تنظیمات دستگاه";
            this.settingBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.settingBtn.UseVisualStyleBackColor = false;
            this.settingBtn.Click += new System.EventHandler(this.settingBtn_Click);
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.panelMain.Controls.Add(this.btnClose);
            this.panelMain.Controls.Add(this.panelItems);
            this.panelMain.Controls.Add(this.panelLogo);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelMain.Location = new System.Drawing.Point(1027, 0);
            this.panelMain.Margin = new System.Windows.Forms.Padding(4);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(259, 867);
            this.panelMain.TabIndex = 8;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnClose.Location = new System.Drawing.Point(158, 822);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(89, 33);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "خروج";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panelItems
            // 
            this.panelItems.AutoScroll = true;
            this.panelItems.Controls.Add(this.btnStart);
            this.panelItems.Controls.Add(this.shopSettingBtn);
            this.panelItems.Controls.Add(this.settingBtn);
            this.panelItems.Controls.Add(this.reportsBtn);
            this.panelItems.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelItems.Location = new System.Drawing.Point(0, 216);
            this.panelItems.Name = "panelItems";
            this.panelItems.Size = new System.Drawing.Size(259, 192);
            this.panelItems.TabIndex = 10;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnStart.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("B Nazanin", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnStart.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnStart.Location = new System.Drawing.Point(0, 138);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.btnStart.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnStart.Size = new System.Drawing.Size(259, 51);
            this.btnStart.TabIndex = 8;
            this.btnStart.Text = "شروع";
            this.btnStart.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.panelLogo.Controls.Add(this.btnEditProfile);
            this.panelLogo.Controls.Add(this.labelUserName);
            this.panelLogo.Controls.Add(this.pictureBoxUser);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Font = new System.Drawing.Font("B Nazanin", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.panelLogo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(259, 216);
            this.panelLogo.TabIndex = 9;
            // 
            // btnEditProfile
            // 
            this.btnEditProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnEditProfile.FlatAppearance.BorderSize = 0;
            this.btnEditProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditProfile.Font = new System.Drawing.Font("B Nazanin", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnEditProfile.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEditProfile.Location = new System.Drawing.Point(158, 178);
            this.btnEditProfile.Name = "btnEditProfile";
            this.btnEditProfile.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnEditProfile.Size = new System.Drawing.Size(89, 31);
            this.btnEditProfile.TabIndex = 8;
            this.btnEditProfile.Text = "ویرایش ";
            this.btnEditProfile.UseVisualStyleBackColor = false;
            this.btnEditProfile.Click += new System.EventHandler(this.btnEditProfile_Click);
            // 
            // labelUserName
            // 
            this.labelUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelUserName.AutoSize = true;
            this.labelUserName.Location = new System.Drawing.Point(152, 106);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelUserName.Size = new System.Drawing.Size(0, 32);
            this.labelUserName.TabIndex = 1;
            this.labelUserName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBoxUser
            // 
            this.pictureBoxUser.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBoxUser.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxUser.Image")));
            this.pictureBoxUser.Location = new System.Drawing.Point(158, 0);
            this.pictureBoxUser.Name = "pictureBoxUser";
            this.pictureBoxUser.Size = new System.Drawing.Size(101, 216);
            this.pictureBoxUser.TabIndex = 0;
            this.pictureBoxUser.TabStop = false;
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(47)))), ((int)(((byte)(62)))));
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelContainer.Location = new System.Drawing.Point(0, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1027, 428);
            this.panelContainer.TabIndex = 9;
            // 
            // panelConsoles
            // 
            this.panelConsoles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(47)))), ((int)(((byte)(62)))));
            this.panelConsoles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelConsoles.Location = new System.Drawing.Point(0, 428);
            this.panelConsoles.Name = "panelConsoles";
            this.panelConsoles.Size = new System.Drawing.Size(1027, 439);
            this.panelConsoles.TabIndex = 10;
            // 
            // mainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1286, 867);
            this.Controls.Add(this.panelConsoles);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panelMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "mainFrm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "صفحه اصلی";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.mainFrm_Load);
            this.panelMain.ResumeLayout(false);
            this.panelItems.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button shopSettingBtn;
        private System.Windows.Forms.Button reportsBtn;
        private System.Windows.Forms.Button settingBtn;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox pictureBoxUser;
        private System.Windows.Forms.Panel panelItems;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Button btnEditProfile;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Panel panelConsoles;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnStart;
    }
}

