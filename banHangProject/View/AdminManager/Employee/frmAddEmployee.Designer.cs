namespace banHangProject.AdminManager.Employee {
    partial class frmAddEmployee {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddEmployee));
            this.rdoLam = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoNghi = new System.Windows.Forms.RadioButton();
            this.cbxDiv = new System.Windows.Forms.ComboBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtAdd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.ptbMinimize = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMinimize)).BeginInit();
            this.SuspendLayout();
            // 
            // rdoLam
            // 
            this.rdoLam.AutoSize = true;
            this.rdoLam.Location = new System.Drawing.Point(22, 25);
            this.rdoLam.Name = "rdoLam";
            this.rdoLam.Size = new System.Drawing.Size(62, 24);
            this.rdoLam.TabIndex = 0;
            this.rdoLam.TabStop = true;
            this.rdoLam.Text = "Làm ";
            this.rdoLam.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoNghi);
            this.groupBox1.Controls.Add(this.rdoLam);
            this.groupBox1.Location = new System.Drawing.Point(139, 279);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(157, 61);
            this.groupBox1.TabIndex = 75;
            this.groupBox1.TabStop = false;
            // 
            // rdoNghi
            // 
            this.rdoNghi.AutoSize = true;
            this.rdoNghi.Location = new System.Drawing.Point(94, 25);
            this.rdoNghi.Name = "rdoNghi";
            this.rdoNghi.Size = new System.Drawing.Size(59, 24);
            this.rdoNghi.TabIndex = 1;
            this.rdoNghi.TabStop = true;
            this.rdoNghi.Text = "Nghỉ";
            this.rdoNghi.UseVisualStyleBackColor = true;
            // 
            // cbxDiv
            // 
            this.cbxDiv.FormattingEnabled = true;
            this.cbxDiv.Location = new System.Drawing.Point(138, 195);
            this.cbxDiv.Name = "cbxDiv";
            this.cbxDiv.Size = new System.Drawing.Size(158, 28);
            this.cbxDiv.TabIndex = 74;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(183)))), ((int)(((byte)(42)))));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(204, 363);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(88, 35);
            this.btnExit.TabIndex = 65;
            this.btnExit.Text = "Hủy";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(183)))), ((int)(((byte)(42)))));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(75, 363);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(90, 35);
            this.btnAdd.TabIndex = 64;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(139, 235);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(160, 26);
            this.txtPhone.TabIndex = 63;
            // 
            // txtAdd
            // 
            this.txtAdd.Location = new System.Drawing.Point(138, 157);
            this.txtAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAdd.Name = "txtAdd";
            this.txtAdd.Size = new System.Drawing.Size(160, 26);
            this.txtAdd.TabIndex = 62;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 291);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 20);
            this.label6.TabIndex = 69;
            this.label6.Text = "Tình trạng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 243);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 70;
            this.label4.Text = "Số ĐT";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(138, 119);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(160, 26);
            this.txtName.TabIndex = 61;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 206);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 20);
            this.label5.TabIndex = 71;
            this.label5.Text = "Mã BP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 168);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 72;
            this.label3.Text = "Địa chỉ";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(138, 81);
            this.txtID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(160, 26);
            this.txtID.TabIndex = 60;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 134);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 73;
            this.label2.Text = "Tên NV";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 89);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 68;
            this.label1.Text = "Mã NV";
            // 
            // lbTitle
            // 
            this.lbTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.lbTitle.Font = new System.Drawing.Font("UTM Facebook", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(238)))), ((int)(((byte)(244)))));
            this.lbTitle.Location = new System.Drawing.Point(0, -2);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(349, 70);
            this.lbTitle.TabIndex = 66;
            this.lbTitle.Text = "Thêm NV";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbTitle_MouseDown);
            this.lbTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lbTitle_MouseMove);
            this.lbTitle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lbTitle_MouseUp);
            // 
            // ptbMinimize
            // 
            this.ptbMinimize.BackColor = System.Drawing.Color.Transparent;
            this.ptbMinimize.Image = ((System.Drawing.Image)(resources.GetObject("ptbMinimize.Image")));
            this.ptbMinimize.Location = new System.Drawing.Point(314, -2);
            this.ptbMinimize.Name = "ptbMinimize";
            this.ptbMinimize.Size = new System.Drawing.Size(35, 31);
            this.ptbMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbMinimize.TabIndex = 67;
            this.ptbMinimize.TabStop = false;
            this.ptbMinimize.Click += new System.EventHandler(this.ptbMinimize_Click);
            // 
            // frmAddEmployee
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(351, 432);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbxDiv);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtAdd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ptbMinimize);
            this.Controls.Add(this.lbTitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddEmployee";
            this.Text = "frmAddEmployee";
            this.Load += new System.EventHandler(this.frmAddEmployee_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMinimize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdoLam;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoNghi;
        private System.Windows.Forms.ComboBox cbxDiv;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtAdd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox ptbMinimize;
        private System.Windows.Forms.Label lbTitle;
    }
}