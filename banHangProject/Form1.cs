using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace banHangProject {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'csdlDataSet.HD_BAN' table. You can move, or remove it, as needed.
            this.HD_BANTableAdapter.Fill(this.csdlDataSet.HD_BAN);

            this.reportViewer1.RefreshReport();
        }
    }
}
