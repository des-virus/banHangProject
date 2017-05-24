using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace banHangProject.WareManager.Producer {
    public partial class frmAddProducer : Form {
        public frmAddProducer() {
            InitializeComponent();
        }
        public frmAddProducer(string _curIdString) {
            curIdString = _curIdString;
            InitializeComponent();
        }

        // Attribute
        private string curIdString = "";
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


        private void frmAddProducer_Load(object sender, EventArgs e) {
            txtID.Text = curIdString;
        }



        private void btnAdd_Click(object sender, EventArgs e) {
            Model.Producer u = new Model.Producer(txtID.Text, txtName.Text, txtAdd.Text, txtPhone.Text);
            if (Controller.Connector.insertProducer(u))
                MessageBox.Show("Thêm mới thành công nhà sản xuất " + txtID.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Thêm mới lỗi " + txtID.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            this.Close();
        }
    }
}
