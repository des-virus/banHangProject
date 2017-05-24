namespace banHangProject.View.SaleManager.Sale {
    partial class frmSale {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSale));
            this.thêmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sdf = new System.Windows.Forms.Label();
            this.sửaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.llbBillOutList = new System.Windows.Forms.LinkLabel();
            this.llbGuessList = new System.Windows.Forms.LinkLabel();
            this.llbLogOut = new System.Windows.Forms.LinkLabel();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tabData = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ptbMinimize = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.tabData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMinimize)).BeginInit();
            this.SuspendLayout();
            // 
            // thêmToolStripMenuItem
            // 
            this.thêmToolStripMenuItem.Name = "thêmToolStripMenuItem";
            this.thêmToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.thêmToolStripMenuItem.Text = "Thêm vào giỏ hàng";
            // 
            // sdf
            // 
            this.sdf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.sdf.Font = new System.Drawing.Font("UTM Facebook", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sdf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(238)))), ((int)(((byte)(244)))));
            this.sdf.Location = new System.Drawing.Point(-1, 3);
            this.sdf.Name = "sdf";
            this.sdf.Size = new System.Drawing.Size(1358, 72);
            this.sdf.TabIndex = 49;
            this.sdf.Text = "Quản lý bán hàng";
            this.sdf.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.sdf.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbTitle_MouseDown);
            this.sdf.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lbTitle_MouseMove);
            this.sdf.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lbTitle_MouseUp);
            // 
            // sửaToolStripMenuItem
            // 
            this.sửaToolStripMenuItem.Name = "sửaToolStripMenuItem";
            this.sửaToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.sửaToolStripMenuItem.Text = "Thay đổi số lượng";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(238)))), ((int)(((byte)(244)))));
            this.contextMenuStrip1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmToolStripMenuItem,
            this.sửaToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(199, 48);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(191, 22);
            this.toolStripMenuItem3.Text = "Xóa khỏi giỏ hàng";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(191, 22);
            this.toolStripMenuItem2.Text = "Thay đổi số lượng";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.llbBillOutList);
            this.groupBox4.Controls.Add(this.llbGuessList);
            this.groupBox4.Controls.Add(this.llbLogOut);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox4.Location = new System.Drawing.Point(8, 78);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(197, 125);
            this.groupBox4.TabIndex = 57;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Danh mục quản lý";
            // 
            // llbBillOutList
            // 
            this.llbBillOutList.AutoSize = true;
            this.llbBillOutList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.llbBillOutList.Location = new System.Drawing.Point(25, 62);
            this.llbBillOutList.Name = "llbBillOutList";
            this.llbBillOutList.Size = new System.Drawing.Size(145, 20);
            this.llbBillOutList.TabIndex = 40;
            this.llbBillOutList.TabStop = true;
            this.llbBillOutList.Text = "Danh sách HĐ bán";
            this.llbBillOutList.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbBillOutList_LinkClicked);
            // 
            // llbGuessList
            // 
            this.llbGuessList.AutoSize = true;
            this.llbGuessList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.llbGuessList.Location = new System.Drawing.Point(25, 34);
            this.llbGuessList.Name = "llbGuessList";
            this.llbGuessList.Size = new System.Drawing.Size(112, 20);
            this.llbGuessList.TabIndex = 40;
            this.llbGuessList.TabStop = true;
            this.llbGuessList.Text = "Danh sách KH";
            this.llbGuessList.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbGuessList_LinkClicked);
            // 
            // llbLogOut
            // 
            this.llbLogOut.AutoSize = true;
            this.llbLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.llbLogOut.Location = new System.Drawing.Point(25, 90);
            this.llbLogOut.Name = "llbLogOut";
            this.llbLogOut.Size = new System.Drawing.Size(82, 20);
            this.llbLogOut.TabIndex = 39;
            this.llbLogOut.TabStop = true;
            this.llbLogOut.Text = "Đăng xuất";
            this.llbLogOut.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbLogOut_LinkClicked);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(238)))), ((int)(((byte)(244)))));
            this.contextMenuStrip2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.contextMenuStrip2.Name = "contextMenuStrip1";
            this.contextMenuStrip2.Size = new System.Drawing.Size(192, 48);
            // 
            // tabData
            // 
            this.tabData.Controls.Add(this.tabPage1);
            this.tabData.Controls.Add(this.tabPage2);
            this.tabData.Location = new System.Drawing.Point(211, 92);
            this.tabData.Name = "tabData";
            this.tabData.SelectedIndex = 0;
            this.tabData.Size = new System.Drawing.Size(1134, 614);
            this.tabData.TabIndex = 65;
            this.tabData.SelectedIndexChanged += new System.EventHandler(this.tabData_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1126, 581);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Hóa đơn 1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1126, 588);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "*";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ptbMinimize
            // 
            this.ptbMinimize.BackColor = System.Drawing.Color.Transparent;
            this.ptbMinimize.Image = ((System.Drawing.Image)(resources.GetObject("ptbMinimize.Image")));
            this.ptbMinimize.Location = new System.Drawing.Point(1322, 3);
            this.ptbMinimize.Name = "ptbMinimize";
            this.ptbMinimize.Size = new System.Drawing.Size(35, 31);
            this.ptbMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbMinimize.TabIndex = 66;
            this.ptbMinimize.TabStop = false;
            this.ptbMinimize.Click += new System.EventHandler(this.ptbMinimize_Click);
            // 
            // frmSale
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1357, 711);
            this.Controls.Add(this.ptbMinimize);
            this.Controls.Add(this.tabData);
            this.Controls.Add(this.sdf);
            this.Controls.Add(this.groupBox4);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSale";
            this.Text = "frmGood";
            this.Load += new System.EventHandler(this.frmSale_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.contextMenuStrip2.ResumeLayout(false);
            this.tabData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbMinimize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem thêmToolStripMenuItem;
        private System.Windows.Forms.Label sdf;
        private System.Windows.Forms.ToolStripMenuItem sửaToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.TabControl tabData;
        private System.Windows.Forms.LinkLabel llbLogOut;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.LinkLabel llbBillOutList;
        private System.Windows.Forms.LinkLabel llbGuessList;
        private System.Windows.Forms.PictureBox ptbMinimize;
    }
}