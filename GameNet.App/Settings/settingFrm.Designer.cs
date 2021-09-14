
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
            this.dgvConsole = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.consoleType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editConsoleBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsole)).BeginInit();
            this.SuspendLayout();
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
            this.dgvConsole.Location = new System.Drawing.Point(12, 37);
            this.dgvConsole.Name = "dgvConsole";
            this.dgvConsole.ReadOnly = true;
            this.dgvConsole.Size = new System.Drawing.Size(622, 241);
            this.dgvConsole.TabIndex = 0;
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
            // editConsoleBtn
            // 
            this.editConsoleBtn.Location = new System.Drawing.Point(12, 8);
            this.editConsoleBtn.Name = "editConsoleBtn";
            this.editConsoleBtn.Size = new System.Drawing.Size(119, 23);
            this.editConsoleBtn.TabIndex = 1;
            this.editConsoleBtn.Text = "ویرایش دستگاه";
            this.editConsoleBtn.UseVisualStyleBackColor = true;
            this.editConsoleBtn.Click += new System.EventHandler(this.editConsoleBtn_Click);
            // 
            // settingFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 286);
            this.Controls.Add(this.editConsoleBtn);
            this.Controls.Add(this.dgvConsole);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "settingFrm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "تنظیمات";
            this.Load += new System.EventHandler(this.settingFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsole)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvConsole;
        private System.Windows.Forms.Button editConsoleBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn timePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn consoleType;
    }
}