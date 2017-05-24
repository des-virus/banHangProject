using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace banHangProject.View.WareManager.Good {
    public partial class frmInput : Form {
        public frmInput() {
            InitializeComponent();
            txtPrice.Text = Price;
            txtInput.Text = MyStr;
        }

        // Attribute
        private string myStr = "";
        private string price = "";

        public string MyStr {
            get {
                return myStr;
            }

            set {
                myStr = value;
            }
        }

        public string Price {
            get {
                return price;
            }

            set {
                price = value;
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
