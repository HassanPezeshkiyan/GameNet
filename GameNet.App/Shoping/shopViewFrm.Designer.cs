
namespace GameNet.App.Shoping
{
    partial class shopViewFrm
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
            this.dgvViewShop = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameShop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SellCostShop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderQuantity = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.saveShop = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.addShop = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.deleteShopBtn = new System.Windows.Forms.Button();
            this.listBoxOrder = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewShop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderQuantity)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvViewShop
            // 
            this.dgvViewShop.AllowUserToAddRows = false;
            this.dgvViewShop.AllowUserToDeleteRows = false;
            this.dgvViewShop.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvViewShop.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgvViewShop.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvViewShop.ColumnHeadersHeight = 30;
            this.dgvViewShop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvViewShop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.NameShop,
            this.SellCostShop});
            this.dgvViewShop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvViewShop.Location = new System.Drawing.Point(0, 0);
            this.dgvViewShop.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.dgvViewShop.MultiSelect = false;
            this.dgvViewShop.Name = "dgvViewShop";
            this.dgvViewShop.ReadOnly = true;
            this.dgvViewShop.Size = new System.Drawing.Size(738, 194);
            this.dgvViewShop.TabIndex = 2;
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Id.Visible = false;
            // 
            // NameShop
            // 
            this.NameShop.DataPropertyName = "Name";
            this.NameShop.HeaderText = "نام محصول";
            this.NameShop.Name = "NameShop";
            this.NameShop.ReadOnly = true;
            // 
            // SellCostShop
            // 
            this.SellCostShop.DataPropertyName = "SellCost";
            this.SellCostShop.HeaderText = "قیمت ";
            this.SellCostShop.Name = "SellCostShop";
            this.SellCostShop.ReadOnly = true;
            // 
            // orderQuantity
            // 
            this.orderQuantity.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.orderQuantity.Location = new System.Drawing.Point(62, 203);
            this.orderQuantity.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.orderQuantity.Name = "orderQuantity";
            this.orderQuantity.Size = new System.Drawing.Size(115, 31);
            this.orderQuantity.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(14, 205);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(38, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "تعداد:";
            // 
            // saveShop
            // 
            this.saveShop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.saveShop.FlatAppearance.BorderSize = 0;
            this.saveShop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saveShop.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.saveShop.Location = new System.Drawing.Point(18, 375);
            this.saveShop.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.saveShop.Name = "saveShop";
            this.saveShop.Size = new System.Drawing.Size(114, 36);
            this.saveShop.TabIndex = 5;
            this.saveShop.Text = "ثبت";
            this.saveShop.UseVisualStyleBackColor = false;
            this.saveShop.Click += new System.EventHandler(this.saveShop_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(82)))), ((int)(((byte)(83)))));
            this.exitBtn.FlatAppearance.BorderSize = 0;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exitBtn.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.exitBtn.Location = new System.Drawing.Point(610, 375);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(114, 36);
            this.exitBtn.TabIndex = 6;
            this.exitBtn.Text = "خروج";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // addShop
            // 
            this.addShop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(15)))), ((int)(((byte)(64)))));
            this.addShop.FlatAppearance.BorderSize = 0;
            this.addShop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addShop.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.addShop.ForeColor = System.Drawing.Color.White;
            this.addShop.Location = new System.Drawing.Point(18, 246);
            this.addShop.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.addShop.Name = "addShop";
            this.addShop.Size = new System.Drawing.Size(159, 36);
            this.addShop.TabIndex = 7;
            this.addShop.Text = "افزودن خوراکی";
            this.addShop.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addShop.UseVisualStyleBackColor = false;
            this.addShop.Click += new System.EventHandler(this.addShop_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvViewShop);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(738, 194);
            this.panel1.TabIndex = 9;
            // 
            // deleteShopBtn
            // 
            this.deleteShopBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.deleteShopBtn.FlatAppearance.BorderSize = 0;
            this.deleteShopBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteShopBtn.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.deleteShopBtn.ForeColor = System.Drawing.Color.White;
            this.deleteShopBtn.Location = new System.Drawing.Point(18, 291);
            this.deleteShopBtn.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.deleteShopBtn.Name = "deleteShopBtn";
            this.deleteShopBtn.Size = new System.Drawing.Size(159, 36);
            this.deleteShopBtn.TabIndex = 10;
            this.deleteShopBtn.Text = "حذف خوراکی";
            this.deleteShopBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteShopBtn.UseVisualStyleBackColor = false;
            this.deleteShopBtn.Click += new System.EventHandler(this.deleteShopBtn_Click);
            // 
            // listBoxOrder
            // 
            this.listBoxOrder.FormattingEnabled = true;
            this.listBoxOrder.ItemHeight = 24;
            this.listBoxOrder.Location = new System.Drawing.Point(224, 212);
            this.listBoxOrder.Name = "listBoxOrder";
            this.listBoxOrder.Size = new System.Drawing.Size(500, 124);
            this.listBoxOrder.TabIndex = 11;
            // 
            // shopViewFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 432);
            this.ControlBox = false;
            this.Controls.Add(this.listBoxOrder);
            this.Controls.Add(this.deleteShopBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.addShop);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.saveShop);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.orderQuantity);
            this.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "shopViewFrm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "خرید بوفه";
            this.Load += new System.EventHandler(this.shopViewFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewShop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderQuantity)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvViewShop;
        private System.Windows.Forms.NumericUpDown orderQuantity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button saveShop;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameShop;
        private System.Windows.Forms.DataGridViewTextBoxColumn SellCostShop;
        private System.Windows.Forms.Button addShop;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button deleteShopBtn;
        private System.Windows.Forms.ListBox listBoxOrder;
    }
}