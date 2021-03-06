
namespace GameNet.App
{
    partial class ShopFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShopFrm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.addShopBtn = new System.Windows.Forms.ToolStripButton();
            this.editShopBtn = new System.Windows.Forms.ToolStripButton();
            this.deleteShopBtn = new System.Windows.Forms.ToolStripButton();
            this.refreshBtn = new System.Windows.Forms.ToolStripButton();
            this.dgvShop = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameShop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SellCostShop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BuyCostShop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exitBtn = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShop)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addShopBtn,
            this.editShopBtn,
            this.deleteShopBtn,
            this.refreshBtn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(633, 103);
            this.toolStrip1.Stretch = true;
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // addShopBtn
            // 
            this.addShopBtn.AutoSize = false;
            this.addShopBtn.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.addShopBtn.Image = ((System.Drawing.Image)(resources.GetObject("addShopBtn.Image")));
            this.addShopBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.addShopBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addShopBtn.Name = "addShopBtn";
            this.addShopBtn.Size = new System.Drawing.Size(90, 90);
            this.addShopBtn.Text = "اضافه کردن ";
            this.addShopBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.addShopBtn.Click += new System.EventHandler(this.addShopBtn_Click);
            // 
            // editShopBtn
            // 
            this.editShopBtn.AutoSize = false;
            this.editShopBtn.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.editShopBtn.Image = ((System.Drawing.Image)(resources.GetObject("editShopBtn.Image")));
            this.editShopBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.editShopBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.editShopBtn.Name = "editShopBtn";
            this.editShopBtn.Size = new System.Drawing.Size(90, 90);
            this.editShopBtn.Text = "ویرایش کردن";
            this.editShopBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.editShopBtn.Click += new System.EventHandler(this.editShopBtn_Click);
            // 
            // deleteShopBtn
            // 
            this.deleteShopBtn.AutoSize = false;
            this.deleteShopBtn.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.deleteShopBtn.Image = ((System.Drawing.Image)(resources.GetObject("deleteShopBtn.Image")));
            this.deleteShopBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.deleteShopBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteShopBtn.Name = "deleteShopBtn";
            this.deleteShopBtn.Size = new System.Drawing.Size(90, 90);
            this.deleteShopBtn.Text = "حذف کردن";
            this.deleteShopBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.deleteShopBtn.Click += new System.EventHandler(this.deleteShopBtn_Click);
            // 
            // refreshBtn
            // 
            this.refreshBtn.AutoSize = false;
            this.refreshBtn.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.refreshBtn.Image = ((System.Drawing.Image)(resources.GetObject("refreshBtn.Image")));
            this.refreshBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.refreshBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(90, 90);
            this.refreshBtn.Text = "به روز رسانی";
            this.refreshBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // dgvShop
            // 
            this.dgvShop.AllowUserToAddRows = false;
            this.dgvShop.AllowUserToDeleteRows = false;
            this.dgvShop.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvShop.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgvShop.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("B Nazanin", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvShop.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvShop.ColumnHeadersHeight = 35;
            this.dgvShop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvShop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.NameShop,
            this.SellCostShop,
            this.BuyCostShop,
            this.quantity});
            this.dgvShop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvShop.Location = new System.Drawing.Point(0, 103);
            this.dgvShop.MultiSelect = false;
            this.dgvShop.Name = "dgvShop";
            this.dgvShop.ReadOnly = true;
            this.dgvShop.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvShop.Size = new System.Drawing.Size(633, 249);
            this.dgvShop.TabIndex = 1;
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
            this.SellCostShop.HeaderText = "قیمت فروش";
            this.SellCostShop.Name = "SellCostShop";
            this.SellCostShop.ReadOnly = true;
            // 
            // BuyCostShop
            // 
            this.BuyCostShop.DataPropertyName = "BuyCost";
            this.BuyCostShop.HeaderText = "قیمت خرید";
            this.BuyCostShop.Name = "BuyCostShop";
            this.BuyCostShop.ReadOnly = true;
            // 
            // quantity
            // 
            this.quantity.DataPropertyName = "Quantity";
            this.quantity.HeaderText = "تعداد";
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(82)))), ((int)(((byte)(83)))));
            this.exitBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.exitBtn.FlatAppearance.BorderSize = 0;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.exitBtn.Location = new System.Drawing.Point(0, 314);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(633, 38);
            this.exitBtn.TabIndex = 2;
            this.exitBtn.Text = "خروج";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // ShopFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(633, 352);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.dgvShop);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("B Nazanin", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "ShopFrm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "بوفه";
            this.TransparencyKey = System.Drawing.Color.Red;
            this.Load += new System.EventHandler(this.ShopFrm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShop)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton addShopBtn;
        private System.Windows.Forms.ToolStripButton deleteShopBtn;
        private System.Windows.Forms.ToolStripButton editShopBtn;
        private System.Windows.Forms.ToolStripButton refreshBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.DataGridView dgvShop;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameShop;
        private System.Windows.Forms.DataGridViewTextBoxColumn SellCostShop;
        private System.Windows.Forms.DataGridViewTextBoxColumn BuyCostShop;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
    }
}