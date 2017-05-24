using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace banHangProject.SaleManager.Sale {
    public partial class frmInputNumber : Form {

        // Attribute
        private string myStr = "";
        private int curNumber = 0;
        public frmInputNumber() {
            InitializeComponent();
        }

        public frmInputNumber(ref string myStr) {
            InitializeComponent();

        }

        public string MyStr {
            get {
                return myStr;
            }

            set {
                myStr = value;
            }
        }

        public int CurNumber {
            get {
                return curNumber;
            }

            set {
                curNumber = value;
            }
        }

        private void btnExit_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e) {
            myStr = txtInput.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
