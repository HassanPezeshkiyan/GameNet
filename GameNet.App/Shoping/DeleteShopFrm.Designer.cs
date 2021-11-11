
namespace GameNet.App.Shoping
{
    partial class DeleteShopFrm
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
            this.panelMain = new System.Windows.Forms.Panel();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listBoxShopItems = new System.Windows.Forms.ListBox();
            this.panelMain.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.buttonConfirm);
            this.panelMain.Controls.Add(this.panel1);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(440, 180);
            this.panelMain.TabIndex = 0;
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.BackColor = System.Drawing.Color.DarkRed;
            this.buttonConfirm.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonConfirm.FlatAppearance.BorderSize = 0;
            this.buttonConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConfirm.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.buttonConfirm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonConfirm.Location = new System.Drawing.Point(0, 138);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(440, 38);
            this.buttonConfirm.TabIndex = 1;
            this.buttonConfirm.Text = "حذف";
            this.buttonConfirm.UseVisualStyleBackColor = false;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listBoxShopItems);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(440, 138);
            this.panel1.TabIndex = 0;
            // 
            // listBoxShopItems
            // 
            this.listBoxShopItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxShopItems.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.listBoxShopItems.FormattingEnabled = true;
            this.listBoxShopItems.ItemHeight = 24;
            this.listBoxShopItems.Location = new System.Drawing.Point(0, 0);
            this.listBoxShopItems.Name = "listBoxShopItems";
            this.listBoxShopItems.Size = new System.Drawing.Size(440, 138);
            this.listBoxShopItems.TabIndex = 0;
            // 
            // DeleteShopFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 180);
            this.Controls.Add(this.panelMain);
            this.Name = "DeleteShopFrm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "حذف بوفه";
            this.Load += new System.EventHandler(this.DeleteShopFrm_Load);
            this.panelMain.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.ListBox listBoxShopItems;
    }
}