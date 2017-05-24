using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace banHangProject.View.AdminManager.Report {
    public partial class frmReport : Form {
        public frmReport() {
            InitializeComponent();
        }

        private void frmReport_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'BaoCao.Data' table. You can move, or remove it, as needed.
            this.DataTableAdapter.Fill(this.BaoCao.Data,2016,2,5);

            this.reportViewer1.RefreshReport();
        }
    }
}
