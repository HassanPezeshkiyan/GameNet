
namespace GameNet.App.Settings
{
    partial class settingFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.panelMain = new System.Windows.Forms.Panel();
            this.exitBtn = new System.Windows.Forms.Button();
            this.editConsoleBtn = new System.Windows.Forms.Button();
            this.dgvConsole = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.consoleType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsole)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.exitBtn);
            this.panelMain.Controls.Add(this.editConsoleBtn);
            this.panelMain.Controls.Add(this.dgvConsole);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(552, 334);
            this.panelMain.TabIndex = 4;
            // 
            // exitBtn
            // 
            this.exitBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.exitBtn.Location = new System.Drawing.Point(413, 298);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(127, 23);
            this.exitBtn.TabIndex = 6;
            this.exitBtn.Text = "خروج";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click_1);
            // 
            // editConsoleBtn
            // 
            this.editConsoleBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.editConsoleBtn.Location = new System.Drawing.Point(413, 266);
            this.editConsoleBtn.Name = "editConsoleBtn";
            this.editConsoleBtn.Size = new System.Drawing.Size(127, 26);
            this.editConsoleBtn.TabIndex = 5;
            this.editConsoleBtn.Text = "ویرایش دستگاه";
            this.editConsoleBtn.UseVisualStyleBackColor = true;
            // 
            // dgvConsole
            // 
            this.dgvConsole.AllowUserToAddRows = false;
            this.dgvConsole.AllowUserToDeleteRows = false;
            this.dgvConsole.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvConsole.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvConsole.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsole.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.quantityPrice,
            this.timePrice,
            this.consoleType});
            this.dgvConsole.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvConsole.Location = new System.Drawing.Point(0, 0);
            this.dgvConsole.Name = "dgvConsole";
            this.dgvConsole.ReadOnly = true;
            this.dgvConsole.Size = new System.Drawing.Size(552, 241);
            this.dgvConsole.TabIndex = 4;
            // 
            // id
            // 
            this.id.DataPropertyName = "Id";
            this.id.HeaderText = "شناسه";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // quantityPrice
            // 
            this.quantityPrice.DataPropertyName = "QuantityPriceController";
            this.quantityPrice.HeaderText = "قیمت براساس تعداد دسته";
            this.quantityPrice.Name = "quantityPrice";
            this.quantityPrice.ReadOnly = true;
            // 
            // timePrice
            // 
            this.timePrice.DataPropertyName = "TimePriceController";
            this.timePrice.HeaderText = "قیمت براساس زمان";
            this.timePrice.Name = "timePrice";
            this.timePrice.ReadOnly = true;
            // 
            // consoleType
            // 
            this.consoleType.DataPropertyName = "ConsoleType";
            this.consoleType.HeaderText = "نوع دستگاه";
            this.consoleType.Name = "consoleType";
            this.consoleType.ReadOnly = true;
            // 
            // settingFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 334);
            this.Controls.Add(this.panelMain);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "settingFrm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "تنظیمات";
            this.Load += new System.EventHandler(this.settingFrm_Load);
            this.panelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsole)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button editConsoleBtn;
        private System.Windows.Forms.DataGridView dgvConsole;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn timePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn consoleType;
    }
}