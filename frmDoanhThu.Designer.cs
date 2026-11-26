namespace CellphoneS
{
    partial class frmDoanhThu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDenNgay = new System.Windows.Forms.Label();
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlDoanhThu = new System.Windows.Forms.Panel();
            this.lblDoanhThu = new System.Windows.Forms.Label();
            this.lblTieuDeDT = new System.Windows.Forms.Label();
            this.picDoanhThu = new System.Windows.Forms.PictureBox();
            this.pnlHoaDon = new System.Windows.Forms.Panel();
            this.lblHoaDon = new System.Windows.Forms.Label();
            this.lblTieuDeHD = new System.Windows.Forms.Label();
            this.picHoaDon = new System.Windows.Forms.PictureBox();
            this.pnlSanPham = new System.Windows.Forms.Panel();
            this.lblSanPham = new System.Windows.Forms.Label();
            this.lblTieuDeSP = new System.Windows.Forms.Label();
            this.picSanPham = new System.Windows.Forms.PictureBox();
            this.btnThongKe = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlDoanhThu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDoanhThu)).BeginInit();
            this.pnlHoaDon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHoaDon)).BeginInit();
            this.pnlSanPham.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Từ Ngày";
            // 
            // lblDenNgay
            // 
            this.lblDenNgay.AutoSize = true;
            this.lblDenNgay.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDenNgay.Location = new System.Drawing.Point(355, 115);
            this.lblDenNgay.Name = "lblDenNgay";
            this.lblDenNgay.Size = new System.Drawing.Size(86, 21);
            this.lblDenNgay.TabIndex = 1;
            this.lblDenNgay.Text = "Đến Ngày";
            // 
            // dtpTuNgay
            // 
            this.dtpTuNgay.CustomFormat = "dd/MM/yyyy";
            this.dtpTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTuNgay.Location = new System.Drawing.Point(139, 115);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.Size = new System.Drawing.Size(133, 26);
            this.dtpTuNgay.TabIndex = 2;
            // 
            // dtpDenNgay
            // 
            this.dtpDenNgay.CustomFormat = "dd/MM/yyyy";
            this.dtpDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDenNgay.Location = new System.Drawing.Point(477, 115);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.Size = new System.Drawing.Size(118, 26);
            this.dtpDenNgay.TabIndex = 3;
            // 
            // dgv1
            // 
            this.dgv1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Format = "d";
            dataGridViewCellStyle5.NullValue = "dd/MM/yyyy";
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(0)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv1.ColumnHeadersHeight = 40;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv1.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgv1.EnableHeadersVisualStyles = false;
            this.dgv1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.dgv1.Location = new System.Drawing.Point(12, 365);
            this.dgv1.Name = "dgv1";
            this.dgv1.ReadOnly = true;
            this.dgv1.RowHeadersVisible = false;
            this.dgv1.RowHeadersWidth = 62;
            this.dgv1.RowTemplate.Height = 28;
            this.dgv1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv1.Size = new System.Drawing.Size(1100, 185);
            this.dgv1.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(25)))), ((int)(((byte)(32)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1124, 100);
            this.panel1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CellphoneS.Properties.Resources.icons8_combo_chart_50;
            this.pictureBox1.Location = new System.Drawing.Point(936, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(151, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(227, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(389, 45);
            this.label5.TabIndex = 2;
            this.label5.Text = "THỐNG KÊ DOANH THU";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(210, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 45);
            this.label4.TabIndex = 1;
            this.label4.Text = "|";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(7, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 45);
            this.label3.TabIndex = 0;
            this.label3.Text = "CellPhoneS ";
            // 
            // pnlDoanhThu
            // 
            this.pnlDoanhThu.Controls.Add(this.lblDoanhThu);
            this.pnlDoanhThu.Controls.Add(this.lblTieuDeDT);
            this.pnlDoanhThu.Controls.Add(this.picDoanhThu);
            this.pnlDoanhThu.Location = new System.Drawing.Point(62, 166);
            this.pnlDoanhThu.Name = "pnlDoanhThu";
            this.pnlDoanhThu.Size = new System.Drawing.Size(239, 164);
            this.pnlDoanhThu.TabIndex = 7;
            // 
            // lblDoanhThu
            // 
            this.lblDoanhThu.AutoSize = true;
            this.lblDoanhThu.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoanhThu.ForeColor = System.Drawing.Color.Teal;
            this.lblDoanhThu.Location = new System.Drawing.Point(83, 123);
            this.lblDoanhThu.Name = "lblDoanhThu";
            this.lblDoanhThu.Size = new System.Drawing.Size(49, 21);
            this.lblDoanhThu.TabIndex = 2;
            this.lblDoanhThu.Text = "Tổng";
            this.lblDoanhThu.Click += new System.EventHandler(this.lblDoanhThu_Click);
            // 
            // lblTieuDeDT
            // 
            this.lblTieuDeDT.AutoSize = true;
            this.lblTieuDeDT.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDeDT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(25)))), ((int)(((byte)(32)))));
            this.lblTieuDeDT.Location = new System.Drawing.Point(50, 85);
            this.lblTieuDeDT.Name = "lblTieuDeDT";
            this.lblTieuDeDT.Size = new System.Drawing.Size(137, 21);
            this.lblTieuDeDT.TabIndex = 1;
            this.lblTieuDeDT.Text = "Tổng Doanh Thu";
            // 
            // picDoanhThu
            // 
            this.picDoanhThu.Image = global::CellphoneS.Properties.Resources.money_bags;
            this.picDoanhThu.Location = new System.Drawing.Point(63, 18);
            this.picDoanhThu.Name = "picDoanhThu";
            this.picDoanhThu.Size = new System.Drawing.Size(100, 50);
            this.picDoanhThu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDoanhThu.TabIndex = 0;
            this.picDoanhThu.TabStop = false;
            // 
            // pnlHoaDon
            // 
            this.pnlHoaDon.Controls.Add(this.lblHoaDon);
            this.pnlHoaDon.Controls.Add(this.lblTieuDeHD);
            this.pnlHoaDon.Controls.Add(this.picHoaDon);
            this.pnlHoaDon.Location = new System.Drawing.Point(421, 166);
            this.pnlHoaDon.Name = "pnlHoaDon";
            this.pnlHoaDon.Size = new System.Drawing.Size(239, 164);
            this.pnlHoaDon.TabIndex = 8;
            // 
            // lblHoaDon
            // 
            this.lblHoaDon.AutoSize = true;
            this.lblHoaDon.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoaDon.ForeColor = System.Drawing.Color.Teal;
            this.lblHoaDon.Location = new System.Drawing.Point(86, 123);
            this.lblHoaDon.Name = "lblHoaDon";
            this.lblHoaDon.Size = new System.Drawing.Size(49, 21);
            this.lblHoaDon.TabIndex = 3;
            this.lblHoaDon.Text = "Tổng";
            // 
            // lblTieuDeHD
            // 
            this.lblTieuDeHD.AutoSize = true;
            this.lblTieuDeHD.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDeHD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(25)))), ((int)(((byte)(32)))));
            this.lblTieuDeHD.Location = new System.Drawing.Point(61, 85);
            this.lblTieuDeHD.Name = "lblTieuDeHD";
            this.lblTieuDeHD.Size = new System.Drawing.Size(100, 21);
            this.lblTieuDeHD.TabIndex = 3;
            this.lblTieuDeHD.Text = "Số Hóa Đơn";
            // 
            // picHoaDon
            // 
            this.picHoaDon.Image = global::CellphoneS.Properties.Resources.bill;
            this.picHoaDon.Location = new System.Drawing.Point(65, 18);
            this.picHoaDon.Name = "picHoaDon";
            this.picHoaDon.Size = new System.Drawing.Size(100, 50);
            this.picHoaDon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHoaDon.TabIndex = 2;
            this.picHoaDon.TabStop = false;
            // 
            // pnlSanPham
            // 
            this.pnlSanPham.Controls.Add(this.lblSanPham);
            this.pnlSanPham.Controls.Add(this.lblTieuDeSP);
            this.pnlSanPham.Controls.Add(this.picSanPham);
            this.pnlSanPham.Location = new System.Drawing.Point(780, 166);
            this.pnlSanPham.Name = "pnlSanPham";
            this.pnlSanPham.Size = new System.Drawing.Size(239, 164);
            this.pnlSanPham.TabIndex = 8;
            // 
            // lblSanPham
            // 
            this.lblSanPham.AutoSize = true;
            this.lblSanPham.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSanPham.ForeColor = System.Drawing.Color.Teal;
            this.lblSanPham.Location = new System.Drawing.Point(93, 123);
            this.lblSanPham.Name = "lblSanPham";
            this.lblSanPham.Size = new System.Drawing.Size(49, 21);
            this.lblSanPham.TabIndex = 4;
            this.lblSanPham.Text = "Tổng";
            // 
            // lblTieuDeSP
            // 
            this.lblTieuDeSP.AutoSize = true;
            this.lblTieuDeSP.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDeSP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(25)))), ((int)(((byte)(32)))));
            this.lblTieuDeSP.Location = new System.Drawing.Point(68, 85);
            this.lblTieuDeSP.Name = "lblTieuDeSP";
            this.lblTieuDeSP.Size = new System.Drawing.Size(109, 21);
            this.lblTieuDeSP.TabIndex = 4;
            this.lblTieuDeSP.Text = "Số Sản Phẩm";
            // 
            // picSanPham
            // 
            this.picSanPham.Image = global::CellphoneS.Properties.Resources.box;
            this.picSanPham.Location = new System.Drawing.Point(72, 18);
            this.picSanPham.Name = "picSanPham";
            this.picSanPham.Size = new System.Drawing.Size(100, 50);
            this.picSanPham.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSanPham.TabIndex = 1;
            this.picSanPham.TabStop = false;
            // 
            // btnThongKe
            // 
            this.btnThongKe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(25)))), ((int)(((byte)(32)))));
            this.btnThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongKe.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.ForeColor = System.Drawing.Color.White;
            this.btnThongKe.Location = new System.Drawing.Point(703, 110);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(107, 37);
            this.btnThongKe.TabIndex = 9;
            this.btnThongKe.Text = "Thống Kê";
            this.btnThongKe.UseVisualStyleBackColor = false;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // frmDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 584);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.pnlHoaDon);
            this.Controls.Add(this.pnlSanPham);
            this.Controls.Add(this.pnlDoanhThu);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.dtpDenNgay);
            this.Controls.Add(this.dtpTuNgay);
            this.Controls.Add(this.lblDenNgay);
            this.Controls.Add(this.label1);
            this.Name = "frmDoanhThu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDoanhThu";
            this.Shown += new System.EventHandler(this.frmDoanhThu_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlDoanhThu.ResumeLayout(false);
            this.pnlDoanhThu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDoanhThu)).EndInit();
            this.pnlHoaDon.ResumeLayout(false);
            this.pnlHoaDon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHoaDon)).EndInit();
            this.pnlSanPham.ResumeLayout(false);
            this.pnlSanPham.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSanPham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDenNgay;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        private System.Windows.Forms.DateTimePicker dtpDenNgay;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlDoanhThu;
        private System.Windows.Forms.Label lblDoanhThu;
        private System.Windows.Forms.Label lblTieuDeDT;
        private System.Windows.Forms.PictureBox picDoanhThu;
        private System.Windows.Forms.Panel pnlHoaDon;
        private System.Windows.Forms.Label lblHoaDon;
        private System.Windows.Forms.Label lblTieuDeHD;
        private System.Windows.Forms.PictureBox picHoaDon;
        private System.Windows.Forms.Panel pnlSanPham;
        private System.Windows.Forms.Label lblSanPham;
        private System.Windows.Forms.Label lblTieuDeSP;
        private System.Windows.Forms.PictureBox picSanPham;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}