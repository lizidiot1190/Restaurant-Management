
namespace RestaurantManagement
{
    partial class fCount
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
            this.label1 = new System.Windows.Forms.Label();
            this.nmCount = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.btnCountOK = new DevExpress.XtraEditors.SimpleButton();
            this.btnCountReturn = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.nmCount)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số lượng:";
            // 
            // nmCount
            // 
            this.nmCount.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmCount.Location = new System.Drawing.Point(131, 21);
            this.nmCount.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nmCount.Name = "nmCount";
            this.nmCount.Size = new System.Drawing.Size(95, 23);
            this.nmCount.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ghi chú:";
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(131, 50);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(301, 85);
            this.txtNote.TabIndex = 2;
            // 
            // btnCountOK
            // 
            this.btnCountOK.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCountOK.Appearance.Options.UseFont = true;
            this.btnCountOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnCountOK.ImageOptions.Image = global::RestaurantManagement.Properties.Resources.icons8_ok_hand_30;
            this.btnCountOK.Location = new System.Drawing.Point(218, 144);
            this.btnCountOK.Name = "btnCountOK";
            this.btnCountOK.Size = new System.Drawing.Size(107, 41);
            this.btnCountOK.TabIndex = 3;
            this.btnCountOK.Text = "OK";
            this.btnCountOK.Click += new System.EventHandler(this.btnCountOK_Click);
            // 
            // btnCountReturn
            // 
            this.btnCountReturn.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCountReturn.Appearance.Options.UseFont = true;
            this.btnCountReturn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCountReturn.ImageOptions.Image = global::RestaurantManagement.Properties.Resources.icons8_return_30;
            this.btnCountReturn.Location = new System.Drawing.Point(331, 144);
            this.btnCountReturn.Name = "btnCountReturn";
            this.btnCountReturn.Size = new System.Drawing.Size(101, 41);
            this.btnCountReturn.TabIndex = 3;
            this.btnCountReturn.Text = "Quay lại";
            // 
            // fCount
            // 
            this.AcceptButton = this.btnCountOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCountReturn;
            this.ClientSize = new System.Drawing.Size(444, 196);
            this.Controls.Add(this.btnCountReturn);
            this.Controls.Add(this.btnCountOK);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nmCount);
            this.Controls.Add(this.label1);
            this.IconOptions.Image = global::RestaurantManagement.Properties.Resources.favicon_ico;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(450, 228);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(450, 228);
            this.Name = "fCount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Count";
            ((System.ComponentModel.ISupportInitialize)(this.nmCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nmCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNote;
        private DevExpress.XtraEditors.SimpleButton btnCountOK;
        private DevExpress.XtraEditors.SimpleButton btnCountReturn;
    }
}