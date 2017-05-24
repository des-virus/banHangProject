using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using banHangProject.Model;
using banHangProject.View.SaleManager.Sale;
using banHangProject.View.WareManager.Good;
using banHangProject.AdminManager.Division;

namespace banHangProject.View.AdminManager {
    public partial class frmAdmin : Form {
        public frmAdmin() {
            InitializeComponent();
        }

        private Model.Employee curEmploy;

        public Employee CurEmploy {
            get {
                return curEmploy;
            }

            set {
                curEmploy = value;
            }
        }

        private void llbLogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            this.Close();
        }

        private void llbSale_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            frmSale fSale = new frmSale();
            fSale.CurEmployee = CurEmploy;
            if (fSale.ShowDialog() == DialogResult.Cancel)
                this.frmAdmin_Load(null, null);
        }

        private void frmAdmin_Load(object sender, EventArgs e) {

        }

        private void llbWare_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            frmGood fGood = new frmGood();
            fGood.CurEmployee = CurEmploy;
            if (fGood.ShowDialog() == DialogResult.Cancel)
                frmAdmin_Load(null, null);
        }

        private void llbDiv_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            frmDivision fDiv = new frmDivision();
            fDiv.ShowDialog();
        }
    }
}
