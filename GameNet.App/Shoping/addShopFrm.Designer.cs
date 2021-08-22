
namespace GameNet.App.Shoping
{
    partial class addShopFrm
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
            this.close = new System.Windows.Forms.Button();
            this.addShopBtn = new System.Windows.Forms.Button();
            this.sellCostTxt = new System.Windows.Forms.TextBox();
            this.buyCostTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nameShop = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.close);
            this.groupBox1.Controls.Add(this.addShopBtn);
            this.groupBox1.Controls.Add(this.sellCostTxt);
            this.groupBox1.Controls.Add(this.buyCostTxt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.nameShop);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(307, 195);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "مشخصات خوراکی";
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(6, 157);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(75, 23);
            this.close.TabIndex = 6;
            this.close.Text = "انصراف";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // addShopBtn
            // 
            this.addShopBtn.Location = new System.Drawing.Point(223, 157);
            this.addShopBtn.Name = "addShopBtn";
            this.addShopBtn.Size = new System.Drawing.Size(75, 23);
            this.addShopBtn.TabIndex = 1;
            this.addShopBtn.Text = "ثبت";
            this.addShopBtn.UseVisualStyleBackColor = true;
            this.addShopBtn.Click += new System.EventHandler(this.addShopBtn_Click);
            // 
            // sellCostTxt
            // 
            this.sellCostTxt.Location = new System.Drawing.Point(115, 103);
            this.sellCostTxt.Name = "sellCostTxt";
            this.sellCostTxt.Size = new System.Drawing.Size(100, 20);
            this.sellCostTxt.TabIndex = 5;
            // 
            // buyCostTxt
            // 
            this.buyCostTxt.Location = new System.Drawing.Point(115, 68);
            this.buyCostTxt.Name = "buyCostTxt";
            this.buyCostTxt.Size = new System.Drawing.Size(100, 20);
            this.buyCostTxt.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(236, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "قیمت فروش :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(241, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "قیمت خرید :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(275, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "نام :";
            // 
            // nameShop
            // 
            this.nameShop.Location = new System.Drawing.Point(115, 34);
            this.nameShop.Name = "nameShop";
            this.nameShop.Size = new System.Drawing.Size(100, 20);
            this.nameShop.TabIndex = 0;
            // 
            // addShopFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 229);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "addShopFrm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "اضافه کردن خوراکی";
            this.Load += new System.EventHandler(this.addShopFrm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button addShopBtn;
        private System.Windows.Forms.TextBox sellCostTxt;
        private System.Windows.Forms.TextBox buyCostTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameShop;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
    }
}