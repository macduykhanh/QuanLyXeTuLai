
namespace BTL_Quanlychothuexedulich  
{
    partial class TraxeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TraxeForm));
            this.dgvtraxe = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMakh = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenkh = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBienso = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSongay = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblThanhTien = new System.Windows.Forms.Label();
            this.btnThanhtoan = new System.Windows.Forms.Button();
            this.btnXoaphieu = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDongia = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMaphieu = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMaxe = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnLoadForm = new System.Windows.Forms.Button();
            this.btnsapxep = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtraxe)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvtraxe
            // 
            this.dgvtraxe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtraxe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dgvtraxe.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvtraxe.Location = new System.Drawing.Point(0, 405);
            this.dgvtraxe.Name = "dgvtraxe";
            this.dgvtraxe.RowHeadersWidth = 51;
            this.dgvtraxe.RowTemplate.Height = 24;
            this.dgvtraxe.Size = new System.Drawing.Size(1207, 255);
            this.dgvtraxe.TabIndex = 10;
            this.dgvtraxe.SelectionChanged += new System.EventHandler(this.dgvtraxe_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Maphieu";
            this.Column1.HeaderText = "Mã phiếu";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Makh";
            this.Column2.HeaderText = "Mã khách hàng";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Tenkh";
            this.Column3.HeaderText = "Tên khách hàng";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Bienso";
            this.Column4.HeaderText = "Biển số xe";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Maxe";
            this.Column5.HeaderText = "Mã xe";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Songaythue";
            this.Column6.HeaderText = "Số ngày thuê";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "DongiaNgay";
            this.Column7.HeaderText = "Đơn giá thuê";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 125;
            // 
            // txtMakh
            // 
            this.txtMakh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMakh.Location = new System.Drawing.Point(434, 135);
            this.txtMakh.Name = "txtMakh";
            this.txtMakh.Size = new System.Drawing.Size(199, 27);
            this.txtMakh.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(283, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Mã khách hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(283, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tên khách hàng";
            // 
            // txtTenkh
            // 
            this.txtTenkh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenkh.Location = new System.Drawing.Point(434, 174);
            this.txtTenkh.Name = "txtTenkh";
            this.txtTenkh.Size = new System.Drawing.Size(199, 27);
            this.txtTenkh.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(283, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Biển số xe";
            // 
            // txtBienso
            // 
            this.txtBienso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBienso.Location = new System.Drawing.Point(434, 216);
            this.txtBienso.Name = "txtBienso";
            this.txtBienso.Size = new System.Drawing.Size(199, 27);
            this.txtBienso.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(283, 292);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Số ngày thuê";
            // 
            // txtSongay
            // 
            this.txtSongay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSongay.Location = new System.Drawing.Point(434, 292);
            this.txtSongay.Name = "txtSongay";
            this.txtSongay.Size = new System.Drawing.Size(199, 27);
            this.txtSongay.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(548, 373);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 29);
            this.label6.TabIndex = 5;
            this.label6.Text = "Thành Tiền : ";
            // 
            // lblThanhTien
            // 
            this.lblThanhTien.AutoSize = true;
            this.lblThanhTien.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblThanhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThanhTien.Location = new System.Drawing.Point(731, 373);
            this.lblThanhTien.Name = "lblThanhTien";
            this.lblThanhTien.Size = new System.Drawing.Size(26, 29);
            this.lblThanhTien.TabIndex = 5;
            this.lblThanhTien.Text = "0";
            // 
            // btnThanhtoan
            // 
            this.btnThanhtoan.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnThanhtoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThanhtoan.Image = ((System.Drawing.Image)(resources.GetObject("btnThanhtoan.Image")));
            this.btnThanhtoan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThanhtoan.Location = new System.Drawing.Point(667, 102);
            this.btnThanhtoan.Name = "btnThanhtoan";
            this.btnThanhtoan.Size = new System.Drawing.Size(171, 49);
            this.btnThanhtoan.TabIndex = 7;
            this.btnThanhtoan.Text = "      Thanh Toán";
            this.btnThanhtoan.UseVisualStyleBackColor = false;
            this.btnThanhtoan.Click += new System.EventHandler(this.btnThanhtoan_Click);
            // 
            // btnXoaphieu
            // 
            this.btnXoaphieu.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnXoaphieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoaphieu.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaphieu.Image")));
            this.btnXoaphieu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaphieu.Location = new System.Drawing.Point(667, 175);
            this.btnXoaphieu.Name = "btnXoaphieu";
            this.btnXoaphieu.Size = new System.Drawing.Size(171, 48);
            this.btnXoaphieu.TabIndex = 8;
            this.btnXoaphieu.Text = "   Xóa Phiếu";
            this.btnXoaphieu.UseVisualStyleBackColor = false;
            this.btnXoaphieu.Click += new System.EventHandler(this.btnXoaphieu_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(877, 233);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(196, 49);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "   Quay lại";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(283, 333);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "Đơn giá thuê";
            // 
            // txtDongia
            // 
            this.txtDongia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDongia.Location = new System.Drawing.Point(434, 333);
            this.txtDongia.Name = "txtDongia";
            this.txtDongia.Size = new System.Drawing.Size(199, 27);
            this.txtDongia.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(283, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 20);
            this.label8.TabIndex = 5;
            this.label8.Text = "Mã Phiếu";
            // 
            // txtMaphieu
            // 
            this.txtMaphieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaphieu.Location = new System.Drawing.Point(434, 102);
            this.txtMaphieu.Name = "txtMaphieu";
            this.txtMaphieu.Size = new System.Drawing.Size(199, 27);
            this.txtMaphieu.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(283, 252);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 20);
            this.label9.TabIndex = 5;
            this.label9.Text = "Mã xe";
            // 
            // txtMaxe
            // 
            this.txtMaxe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaxe.Location = new System.Drawing.Point(434, 252);
            this.txtMaxe.Name = "txtMaxe";
            this.txtMaxe.Size = new System.Drawing.Size(199, 27);
            this.txtMaxe.TabIndex = 4;
            // 
            // btnTim
            // 
            this.btnTim.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.Image = ((System.Drawing.Image)(resources.GetObject("btnTim.Image")));
            this.btnTim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTim.Location = new System.Drawing.Point(667, 236);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(171, 46);
            this.btnTim.TabIndex = 11;
            this.btnTim.Text = "Tìm ";
            this.btnTim.UseVisualStyleBackColor = false;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // btnLoadForm
            // 
            this.btnLoadForm.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnLoadForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadForm.Image = ((System.Drawing.Image)(resources.GetObject("btnLoadForm.Image")));
            this.btnLoadForm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoadForm.Location = new System.Drawing.Point(877, 102);
            this.btnLoadForm.Name = "btnLoadForm";
            this.btnLoadForm.Size = new System.Drawing.Size(196, 47);
            this.btnLoadForm.TabIndex = 12;
            this.btnLoadForm.Text = "   LoadForm";
            this.btnLoadForm.UseVisualStyleBackColor = false;
            this.btnLoadForm.Click += new System.EventHandler(this.btnLoadForm_Click);
            // 
            // btnsapxep
            // 
            this.btnsapxep.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnsapxep.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsapxep.Location = new System.Drawing.Point(877, 175);
            this.btnsapxep.Name = "btnsapxep";
            this.btnsapxep.Size = new System.Drawing.Size(196, 48);
            this.btnsapxep.TabIndex = 29;
            this.btnsapxep.Text = "Sắp xếp";
            this.btnsapxep.UseVisualStyleBackColor = false;
            this.btnsapxep.Click += new System.EventHandler(this.btnsapxep_Click);
            // 
            // TraxeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1207, 660);
            this.Controls.Add(this.btnsapxep);
            this.Controls.Add(this.btnLoadForm);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnXoaphieu);
            this.Controls.Add(this.btnThanhtoan);
            this.Controls.Add(this.txtDongia);
            this.Controls.Add(this.txtMaxe);
            this.Controls.Add(this.txtSongay);
            this.Controls.Add(this.lblThanhTien);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBienso);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTenkh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaphieu);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtMakh);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvtraxe);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TraxeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thanh Toán";
            this.Load += new System.EventHandler(this.TraxeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvtraxe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvtraxe;
        private System.Windows.Forms.TextBox txtMakh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenkh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBienso;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSongay;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblThanhTien;
        private System.Windows.Forms.Button btnThanhtoan;
        private System.Windows.Forms.Button btnXoaphieu;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDongia;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMaphieu;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMaxe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnLoadForm;
        private System.Windows.Forms.Button btnsapxep;
    }
}