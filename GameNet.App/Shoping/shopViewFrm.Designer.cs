
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewShop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvViewShop
            // 
            this.dgvViewShop.AllowUserToAddRows = false;
            this.dgvViewShop.AllowUserToDeleteRows = false;
            this.dgvViewShop.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvViewShop.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgvViewShop.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvViewShop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvViewShop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.NameShop,
            this.SellCostShop});
            this.dgvViewShop.Location = new System.Drawing.Point(14, 12);
            this.dgvViewShop.MultiSelect = false;
            this.dgvViewShop.Name = "dgvViewShop";
            this.dgvViewShop.ReadOnly = true;
            this.dgvViewShop.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvViewShop.Size = new System.Drawing.Size(417, 153);
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
            this.orderQuantity.Location = new System.Drawing.Point(59, 174);
            this.orderQuantity.Name = "orderQuantity";
            this.orderQuantity.Size = new System.Drawing.Size(69, 20);
            this.orderQuantity.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 176);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "تعداد:";
            // 
            // saveShop
            // 
            this.saveShop.Location = new System.Drawing.Point(14, 200);
            this.saveShop.Name = "saveShop";
            this.saveShop.Size = new System.Drawing.Size(75, 23);
            this.saveShop.TabIndex = 5;
            this.saveShop.Text = "ثبت";
            this.saveShop.UseVisualStyleBackColor = true;
            this.saveShop.Click += new System.EventHandler(this.saveShop_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(356, 200);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(75, 23);
            this.exitBtn.TabIndex = 6;
            this.exitBtn.Text = "خروج";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // shopViewFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 234);
            this.ControlBox = false;
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.saveShop);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.orderQuantity);
            this.Controls.Add(this.dgvViewShop);
            this.Name = "shopViewFrm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "خرید بوفه";
            this.Load += new System.EventHandler(this.shopViewFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewShop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderQuantity)).EndInit();
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
    }
}