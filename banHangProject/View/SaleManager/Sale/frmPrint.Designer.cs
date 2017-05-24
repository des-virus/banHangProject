namespace banHangProject.SaleManager.Sale {
    partial class frmPrint {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrint));
            this.ptbMinimize = new System.Windows.Forms.PictureBox();
            this.lbTitle = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnPay = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtEmployName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGuessPhone = new System.Windows.Forms.TextBox();
            this.txtGuessAdd = new System.Windows.Forms.TextBox();
            this.txtGuessName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBillID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmployeeID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.lbTotalPrice = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbTruePrice = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lbDiscount = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbMoneyByWord = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.order = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMinimize)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // ptbMinimize
            // 
            this.ptbMinimize.BackColor = System.Drawing.Color.Transparent;
            this.ptbMinimize.Image = ((System.Drawing.Image)(resources.GetObject("ptbMinimize.Image")));
            this.ptbMinimize.Location = new System.Drawing.Point(823, 1);
            this.ptbMinimize.Name = "ptbMinimize";
            this.ptbMinimize.Size = new System.Drawing.Size(35, 31);
            this.ptbMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbMinimize.TabIndex = 30;
            this.ptbMinimize.TabStop = false;
            this.ptbMinimize.Click += new System.EventHandler(this.ptbMinimize_Click);
            // 
            // lbTitle
            // 
            this.lbTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.lbTitle.Font = new System.Drawing.Font("UTM Facebook", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(238)))), ((int)(((byte)(244)))));
            this.lbTitle.Location = new System.Drawing.Point(-2, 1);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(860, 70);
            this.lbTitle.TabIndex = 29;
            this.lbTitle.Text = "In hóa đơn";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbTitle_MouseDown);
            this.lbTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lbTitle_MouseMove);
            this.lbTitle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lbTitle_MouseUp);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnExit);
            this.groupBox1.Controls.Add(this.btnPay);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.txtEmployName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtGuessPhone);
            this.groupBox1.Controls.Add(this.txtGuessAdd);
            this.groupBox1.Controls.Add(this.txtGuessName);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtBillID);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtEmployeeID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(7, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(851, 173);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin hóa đơn";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(701, 104);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(95, 42);
            this.btnExit.TabIndex = 17;
            this.btnExit.Text = "Trở lại";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.btnPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnPay.ForeColor = System.Drawing.Color.White;
            this.btnPay.Location = new System.Drawing.Point(577, 104);
            this.btnPay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(103, 42);
            this.btnPay.TabIndex = 17;
            this.btnPay.Text = "In hóa đơn";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yy";
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(374, 31);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(144, 24);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // txtEmployName
            // 
            this.txtEmployName.Enabled = false;
            this.txtEmployName.Location = new System.Drawing.Point(658, 66);
            this.txtEmployName.Name = "txtEmployName";
            this.txtEmployName.Size = new System.Drawing.Size(187, 24);
            this.txtEmployName.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(283, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ngày lập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(574, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên NV";
            // 
            // txtGuessPhone
            // 
            this.txtGuessPhone.Enabled = false;
            this.txtGuessPhone.Location = new System.Drawing.Point(374, 72);
            this.txtGuessPhone.Name = "txtGuessPhone";
            this.txtGuessPhone.Size = new System.Drawing.Size(144, 24);
            this.txtGuessPhone.TabIndex = 1;
            // 
            // txtGuessAdd
            // 
            this.txtGuessAdd.Enabled = false;
            this.txtGuessAdd.Location = new System.Drawing.Point(115, 116);
            this.txtGuessAdd.Name = "txtGuessAdd";
            this.txtGuessAdd.Size = new System.Drawing.Size(403, 24);
            this.txtGuessAdd.TabIndex = 1;
            // 
            // txtGuessName
            // 
            this.txtGuessName.Enabled = false;
            this.txtGuessName.Location = new System.Drawing.Point(115, 72);
            this.txtGuessName.Name = "txtGuessName";
            this.txtGuessName.Size = new System.Drawing.Size(139, 24);
            this.txtGuessName.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(283, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "SĐT";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 18);
            this.label7.TabIndex = 0;
            this.label7.Text = "Địa chỉ";
            // 
            // txtBillID
            // 
            this.txtBillID.Enabled = false;
            this.txtBillID.Location = new System.Drawing.Point(115, 31);
            this.txtBillID.Name = "txtBillID";
            this.txtBillID.Size = new System.Drawing.Size(139, 24);
            this.txtBillID.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tên khách";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Số HĐ";
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.Enabled = false;
            this.txtEmployeeID.Location = new System.Drawing.Point(658, 29);
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.Size = new System.Drawing.Size(187, 24);
            this.txtEmployeeID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(574, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã NV";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvData);
            this.groupBox2.Location = new System.Drawing.Point(7, 261);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(851, 270);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết hóa đơn";
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.AllowUserToOrderColumns = true;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.order,
            this.name,
            this.unit,
            this.outPrice,
            this.num,
            this.total});
            this.dgvData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvData.Location = new System.Drawing.Point(3, 20);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.RowHeadersVisible = false;
            this.dgvData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvData.Size = new System.Drawing.Size(845, 247);
            this.dgvData.TabIndex = 0;
            // 
            // lbTotalPrice
            // 
            this.lbTotalPrice.AutoSize = true;
            this.lbTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTotalPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbTotalPrice.Location = new System.Drawing.Point(145, 20);
            this.lbTotalPrice.Name = "lbTotalPrice";
            this.lbTotalPrice.Size = new System.Drawing.Size(109, 20);
            this.lbTotalPrice.TabIndex = 56;
            this.lbTotalPrice.Text = "150.000.000";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(35, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 20);
            this.label9.TabIndex = 55;
            this.label9.Text = "Tiền hàng";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(35, 48);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 20);
            this.label12.TabIndex = 55;
            this.label12.Text = "Thành tiền";
            // 
            // lbTruePrice
            // 
            this.lbTruePrice.AutoSize = true;
            this.lbTruePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTruePrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbTruePrice.Location = new System.Drawing.Point(147, 48);
            this.lbTruePrice.Name = "lbTruePrice";
            this.lbTruePrice.Size = new System.Drawing.Size(19, 20);
            this.lbTruePrice.TabIndex = 56;
            this.lbTruePrice.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(370, 20);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(95, 20);
            this.label14.TabIndex = 55;
            this.label14.Text = "Chiết khấu";
            // 
            // lbDiscount
            // 
            this.lbDiscount.AutoSize = true;
            this.lbDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbDiscount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbDiscount.Location = new System.Drawing.Point(482, 20);
            this.lbDiscount.Name = "lbDiscount";
            this.lbDiscount.Size = new System.Drawing.Size(19, 20);
            this.lbDiscount.TabIndex = 56;
            this.lbDiscount.Text = "0";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbTruePrice);
            this.groupBox3.Controls.Add(this.lbDiscount);
            this.groupBox3.Controls.Add(this.lbMoneyByWord);
            this.groupBox3.Controls.Add(this.lbTotalPrice);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(9, 537);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(846, 112);
            this.groupBox3.TabIndex = 57;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cộng";
            // 
            // lbMoneyByWord
            // 
            this.lbMoneyByWord.AutoSize = true;
            this.lbMoneyByWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbMoneyByWord.ForeColor = System.Drawing.Color.Red;
            this.lbMoneyByWord.Location = new System.Drawing.Point(145, 77);
            this.lbMoneyByWord.Name = "lbMoneyByWord";
            this.lbMoneyByWord.Size = new System.Drawing.Size(248, 20);
            this.lbMoneyByWord.TabIndex = 56;
            this.lbMoneyByWord.Text = "Một trăm năm mươi triệu đồng";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(35, 77);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(85, 20);
            this.label16.TabIndex = 55;
            this.label16.Text = "Bằng chữ";
            // 
            // order
            // 
            this.order.HeaderText = "STT";
            this.order.Name = "order";
            this.order.ReadOnly = true;
            this.order.Width = 50;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.HeaderText = "Tên linh kiện";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // unit
            // 
            this.unit.HeaderText = "Đơn vị";
            this.unit.Name = "unit";
            this.unit.ReadOnly = true;
            // 
            // outPrice
            // 
            this.outPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.outPrice.HeaderText = "Đơn giá";
            this.outPrice.Name = "outPrice";
            this.outPrice.ReadOnly = true;
            // 
            // num
            // 
            this.num.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.num.HeaderText = "Số lượng";
            this.num.Name = "num";
            this.num.ReadOnly = true;
            // 
            // total
            // 
            this.total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.total.HeaderText = "Tổng cộng";
            this.total.Name = "total";
            this.total.ReadOnly = true;
            // 
            // frmPrint
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(861, 659);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ptbMinimize);
            this.Controls.Add(this.lbTitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPrint";
            this.Text = "frmPrint";
            ((System.ComponentModel.ISupportInitialize)(this.ptbMinimize)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbMinimize;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtEmployName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGuessPhone;
        private System.Windows.Forms.TextBox txtGuessAdd;
        private System.Windows.Forms.TextBox txtGuessName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBillID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmployeeID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbTotalPrice;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbTruePrice;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lbDiscount;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lbMoneyByWord;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.DataGridViewTextBoxColumn order;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn outPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn num;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
    }
}