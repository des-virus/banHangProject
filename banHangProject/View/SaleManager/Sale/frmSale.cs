using banHangProject.WareManager.Producer;
using banHangProject.WareManager.Label;
using banHangProject.WareManager.Type;
using banHangProject.WareManager.Unit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using banHangProject.SaleManager.Guess;
using banHangProject.Model;
using banHangProject.SaleManager.Sale;

namespace banHangProject.View.SaleManager.Sale {
    public partial class frmSale : Form {
        public frmSale() {
            InitializeComponent();
        }

        // Attribute
        private Model.Employee curEmployee;
        private static int MOUSE_STATE = 0;
        private Point myLocation = new Point();
        private int next_tab = 1;

        public Employee CurEmployee {
            get {
                return curEmployee;
            }

            set {
                curEmployee = value;
            }
        }

        // Event

        private void lbTitle_MouseDown(object sender, MouseEventArgs e) {
            MOUSE_STATE = 1;
            myLocation.X = e.X;
            myLocation.Y = e.Y;
        }

        private void lbTitle_MouseMove(object sender, MouseEventArgs e) {
            if (MOUSE_STATE == 1)
                this.SetDesktopLocation(MousePosition.X - myLocation.X, MousePosition.Y - myLocation.Y);
        }



        private void lbTitle_MouseUp(object sender, MouseEventArgs e) {
            MOUSE_STATE = 0;
        }

        private void ptbMinimize_Click(object sender, EventArgs e) {
            this.WindowState = FormWindowState.Minimized;
        }

        

        private void llbLogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void llbGuess_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            frmGuess myFrmGuess = new frmGuess();
            myFrmGuess.StartPosition = FormStartPosition.CenterParent;
            myFrmGuess.ShowDialog();
        }

        private void llbBillOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {

        }

        
        private void btnAddBill_Click(object sender, EventArgs e) {
            frmTabControl fTest = new frmTabControl();
            TabPage t1 = new TabPage();

            // Set top level
            fTest.TopLevel = false;
            fTest.Parent = t1;
            tabData.TabPages.Add(t1);
            t1.Text = "Hóa đơn " + next_tab;
            next_tab++;
            fTest.Visible = true;
            tabData.SelectedTab = t1;


        }

        private void frmSale_Load(object sender, EventArgs e) {
            // Load for tab 1
            TabPage t1 = tabData.TabPages[0];
            frmTabControl fTest = new frmTabControl();
            fTest.CurEmployee = CurEmployee;

            // Set top level
            fTest.TopLevel = false;
            fTest.Parent = t1;
            //tabData.TabPages.Add(t1);
            t1.Text = "Hóa đơn " + next_tab;
            next_tab++;
            fTest.Visible = true;
            tabData.SelectedTab = t1;
        }

        private void tabData_SelectedIndexChanged(object sender, EventArgs e) {
            if (tabData.SelectedIndex == tabData.TabCount - 1) {
                frmTabControl fTest = new frmTabControl();
                fTest.CurEmployee = curEmployee;
                TabPage tab = new TabPage("*");
                tabData.SelectedTab.Text = "Hóa đơn " + next_tab;
                next_tab++;
                fTest.TopLevel = false;
                fTest.Parent = tabData.SelectedTab;
                fTest.Visible = true;
                tabData.TabPages.Add(tab);

                this.StartPosition = FormStartPosition.CenterScreen;
            }
        }

        private void llbGuessList_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            frmGuess fGuess = new frmGuess();
            fGuess.ShowDialog();
        }

        private void llbBillOutList_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            frmBillOut fBillOut = new frmBillOut();
            fBillOut.StartPosition = FormStartPosition.CenterParent;
            fBillOut.ShowDialog();
        }
    }
}
