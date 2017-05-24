using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace banHangProject.AdminManager.Division {
    public partial class frmEditDivision : Form {
        public frmEditDivision() {
            InitializeComponent();
        }
        public frmEditDivision(string _curIdString, string _curName) {
            curIdString = _curIdString;
            curName = _curName;
            InitializeComponent();
        }

        // Attribute
        private string curIdString = "", curName = "";
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


        private void frmEditDivision_Load(object sender, EventArgs e) {
            txtID.Text = curIdString;
            txtName.Text = curName;
        }



        private void btnAdd_Click(object sender, EventArgs e) {
            int salary = int.Parse(txtSalary.Text);
            Model.Division u = new Model.Division(txtID.Text, txtName.Text, salary);
            Controller.Connector.updateDivision(u);
            MessageBox.Show("Sửa thành công đơn vị " + txtID.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
