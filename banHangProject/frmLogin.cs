using banHangProject.Controller;
using banHangProject.Model;
using banHangProject.View.AdminManager;
using banHangProject.View.SaleManager.Sale;
using banHangProject.View.WareManager.Good;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace banHangProject {
    //public enum Permission {
    //    Admin = 0, Sale = 1, Ware = 2
    //}


    public partial class frmLogin : Form {

        //CONST
        const int ADMIN = 0, SALE = 1, WARE = 2;

        // Constructor
        public frmLogin() {
            InitializeComponent();
            myEmployeeList = new List<Employee>();
        }

        // Attribute
        string[] arrDivision = { "BP001", "BP002", "BP003" };
        private List<Model.Employee> myEmployeeList = null;
        private static int MOUSE_STATE = 0;
        private Point myLocation = new Point();
        private frmSale fSale = null;
        private frmAdmin fAdmin = null;
        private frmGood fGood = null;

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

        private void btnLogin_Click(object sender, EventArgs e) {
            string name = txtAcc.Text;
            string pass = txtPass.Text;
            Employee myEm = null;
            foreach (Employee u in myEmployeeList) {
                if (u.IdString == name && u.Password == pass) {
                    myEm = new Employee(u);
                    break;
                }
            }
            if (myEm == null) {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng");
                return;
            }

            if (myEm.Status == false) {
                MessageBox.Show("Nhân viên này đã không còn làm việc");
                return;
            }

            this.Hide();
            switch (myEm.Permission) {
                case ADMIN:
                    fAdmin = new frmAdmin();
                    fAdmin.CurEmploy = myEm;
                    if (fAdmin.ShowDialog() == DialogResult.Cancel)
                        frmLogin_Load(null, null);
                    break;
                case SALE:
                    fSale = new frmSale();
                    fSale.CurEmployee = myEm;
                    if (fSale.ShowDialog() == DialogResult.Cancel)
                        frmLogin_Load(null, null);
                    break;
                case WARE:
                    fGood = new frmGood();
                    fGood.CurEmployee = myEm;
                    if (fGood.ShowDialog() == DialogResult.Cancel)
                        frmLogin_Load(null, null);
                    break;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            frmChangePass fChangePass = new frmChangePass();
            fChangePass.MyEmployeeList = myEmployeeList;
            if (fChangePass.ShowDialog() == DialogResult.OK) {
                frmLogin_Load(null, null);
            }
        }

        private void frmLogin_Load(object sender, EventArgs e) {
            this.AcceptButton = btnLogin;
            string strCmd = "SELECT * FROM NHAN_VIEN";
            Connector.readEmployeeData(strCmd, myEmployeeList);
            this.Show();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnExit_Click(object sender, EventArgs e) {
            Application.Exit();
        }
    }
}
