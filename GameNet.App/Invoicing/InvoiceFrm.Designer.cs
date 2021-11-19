
namespace GameNet.App.Invoicing
{
    partial class InvoiceFrm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.shopCostLbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.timeTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cntrlCount = new System.Windows.Forms.NumericUpDown();
            this.chargeCost = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PayBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cntrlCount)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.shopCostLbl);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.timeTxt);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cntrlCount);
            this.panel1.Controls.Add(this.chargeCost);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(574, 308);
            this.panel1.TabIndex = 0;
            // 
            // shopCostLbl
            // 
            this.shopCostLbl.AutoSize = true;
            this.shopCostLbl.Location = new System.Drawing.Point(37, 171);
            this.shopCostLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.shopCostLbl.Name = "shopCostLbl";
            this.shopCostLbl.Size = new System.Drawing.Size(0, 24);
            this.shopCostLbl.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(494, 247);
            this.label5.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 24);
            this.label5.TabIndex = 26;
            this.label5.Text = "مدت زمان:";
            // 
            // timeTxt
            // 
            this.timeTxt.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.timeTxt.Location = new System.Drawing.Point(26, 244);
            this.timeTxt.Margin = new System.Windows.Forms.Padding(7);
            this.timeTxt.Name = "timeTxt";
            this.timeTxt.Size = new System.Drawing.Size(372, 31);
            this.timeTxt.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(489, 171);
            this.label4.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 24);
            this.label4.TabIndex = 24;
            this.label4.Text = "هزینه بوفه :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cntrlCount
            // 
            this.cntrlCount.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cntrlCount.Location = new System.Drawing.Point(26, 101);
            this.cntrlCount.Margin = new System.Windows.Forms.Padding(7);
            this.cntrlCount.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.cntrlCount.Name = "cntrlCount";
            this.cntrlCount.Size = new System.Drawing.Size(372, 31);
            this.cntrlCount.TabIndex = 23;
            // 
            // chargeCost
            // 
            this.chargeCost.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.chargeCost.Location = new System.Drawing.Point(26, 20);
            this.chargeCost.Margin = new System.Windows.Forms.Padding(7);
            this.chargeCost.Name = "chargeCost";
            this.chargeCost.Size = new System.Drawing.Size(372, 31);
            this.chargeCost.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(490, 103);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 24);
            this.label2.TabIndex = 21;
            this.label2.Text = "تعداد دسته:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(519, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(39, 24);
            this.label1.TabIndex = 20;
            this.label1.Text = "شارژ: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // PayBtn
            // 
            this.PayBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(15)))), ((int)(((byte)(64)))));
            this.PayBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.PayBtn.FlatAppearance.BorderSize = 0;
            this.PayBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PayBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PayBtn.Location = new System.Drawing.Point(0, 308);
            this.PayBtn.Name = "PayBtn";
            this.PayBtn.Size = new System.Drawing.Size(574, 46);
            this.PayBtn.TabIndex = 1;
            this.PayBtn.Text = "پرداخت";
            this.PayBtn.UseVisualStyleBackColor = false;
            this.PayBtn.Click += new System.EventHandler(this.PayBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(147)))), ((int)(((byte)(43)))));
            this.CancelBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.CancelBtn.FlatAppearance.BorderSize = 0;
            this.CancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CancelBtn.Location = new System.Drawing.Point(0, 354);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(574, 46);
            this.CancelBtn.TabIndex = 2;
            this.CancelBtn.Text = "انصراف";
            this.CancelBtn.UseVisualStyleBackColor = false;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // InvoiceFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 401);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.PayBtn);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.Name = "InvoiceFrm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "فاکتور";
            this.Load += new System.EventHandler(this.InvoiceFrm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cntrlCount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox timeTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown cntrlCount;
        private System.Windows.Forms.TextBox chargeCost;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button PayBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Label shopCostLbl;
    }
}