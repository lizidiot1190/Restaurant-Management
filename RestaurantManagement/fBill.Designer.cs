
namespace RestaurantManagement
{
    partial class fBill
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
            this.flpFood = new System.Windows.Forms.FlowLayoutPanel();
            this.lbTableName = new System.Windows.Forms.Label();
            this.btnPay = new DevExpress.XtraEditors.SimpleButton();
            this.cbChooseTable = new System.Windows.Forms.ComboBox();
            this.btnChooseTable = new DevExpress.XtraEditors.SimpleButton();
            this.btnDiscount = new DevExpress.XtraEditors.SimpleButton();
            this.dgvBill = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbDiscount = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.g = new System.Windows.Forms.Label();
            this.lbCheckin = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).BeginInit();
            this.SuspendLayout();
            // 
            // flpFood
            // 
            this.flpFood.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpFood.AutoScroll = true;
            this.flpFood.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpFood.Location = new System.Drawing.Point(12, 58);
            this.flpFood.Name = "flpFood";
            this.flpFood.Size = new System.Drawing.Size(499, 465);
            this.flpFood.TabIndex = 0;
            // 
            // lbTableName
            // 
            this.lbTableName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTableName.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTableName.Location = new System.Drawing.Point(12, 7);
            this.lbTableName.Name = "lbTableName";
            this.lbTableName.Size = new System.Drawing.Size(184, 46);
            this.lbTableName.TabIndex = 2;
            this.lbTableName.Text = "Tên bàn";
            // 
            // btnPay
            // 
            this.btnPay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPay.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.Appearance.Options.UseFont = true;
            this.btnPay.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnPay.ImageOptions.Image = global::RestaurantManagement.Properties.Resources.icons8_checkout_64;
            this.btnPay.Location = new System.Drawing.Point(786, 443);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(197, 80);
            this.btnPay.TabIndex = 5;
            this.btnPay.Text = "Thanh toán";
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // cbChooseTable
            // 
            this.cbChooseTable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbChooseTable.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbChooseTable.FormattingEnabled = true;
            this.cbChooseTable.Location = new System.Drawing.Point(517, 403);
            this.cbChooseTable.Name = "cbChooseTable";
            this.cbChooseTable.Size = new System.Drawing.Size(102, 24);
            this.cbChooseTable.TabIndex = 6;
            // 
            // btnChooseTable
            // 
            this.btnChooseTable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChooseTable.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChooseTable.Appearance.Options.UseFont = true;
            this.btnChooseTable.ImageOptions.Image = global::RestaurantManagement.Properties.Resources.icons8_chevron_right_50;
            this.btnChooseTable.Location = new System.Drawing.Point(637, 385);
            this.btnChooseTable.Name = "btnChooseTable";
            this.btnChooseTable.Size = new System.Drawing.Size(139, 60);
            this.btnChooseTable.TabIndex = 7;
            this.btnChooseTable.Text = "Chuyển bàn";
            this.btnChooseTable.Click += new System.EventHandler(this.btnChooseTable_Click);
            // 
            // btnDiscount
            // 
            this.btnDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDiscount.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiscount.Appearance.Options.UseFont = true;
            this.btnDiscount.ImageOptions.Image = global::RestaurantManagement.Properties.Resources.icons8_discount_50;
            this.btnDiscount.Location = new System.Drawing.Point(637, 463);
            this.btnDiscount.Name = "btnDiscount";
            this.btnDiscount.Size = new System.Drawing.Size(139, 60);
            this.btnDiscount.TabIndex = 7;
            this.btnDiscount.Text = "Giảm giá";
            this.btnDiscount.Click += new System.EventHandler(this.btnDiscount_Click);
            // 
            // dgvBill
            // 
            this.dgvBill.AllowUserToAddRows = false;
            this.dgvBill.AllowUserToDeleteRows = false;
            this.dgvBill.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvBill.Location = new System.Drawing.Point(517, 58);
            this.dgvBill.Name = "dgvBill";
            this.dgvBill.ReadOnly = true;
            this.dgvBill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBill.Size = new System.Drawing.Size(466, 321);
            this.dgvBill.TabIndex = 9;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Tên món";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Số lượng";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Đơn giá";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Thành Tiền";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Ghi chú";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotalPrice.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPrice.Location = new System.Drawing.Point(844, 399);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.ReadOnly = true;
            this.txtTotalPrice.Size = new System.Drawing.Size(139, 23);
            this.txtTotalPrice.TabIndex = 10;
            this.txtTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(782, 403);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 19);
            this.label1.TabIndex = 11;
            this.label1.Text = "Tổng:";
            // 
            // cbDiscount
            // 
            this.cbDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbDiscount.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDiscount.FormattingEnabled = true;
            this.cbDiscount.Items.AddRange(new object[] {
            "5",
            "10",
            "15",
            "20",
            "25",
            "30",
            "35",
            "40",
            "45",
            "50",
            "55",
            "60",
            "65",
            "70",
            "75",
            "80",
            "85",
            "90",
            "95"});
            this.cbDiscount.Location = new System.Drawing.Point(517, 481);
            this.cbDiscount.Name = "cbDiscount";
            this.cbDiscount.Size = new System.Drawing.Size(82, 24);
            this.cbDiscount.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(605, 482);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 18);
            this.label2.TabIndex = 12;
            this.label2.Text = "%";
            // 
            // g
            // 
            this.g.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.g.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.g.Location = new System.Drawing.Point(202, 23);
            this.g.Name = "g";
            this.g.Size = new System.Drawing.Size(133, 28);
            this.g.TabIndex = 2;
            this.g.Text = "Giờ vào :";
            // 
            // lbCheckin
            // 
            this.lbCheckin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbCheckin.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCheckin.Location = new System.Drawing.Point(320, 23);
            this.lbCheckin.Name = "lbCheckin";
            this.lbCheckin.Size = new System.Drawing.Size(133, 28);
            this.lbCheckin.TabIndex = 2;
            this.lbCheckin.Text = "Time";
            // 
            // fBill
            // 
            this.AcceptButton = this.btnPay;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 535);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnChooseTable);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTotalPrice);
            this.Controls.Add(this.dgvBill);
            this.Controls.Add(this.btnDiscount);
            this.Controls.Add(this.cbDiscount);
            this.Controls.Add(this.cbChooseTable);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.lbCheckin);
            this.Controls.Add(this.g);
            this.Controls.Add(this.lbTableName);
            this.Controls.Add(this.flpFood);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IconOptions.Image = global::RestaurantManagement.Properties.Resources.favicon_ico;
            this.MinimumSize = new System.Drawing.Size(1003, 567);
            this.Name = "fBill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin bàn";
            this.Load += new System.EventHandler(this.fBill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpFood;
        private System.Windows.Forms.Label lbTableName;
        private DevExpress.XtraEditors.SimpleButton btnPay;
        private System.Windows.Forms.ComboBox cbChooseTable;
        private DevExpress.XtraEditors.SimpleButton btnChooseTable;
        private DevExpress.XtraEditors.SimpleButton btnDiscount;
        private System.Windows.Forms.DataGridView dgvBill;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.ComboBox cbDiscount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label g;
        private System.Windows.Forms.Label lbCheckin;
    }
}