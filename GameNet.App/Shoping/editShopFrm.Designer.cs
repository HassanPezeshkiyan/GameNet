
namespace GameNet.App.Shoping
{
    partial class editShopFrm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.quantityCounter = new System.Windows.Forms.NumericUpDown();
            this.close = new System.Windows.Forms.Button();
            this.editShopBtn = new System.Windows.Forms.Button();
            this.sellCostTxt = new System.Windows.Forms.TextBox();
            this.buyCostTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nameShop = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantityCounter)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.quantityCounter);
            this.groupBox1.Controls.Add(this.close);
            this.groupBox1.Controls.Add(this.editShopBtn);
            this.groupBox1.Controls.Add(this.sellCostTxt);
            this.groupBox1.Controls.Add(this.buyCostTxt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.nameShop);
            this.groupBox1.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(326, 216);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "مشخصات خوراکی";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(276, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "تعداد:";
            // 
            // quantityCounter
            // 
            this.quantityCounter.Location = new System.Drawing.Point(115, 134);
            this.quantityCounter.Name = "quantityCounter";
            this.quantityCounter.Size = new System.Drawing.Size(100, 31);
            this.quantityCounter.TabIndex = 8;
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(82)))), ((int)(((byte)(83)))));
            this.close.FlatAppearance.BorderSize = 0;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.Location = new System.Drawing.Point(20, 171);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(75, 32);
            this.close.TabIndex = 6;
            this.close.Text = "انصراف";
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // editShopBtn
            // 
            this.editShopBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(209)))), ((int)(((byte)(161)))));
            this.editShopBtn.FlatAppearance.BorderSize = 0;
            this.editShopBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editShopBtn.Location = new System.Drawing.Point(241, 171);
            this.editShopBtn.Name = "editShopBtn";
            this.editShopBtn.Size = new System.Drawing.Size(75, 32);
            this.editShopBtn.TabIndex = 1;
            this.editShopBtn.Text = "ثبت";
            this.editShopBtn.UseVisualStyleBackColor = false;
            this.editShopBtn.Click += new System.EventHandler(this.editShopBtn_Click);
            // 
            // sellCostTxt
            // 
            this.sellCostTxt.Location = new System.Drawing.Point(115, 97);
            this.sellCostTxt.Name = "sellCostTxt";
            this.sellCostTxt.Size = new System.Drawing.Size(100, 31);
            this.sellCostTxt.TabIndex = 5;
            // 
            // buyCostTxt
            // 
            this.buyCostTxt.Location = new System.Drawing.Point(115, 62);
            this.buyCostTxt.Name = "buyCostTxt";
            this.buyCostTxt.Size = new System.Drawing.Size(100, 31);
            this.buyCostTxt.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(236, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "قیمت فروش :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(241, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "قیمت خرید :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(284, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "نام :";
            // 
            // nameShop
            // 
            this.nameShop.Location = new System.Drawing.Point(115, 28);
            this.nameShop.Name = "nameShop";
            this.nameShop.Size = new System.Drawing.Size(100, 31);
            this.nameShop.TabIndex = 0;
            // 
            // editShopFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 241);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "editShopFrm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ویرایش خوراکی";
            this.Load += new System.EventHandler(this.editShopFrm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantityCounter)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button editShopBtn;
        private System.Windows.Forms.TextBox sellCostTxt;
        private System.Windows.Forms.TextBox buyCostTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameShop;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown quantityCounter;
    }
}