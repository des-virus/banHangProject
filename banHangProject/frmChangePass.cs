using banHangProject.Controller;
using banHangProject.Model;
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
    public partial class frmChangePass : Form {
        public frmChangePass() {
            InitializeComponent();

        }

        private int[] size = { 7, 13, 30, 30, 10, 10 };
        private List<Model.Guess> myGuessList = null;
        private static int MOUSE_STATE = 0;
        private Point myLocation = new Point();

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

        private void btnExit_Click(object sender, EventArgs e) {
            this.Close();
        }
        private  List<Model.Employee> myEmployeeList;

        public List<Employee> MyEmployeeList {
            get {
                return myEmployeeList;
            }

            set {
                myEmployeeList = value;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btnAccept_Click(object sender, EventArgs e) {
            string name = txtAcc.Text;
            string pass = txtOldPass.Text;
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

            myEm.Password = txtNewPass.Text;
            if (Connector.updateEmployee(myEm)) {
                MessageBox.Show("Cập nhật mật khẩu thành công");
                DialogResult = DialogResult.OK;
                this.Close();
            }
            else
                MessageBox.Show("Cập nhật lỗi");

           
        }
    }
}
