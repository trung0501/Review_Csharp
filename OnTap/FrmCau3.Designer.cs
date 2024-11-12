namespace OnTap
{
    partial class FrmCau3
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtTuoi = new System.Windows.Forms.TextBox();
            this.txtBanthang = new System.Windows.Forms.TextBox();
            this.txtluong = new System.Windows.Forms.TextBox();
            this.dgvcauthu = new System.Windows.Forms.DataGridView();
            this.btThem = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btDong = new System.Windows.Forms.Button();
            this.btDau = new System.Windows.Forms.Button();
            this.btTruoc = new System.Windows.Forms.Button();
            this.btSau = new System.Windows.Forms.Button();
            this.btCuoi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcauthu)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên cầu thủ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số bàn thắng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Lương";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tuổi";
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(143, 51);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(228, 26);
            this.txtTen.TabIndex = 5;
            // 
            // txtTuoi
            // 
            this.txtTuoi.Location = new System.Drawing.Point(143, 95);
            this.txtTuoi.Name = "txtTuoi";
            this.txtTuoi.Size = new System.Drawing.Size(100, 26);
            this.txtTuoi.TabIndex = 6;
            // 
            // txtBanthang
            // 
            this.txtBanthang.Location = new System.Drawing.Point(143, 146);
            this.txtBanthang.Name = "txtBanthang";
            this.txtBanthang.Size = new System.Drawing.Size(100, 26);
            this.txtBanthang.TabIndex = 7;
            // 
            // txtluong
            // 
            this.txtluong.Location = new System.Drawing.Point(143, 199);
            this.txtluong.Name = "txtluong";
            this.txtluong.Size = new System.Drawing.Size(100, 26);
            this.txtluong.TabIndex = 8;
            // 
            // dgvcauthu
            // 
            this.dgvcauthu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcauthu.Location = new System.Drawing.Point(405, 22);
            this.dgvcauthu.Name = "dgvcauthu";
            this.dgvcauthu.RowHeadersWidth = 62;
            this.dgvcauthu.RowTemplate.Height = 28;
            this.dgvcauthu.Size = new System.Drawing.Size(579, 275);
            this.dgvcauthu.TabIndex = 9;
            this.dgvcauthu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvcauthu_CellContentClick);
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(127, 420);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(75, 37);
            this.btThem.TabIndex = 10;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btSua
            // 
            this.btSua.Location = new System.Drawing.Point(326, 420);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(75, 37);
            this.btSua.TabIndex = 11;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(558, 420);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(75, 37);
            this.btXoa.TabIndex = 12;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btDong
            // 
            this.btDong.Location = new System.Drawing.Point(798, 420);
            this.btDong.Name = "btDong";
            this.btDong.Size = new System.Drawing.Size(75, 37);
            this.btDong.TabIndex = 13;
            this.btDong.Text = "Đóng";
            this.btDong.UseVisualStyleBackColor = true;
            this.btDong.Click += new System.EventHandler(this.btDong_Click);
            // 
            // btDau
            // 
            this.btDau.Location = new System.Drawing.Point(127, 330);
            this.btDau.Name = "btDau";
            this.btDau.Size = new System.Drawing.Size(75, 34);
            this.btDau.TabIndex = 14;
            this.btDau.Text = "|<<";
            this.btDau.UseVisualStyleBackColor = true;
            this.btDau.Click += new System.EventHandler(this.btDau_Click);
            // 
            // btTruoc
            // 
            this.btTruoc.Location = new System.Drawing.Point(326, 330);
            this.btTruoc.Name = "btTruoc";
            this.btTruoc.Size = new System.Drawing.Size(75, 34);
            this.btTruoc.TabIndex = 15;
            this.btTruoc.Text = "<<";
            this.btTruoc.UseVisualStyleBackColor = true;
            this.btTruoc.Click += new System.EventHandler(this.btTruoc_Click);
            // 
            // btSau
            // 
            this.btSau.Location = new System.Drawing.Point(558, 330);
            this.btSau.Name = "btSau";
            this.btSau.Size = new System.Drawing.Size(75, 34);
            this.btSau.TabIndex = 16;
            this.btSau.Text = ">>";
            this.btSau.UseVisualStyleBackColor = true;
            this.btSau.Click += new System.EventHandler(this.btSau_Click);
            // 
            // btCuoi
            // 
            this.btCuoi.Location = new System.Drawing.Point(798, 330);
            this.btCuoi.Name = "btCuoi";
            this.btCuoi.Size = new System.Drawing.Size(75, 34);
            this.btCuoi.TabIndex = 17;
            this.btCuoi.Text = ">>|";
            this.btCuoi.UseVisualStyleBackColor = true;
            this.btCuoi.Click += new System.EventHandler(this.btCuoi_Click);
            // 
            // FrmCau3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 523);
            this.Controls.Add(this.btCuoi);
            this.Controls.Add(this.btSau);
            this.Controls.Add(this.btTruoc);
            this.Controls.Add(this.btDau);
            this.Controls.Add(this.btDong);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.dgvcauthu);
            this.Controls.Add(this.txtluong);
            this.Controls.Add(this.txtBanthang);
            this.Controls.Add(this.txtTuoi);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "FrmCau3";
            this.Text = "FrmCau3";
            this.Load += new System.EventHandler(this.FrmCau3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvcauthu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtTuoi;
        private System.Windows.Forms.TextBox txtBanthang;
        private System.Windows.Forms.TextBox txtluong;
        private System.Windows.Forms.DataGridView dgvcauthu;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btDong;
        private System.Windows.Forms.Button btDau;
        private System.Windows.Forms.Button btTruoc;
        private System.Windows.Forms.Button btSau;
        private System.Windows.Forms.Button btCuoi;
    }
}