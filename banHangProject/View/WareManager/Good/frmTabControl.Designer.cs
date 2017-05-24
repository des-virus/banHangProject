namespace banHangProject.View.WareManager {
    partial class frmTabControl {
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
            this.components = new System.ComponentModel.Container();
            this.label32 = new System.Windows.Forms.Label();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lương = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsChangeNumber = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label33 = new System.Windows.Forms.Label();
            this.lbTotalPrice = new System.Windows.Forms.Label();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbTotalGood = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtFindProvider = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lbEmployeeName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbProvPhone = new System.Windows.Forms.Label();
            this.lbProvName = new System.Windows.Forms.Label();
            this.ptbAddProvider = new System.Windows.Forms.PictureBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            this.ptbProduce = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.btnPay = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbox1 = new banHangProject.Model.ComboBoxEx();
            this.label1 = new System.Windows.Forms.Label();
            this.rtbMoneyByWord = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAddProvider)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbProduce)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label32.ForeColor = System.Drawing.Color.Black;
            this.label32.Location = new System.Drawing.Point(805, 300);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(139, 17);
            this.label32.TabIndex = 75;
            this.label32.Text = "Tổng số mặt hàng";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Số lượng tồn";
            this.Column3.Name = "Column3";
            // 
            // Lương
            // 
            this.Lương.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Lương.HeaderText = "Đơn vị tính";
            this.Lương.Name = "Lương";
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.AllowUserToOrderColumns = true;
            this.dgvData.AllowUserToResizeRows = false;
            this.dgvData.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(238)))), ((int)(((byte)(244)))));
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvData.Location = new System.Drawing.Point(4, 22);
            this.dgvData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.Size = new System.Drawing.Size(751, 431);
            this.dgvData.TabIndex = 3;
            this.dgvData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsChangeNumber,
            this.cmsDelete});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(192, 70);
            // 
            // cmsChangeNumber
            // 
            this.cmsChangeNumber.Name = "cmsChangeNumber";
            this.cmsChangeNumber.Size = new System.Drawing.Size(191, 22);
            this.cmsChangeNumber.Text = "Thay đổi số lượng, giá";
            this.cmsChangeNumber.Click += new System.EventHandler(this.cmsChangeNumber_Click);
            // 
            // cmsDelete
            // 
            this.cmsDelete.Name = "cmsDelete";
            this.cmsDelete.Size = new System.Drawing.Size(191, 22);
            this.cmsDelete.Text = "Xóa khỏi giỏ hàng";
            this.cmsDelete.Click += new System.EventHandler(this.cmsDelete_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvData);
            this.groupBox2.Location = new System.Drawing.Point(22, 82);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(759, 458);
            this.groupBox2.TabIndex = 73;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách";
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Tên linh kiện";
            this.Column1.Name = "Column1";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label33.ForeColor = System.Drawing.Color.Black;
            this.label33.Location = new System.Drawing.Point(805, 329);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(77, 17);
            this.label33.TabIndex = 77;
            this.label33.Text = "Tổng tiền";
            // 
            // lbTotalPrice
            // 
            this.lbTotalPrice.AutoSize = true;
            this.lbTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTotalPrice.ForeColor = System.Drawing.Color.Red;
            this.lbTotalPrice.Location = new System.Drawing.Point(966, 329);
            this.lbTotalPrice.Name = "lbTotalPrice";
            this.lbTotalPrice.Size = new System.Drawing.Size(17, 17);
            this.lbTotalPrice.TabIndex = 80;
            this.lbTotalPrice.Text = "0";
            // 
            // STT
            // 
            this.STT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Đơn giá";
            this.Column2.Name = "Column2";
            // 
            // lbTotalGood
            // 
            this.lbTotalGood.AutoSize = true;
            this.lbTotalGood.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTotalGood.ForeColor = System.Drawing.Color.Red;
            this.lbTotalGood.Location = new System.Drawing.Point(966, 300);
            this.lbTotalGood.Name = "lbTotalGood";
            this.lbTotalGood.Size = new System.Drawing.Size(17, 17);
            this.lbTotalGood.TabIndex = 78;
            this.lbTotalGood.Text = "0";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.richTextBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(317, 251);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Ghi chú";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(6, 25);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(302, 190);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtFindProvider);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.lbEmployeeName);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.lbProvPhone);
            this.tabPage2.Controls.Add(this.lbProvName);
            this.tabPage2.Controls.Add(this.ptbAddProvider);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(317, 251);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Thông tin";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtFindProvider
            // 
            this.txtFindProvider.FormattingEnabled = true;
            this.txtFindProvider.Location = new System.Drawing.Point(6, 33);
            this.txtFindProvider.Name = "txtFindProvider";
            this.txtFindProvider.Size = new System.Drawing.Size(255, 26);
            this.txtFindProvider.TabIndex = 16;
            this.txtFindProvider.SelectedIndexChanged += new System.EventHandler(this.txtFindProvider_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 18);
            this.label6.TabIndex = 15;
            this.label6.Text = "Tên nhân viên ở đây";
            // 
            // lbEmployeeName
            // 
            this.lbEmployeeName.AutoSize = true;
            this.lbEmployeeName.ForeColor = System.Drawing.Color.Blue;
            this.lbEmployeeName.Location = new System.Drawing.Point(48, 156);
            this.lbEmployeeName.Name = "lbEmployeeName";
            this.lbEmployeeName.Size = new System.Drawing.Size(72, 18);
            this.lbEmployeeName.TabIndex = 15;
            this.lbEmployeeName.Text = "Nguyễn X";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 18);
            this.label5.TabIndex = 15;
            this.label5.Text = "Nhân viên:";
            // 
            // lbProvPhone
            // 
            this.lbProvPhone.AutoSize = true;
            this.lbProvPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbProvPhone.ForeColor = System.Drawing.Color.Blue;
            this.lbProvPhone.Location = new System.Drawing.Point(12, 93);
            this.lbProvPhone.Name = "lbProvPhone";
            this.lbProvPhone.Size = new System.Drawing.Size(44, 18);
            this.lbProvPhone.TabIndex = 13;
            this.lbProvPhone.Text = "0000";
            // 
            // lbProvName
            // 
            this.lbProvName.AutoSize = true;
            this.lbProvName.ForeColor = System.Drawing.Color.Blue;
            this.lbProvName.Location = new System.Drawing.Point(12, 69);
            this.lbProvName.Name = "lbProvName";
            this.lbProvName.Size = new System.Drawing.Size(99, 18);
            this.lbProvName.TabIndex = 14;
            this.lbProvName.Text = "Nhà cung cấp";
            // 
            // ptbAddProvider
            // 
            this.ptbAddProvider.Image = global::banHangProject.Properties.Resources.add_custome;
            this.ptbAddProvider.Location = new System.Drawing.Point(268, 23);
            this.ptbAddProvider.Name = "ptbAddProvider";
            this.ptbAddProvider.Size = new System.Drawing.Size(38, 36);
            this.ptbAddProvider.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbAddProvider.TabIndex = 10;
            this.ptbAddProvider.TabStop = false;
            this.ptbAddProvider.Click += new System.EventHandler(this.ptbAddProvider_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.rtbDescription);
            this.tabPage1.Controls.Add(this.ptbProduce);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(317, 246);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Chi tiết hàng";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // rtbDescription
            // 
            this.rtbDescription.Location = new System.Drawing.Point(16, 171);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.Size = new System.Drawing.Size(285, 68);
            this.rtbDescription.TabIndex = 76;
            this.rtbDescription.Text = "";
            // 
            // ptbProduce
            // 
            this.ptbProduce.BackColor = System.Drawing.Color.Black;
            this.ptbProduce.Image = global::banHangProject.Properties.Resources.Picture1;
            this.ptbProduce.Location = new System.Drawing.Point(71, 17);
            this.ptbProduce.Name = "ptbProduce";
            this.ptbProduce.Size = new System.Drawing.Size(172, 135);
            this.ptbProduce.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbProduce.TabIndex = 0;
            this.ptbProduce.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(788, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(325, 277);
            this.tabControl1.TabIndex = 74;
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.btnPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnPay.ForeColor = System.Drawing.Color.White;
            this.btnPay.Location = new System.Drawing.Point(816, 466);
            this.btnPay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(111, 37);
            this.btnPay.TabIndex = 81;
            this.btnPay.Text = "Thanh toán";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(964, 466);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(111, 37);
            this.btnClose.TabIndex = 81;
            this.btnClose.Text = "Đóng";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbox1);
            this.groupBox1.Location = new System.Drawing.Point(26, 1);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(751, 79);
            this.groupBox1.TabIndex = 84;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // cbox1
            // 
            this.cbox1.FormattingEnabled = true;
            this.cbox1.Location = new System.Drawing.Point(20, 35);
            this.cbox1.Name = "cbox1";
            this.cbox1.Size = new System.Drawing.Size(717, 26);
            this.cbox1.TabIndex = 0;
            this.cbox1.SelectedIndexChanged += new System.EventHandler(this.cbox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(811, 364);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 76;
            this.label1.Text = "Bằng chữ";
            // 
            // rtbMoneyByWord
            // 
            this.rtbMoneyByWord.Location = new System.Drawing.Point(816, 384);
            this.rtbMoneyByWord.Name = "rtbMoneyByWord";
            this.rtbMoneyByWord.Size = new System.Drawing.Size(283, 53);
            this.rtbMoneyByWord.TabIndex = 85;
            this.rtbMoneyByWord.Text = "Không đồng";
            // 
            // frmTabControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1118, 548);
            this.Controls.Add(this.rtbMoneyByWord);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.lbTotalPrice);
            this.Controls.Add(this.lbTotalGood);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTabControl";
            this.Text = "frmTabControl";
            this.Load += new System.EventHandler(this.frmTabControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAddProvider)).EndInit();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbProduce)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lương;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label lbTotalPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Label lbTotalGood;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbProvPhone;
        private System.Windows.Forms.Label lbProvName;
        private System.Windows.Forms.PictureBox ptbAddProvider;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox ptbProduce;
        private System.Windows.Forms.GroupBox groupBox1;
        private Model.ComboBoxEx cbox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cmsChangeNumber;
        private System.Windows.Forms.Label lbEmployeeName;
        private System.Windows.Forms.RichTextBox rtbDescription;
        private System.Windows.Forms.ComboBox txtFindProvider;
        private System.Windows.Forms.ToolStripMenuItem cmsDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtbMoneyByWord;
    }
}