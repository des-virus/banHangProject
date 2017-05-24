namespace banHangProject.View.AdminManager.Report {
    partial class frmReport {
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.BaoCao = new banHangProject.View.AdminManager.Report.BaoCao();
            this.DataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataTableAdapter = new banHangProject.View.AdminManager.Report.BaoCaoTableAdapters.DataTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.BaoCao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "Baocao";
            reportDataSource1.Value = this.DataBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "banHangProject.View.AdminManager.Report.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(27, 17);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(620, 411);
            this.reportViewer1.TabIndex = 0;
            // 
            // BaoCao
            // 
            this.BaoCao.DataSetName = "BaoCao";
            this.BaoCao.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DataBindingSource
            // 
            this.DataBindingSource.DataMember = "Data";
            this.DataBindingSource.DataSource = this.BaoCao;
            // 
            // DataTableAdapter
            // 
            this.DataTableAdapter.ClearBeforeFill = true;
            // 
            // frmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 440);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmReport";
            this.Text = "frmReport";
            this.Load += new System.EventHandler(this.frmReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BaoCao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DataBindingSource;
        private BaoCao BaoCao;
        private BaoCaoTableAdapters.DataTableAdapter DataTableAdapter;
    }
}