namespace banHangProject.AdminManager.Division {
    partial class frmDivision {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDivision));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.cmsMainMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsAddMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsEditMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExit = new System.Windows.Forms.Button();
            this.lbTitle = new System.Windows.Forms.Label();
            this.ptbMinimize = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.cmsMainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMinimize)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Location = new System.Drawing.Point(9, 93);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(378, 103);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(32, 34);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(307, 26);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvData);
            this.groupBox2.Location = new System.Drawing.Point(0, 199);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(764, 263);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách";
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToOrderColumns = true;
            this.dgvData.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(238)))), ((int)(((byte)(244)))));
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.ContextMenuStrip = this.cmsMainMenu;
            this.dgvData.Location = new System.Drawing.Point(0, 29);
            this.dgvData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvData.Name = "dgvData";
            this.dgvData.Size = new System.Drawing.Size(759, 234);
            this.dgvData.TabIndex = 3;
            this.dgvData.CellContextMenuStripNeeded += new System.Windows.Forms.DataGridViewCellContextMenuStripNeededEventHandler(this.dgvData_CellContextMenuStripNeeded);
            // 
            // cmsMainMenu
            // 
            this.cmsMainMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(238)))), ((int)(((byte)(244)))));
            this.cmsMainMenu.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cmsMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsAddMenu,
            this.cmsEditMenu});
            this.cmsMainMenu.Name = "contextMenuStrip1";
            this.cmsMainMenu.Size = new System.Drawing.Size(113, 48);
            this.cmsMainMenu.Text = "Tùy chọn";
            // 
            // cmsAddMenu
            // 
            this.cmsAddMenu.Name = "cmsAddMenu";
            this.cmsAddMenu.Size = new System.Drawing.Size(112, 22);
            this.cmsAddMenu.Text = "Thêm";
            this.cmsAddMenu.Click += new System.EventHandler(this.cmsAddMenu_Click);
            // 
            // cmsEditMenu
            // 
            this.cmsEditMenu.Name = "cmsEditMenu";
            this.cmsEditMenu.Size = new System.Drawing.Size(112, 22);
            this.cmsEditMenu.Text = "Sửa";
            this.cmsEditMenu.Click += new System.EventHandler(this.cmsEditMenu_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(183)))), ((int)(((byte)(42)))));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(635, 161);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(112, 35);
            this.btnExit.TabIndex = 18;
            this.btnExit.Text = "Trở lại";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lbTitle
            // 
            this.lbTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.lbTitle.Font = new System.Drawing.Font("UTM Facebook", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(238)))), ((int)(((byte)(244)))));
            this.lbTitle.Location = new System.Drawing.Point(0, -1);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(760, 70);
            this.lbTitle.TabIndex = 21;
            this.lbTitle.Text = "Quản lý bộ phận";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbTitle_MouseDown);
            this.lbTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lbTitle_MouseMove);
            this.lbTitle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lbTitle_MouseUp);
            // 
            // ptbMinimize
            // 
            this.ptbMinimize.BackColor = System.Drawing.Color.Transparent;
            this.ptbMinimize.Image = ((System.Drawing.Image)(resources.GetObject("ptbMinimize.Image")));
            this.ptbMinimize.Location = new System.Drawing.Point(722, -1);
            this.ptbMinimize.Name = "ptbMinimize";
            this.ptbMinimize.Size = new System.Drawing.Size(35, 31);
            this.ptbMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbMinimize.TabIndex = 23;
            this.ptbMinimize.TabStop = false;
            this.ptbMinimize.Click += new System.EventHandler(this.ptbMinimize_Click);
            // 
            // frmUnit
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(238)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(760, 465);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.ptbMinimize);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lbTitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmUnit";
            this.Text = "frmUnit";
            this.Load += new System.EventHandler(this.frmDivision_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.cmsMainMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbMinimize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.ContextMenuStrip cmsMainMenu;
        private System.Windows.Forms.ToolStripMenuItem cmsAddMenu;
        private System.Windows.Forms.ToolStripMenuItem cmsEditMenu;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.PictureBox ptbMinimize;
    }
}