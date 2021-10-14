
namespace RestaurantManagement
{
    partial class fTable
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
            this.btnAdmin = new DevExpress.XtraEditors.SimpleButton();
            this.flpTable = new System.Windows.Forms.FlowLayoutPanel();
            this.calendarControl1 = new DevExpress.XtraEditors.Controls.CalendarControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnLogout = new DevExpress.XtraEditors.SimpleButton();
            this.lbDisplayName = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.calendarControl1.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdmin
            // 
            this.btnAdmin.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.Appearance.Options.UseFont = true;
            this.btnAdmin.ImageOptions.Image = global::RestaurantManagement.Properties.Resources.icons8_admin_settings_male_50;
            this.btnAdmin.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnAdmin.Location = new System.Drawing.Point(8, 200);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(121, 80);
            this.btnAdmin.TabIndex = 2;
            this.btnAdmin.Text = "Quản lý cửa hàng";
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // flpTable
            // 
            this.flpTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpTable.AutoScroll = true;
            this.flpTable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpTable.Location = new System.Drawing.Point(256, 12);
            this.flpTable.Name = "flpTable";
            this.flpTable.Size = new System.Drawing.Size(636, 501);
            this.flpTable.TabIndex = 3;
            this.flpTable.Click += new System.EventHandler(this.flpTable_Click);
            // 
            // calendarControl1
            // 
            this.calendarControl1.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.calendarControl1.Location = new System.Drawing.Point(8, 286);
            this.calendarControl1.Name = "calendarControl1";
            this.calendarControl1.Size = new System.Drawing.Size(232, 227);
            this.calendarControl1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::RestaurantManagement.Properties.Resources.pngtree_user_vector_avatar_png_image_1541962;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(64, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 137);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(8, 167);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(60, 16);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "Xin chào:";
            // 
            // btnLogout
            // 
            this.btnLogout.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Appearance.Options.UseFont = true;
            this.btnLogout.ImageOptions.Image = global::RestaurantManagement.Properties.Resources.icons8_login_rounded_50;
            this.btnLogout.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnLogout.Location = new System.Drawing.Point(135, 200);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(109, 80);
            this.btnLogout.TabIndex = 8;
            this.btnLogout.Text = "Đăng xuất";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lbDisplayName
            // 
            this.lbDisplayName.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDisplayName.Appearance.Options.UseFont = true;
            this.lbDisplayName.Location = new System.Drawing.Point(74, 159);
            this.lbDisplayName.Name = "lbDisplayName";
            this.lbDisplayName.Size = new System.Drawing.Size(38, 25);
            this.lbDisplayName.TabIndex = 6;
            this.lbDisplayName.Text = "Tên";
            // 
            // fTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 531);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lbDisplayName);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.calendarControl1);
            this.Controls.Add(this.flpTable);
            this.Controls.Add(this.btnAdmin);
            this.IconOptions.Image = global::RestaurantManagement.Properties.Resources.favicon_ico;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(910, 563);
            this.Name = "fTable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm quản lý bán hàng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.fTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.calendarControl1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnAdmin;
        private System.Windows.Forms.FlowLayoutPanel flpTable;
        private DevExpress.XtraEditors.Controls.CalendarControl calendarControl1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnLogout;
        private DevExpress.XtraEditors.LabelControl lbDisplayName;
    }
}

