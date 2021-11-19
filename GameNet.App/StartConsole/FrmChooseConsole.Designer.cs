
namespace GameNet.App.StartConsole
{
    partial class FrmChooseConsole
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSelect = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.numericUpDownConsole = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownConsole)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "شماره دستگاه:";
            // 
            // buttonSelect
            // 
            this.buttonSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(64)))), ((int)(((byte)(198)))));
            this.buttonSelect.FlatAppearance.BorderSize = 0;
            this.buttonSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSelect.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.buttonSelect.Location = new System.Drawing.Point(12, 86);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(81, 29);
            this.buttonSelect.TabIndex = 3;
            this.buttonSelect.Text = "انتخاب";
            this.buttonSelect.UseVisualStyleBackColor = false;
            this.buttonSelect.Click += new System.EventHandler(this.buttonSelect_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(87)))), ((int)(((byte)(119)))));
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.buttonClose.Location = new System.Drawing.Point(176, 86);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(81, 29);
            this.buttonClose.TabIndex = 4;
            this.buttonClose.Text = "لغو";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // numericUpDownConsole
            // 
            this.numericUpDownConsole.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.numericUpDownConsole.Location = new System.Drawing.Point(99, 20);
            this.numericUpDownConsole.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numericUpDownConsole.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownConsole.Name = "numericUpDownConsole";
            this.numericUpDownConsole.ReadOnly = true;
            this.numericUpDownConsole.Size = new System.Drawing.Size(158, 31);
            this.numericUpDownConsole.TabIndex = 5;
            this.numericUpDownConsole.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // FrmChooseConsole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(84)))), ((int)(((byte)(96)))));
            this.ClientSize = new System.Drawing.Size(269, 127);
            this.Controls.Add(this.numericUpDownConsole);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonSelect);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmChooseConsole";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "انتخاب دستگاه";
            this.Load += new System.EventHandler(this.FrmChooseConsole_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownConsole)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSelect;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.NumericUpDown numericUpDownConsole;
    }
}