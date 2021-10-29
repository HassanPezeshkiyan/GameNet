
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelMain = new System.Windows.Forms.Panel();
            this.exitBtn = new System.Windows.Forms.Button();
            this.editConsoleBtn = new System.Windows.Forms.Button();
            this.dgvConsole = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityPriceController = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timepricecontroller = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.panelMain.Size = new System.Drawing.Size(797, 338);
            this.panelMain.TabIndex = 4;
            // 
            // exitBtn
            // 
            this.exitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.exitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exitBtn.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.exitBtn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.exitBtn.Location = new System.Drawing.Point(646, 292);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(127, 34);
            this.exitBtn.TabIndex = 9;
            this.exitBtn.Text = "خروج";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click_1);
            // 
            // editConsoleBtn
            // 
            this.editConsoleBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.editConsoleBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.editConsoleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.editConsoleBtn.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.editConsoleBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.editConsoleBtn.Location = new System.Drawing.Point(646, 252);
            this.editConsoleBtn.Name = "editConsoleBtn";
            this.editConsoleBtn.Size = new System.Drawing.Size(127, 34);
            this.editConsoleBtn.TabIndex = 8;
            this.editConsoleBtn.Text = "ویرایش دستگاه";
            this.editConsoleBtn.UseVisualStyleBackColor = false;
            this.editConsoleBtn.Click += new System.EventHandler(this.editConsoleBtn_Click_1);
            // 
            // dgvConsole
            // 
            this.dgvConsole.AllowUserToAddRows = false;
            this.dgvConsole.AllowUserToDeleteRows = false;
            this.dgvConsole.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvConsole.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvConsole.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsole.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.quantityPriceController,
            this.timepricecontroller,
            this.consoleType});
            this.dgvConsole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvConsole.Location = new System.Drawing.Point(0, 0);
            this.dgvConsole.Name = "dgvConsole";
            this.dgvConsole.ReadOnly = true;
            this.dgvConsole.Size = new System.Drawing.Size(797, 338);
            this.dgvConsole.TabIndex = 7;
            // 
            // id
            // 
            this.id.DataPropertyName = "Id";
            this.id.HeaderText = "شناسه";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // quantityPriceController
            // 
            this.quantityPriceController.DataPropertyName = "QuantityPriceController";
            this.quantityPriceController.HeaderText = "قیمت دسته ";
            this.quantityPriceController.Name = "quantityPriceController";
            this.quantityPriceController.ReadOnly = true;
            // 
            // timepricecontroller
            // 
            this.timepricecontroller.DataPropertyName = "TimePriceController";
            this.timepricecontroller.HeaderText = "قیمت زمان";
            this.timepricecontroller.Name = "timepricecontroller";
            this.timepricecontroller.ReadOnly = true;
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
            this.ClientSize = new System.Drawing.Size(797, 338);
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
        private System.Windows.Forms.DataGridView dgvConsole;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityPriceController;
        private System.Windows.Forms.DataGridViewTextBoxColumn timepricecontroller;
        private System.Windows.Forms.DataGridViewTextBoxColumn consoleType;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button editConsoleBtn;
    }
}