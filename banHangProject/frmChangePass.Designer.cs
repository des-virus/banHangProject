namespace banHangProject {
    partial class frmChangePass {
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
            this.ptbMinimize = new System.Windows.Forms.PictureBox();
            this.lbTitle = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtReNewPass = new System.Windows.Forms.TextBox();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.txtOldPass = new System.Windows.Forms.TextBox();
            this.txtAcc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMinimize)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ptbMinimize
            // 
            this.ptbMinimize.BackColor = System.Drawing.Color.Transparent;
            this.ptbMinimize.Image = global::banHangProject.Properties.Resources.Picture3;
            this.ptbMinimize.Location = new System.Drawing.Point(385, 0);
            this.ptbMinimize.Name = "ptbMinimize";
            this.ptbMinimize.Size = new System.Drawing.Size(35, 31);
            this.ptbMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbMinimize.TabIndex = 24;
            this.ptbMinimize.TabStop = false;
            this.ptbMinimize.Click += new System.EventHandler(this.ptbMinimize_Click);
            // 
            // lbTitle
            // 
            this.lbTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.lbTitle.Font = new System.Drawing.Font("UTM Facebook", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(238)))), ((int)(((byte)(244)))));
            this.lbTitle.Location = new System.Drawing.Point(0, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(420, 75);
            this.lbTitle.TabIndex = 23;
            this.lbTitle.Text = "Thay đổi mật khẩu";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbTitle_MouseDown);
            this.lbTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lbTitle_MouseMove);
            this.lbTitle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lbTitle_MouseUp);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtReNewPass);
            this.groupBox1.Controls.Add(this.txtNewPass);
            this.groupBox1.Controls.Add(this.txtOldPass);
            this.groupBox1.Controls.Add(this.txtAcc);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(30, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(355, 217);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin đăng nhập";
            // 
            // txtReNewPass
            // 
            this.txtReNewPass.Location = new System.Drawing.Point(195, 166);
            this.txtReNewPass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtReNewPass.Name = "txtReNewPass";
            this.txtReNewPass.PasswordChar = '*';
            this.txtReNewPass.Size = new System.Drawing.Size(148, 26);
            this.txtReNewPass.TabIndex = 3;
            // 
            // txtNewPass
            // 
            this.txtNewPass.Location = new System.Drawing.Point(195, 122);
            this.txtNewPass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.PasswordChar = '*';
            this.txtNewPass.Size = new System.Drawing.Size(148, 26);
            this.txtNewPass.TabIndex = 3;
            // 
            // txtOldPass
            // 
            this.txtOldPass.Location = new System.Drawing.Point(195, 78);
            this.txtOldPass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtOldPass.Name = "txtOldPass";
            this.txtOldPass.PasswordChar = '*';
            this.txtOldPass.Size = new System.Drawing.Size(148, 26);
            this.txtOldPass.TabIndex = 3;
            // 
            // txtAcc
            // 
            this.txtAcc.Location = new System.Drawing.Point(195, 34);
            this.txtAcc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAcc.Name = "txtAcc";
            this.txtAcc.Size = new System.Drawing.Size(148, 26);
            this.txtAcc.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 172);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Nhập lại mật khẩu mới";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 128);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Mật khẩu mới";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu cũ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tài khoản";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(229, 341);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 35);
            this.btnCancel.TabIndex = 26;
            this.btnCancel.Text = "Hủy bỏ";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAccept
            // 
            this.btnAccept.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.btnAccept.ForeColor = System.Drawing.Color.White;
            this.btnAccept.Location = new System.Drawing.Point(98, 341);
            this.btnAccept.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(112, 35);
            this.btnAccept.TabIndex = 25;
            this.btnAccept.Text = "Đồng ý";
            this.btnAccept.UseVisualStyleBackColor = false;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // frmChangePass
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(238)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(420, 400);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.ptbMinimize);
            this.Controls.Add(this.lbTitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmChangePass";
            this.Text = "Thay đổi mật khẩu";
            ((System.ComponentModel.ISupportInitialize)(this.ptbMinimize)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbMinimize;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtReNewPass;
        private System.Windows.Forms.TextBox txtNewPass;
        private System.Windows.Forms.TextBox txtOldPass;
        private System.Windows.Forms.TextBox txtAcc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAccept;
    }
}