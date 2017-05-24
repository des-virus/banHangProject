using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace banHangProject.AdminManager.Employee {
    public partial class frmAddEmployee : Form {
        public frmAddEmployee() {
            InitializeComponent();
        }
        public frmAddEmployee(string _id)
        {
            curIdString = _id;
            InitializeComponent();
        }
        private string curIdString = "";
        private static int MOUSE_STATE = 0;
        private Point myLocation = new Point();

        // Event

        private void lbTitle_MouseDown(object sender, MouseEventArgs e)
        {
            MOUSE_STATE = 1;
            myLocation.X = e.X;
            myLocation.Y = e.Y;
        }

        private void lbTitle_MouseMove(object sender, MouseEventArgs e)
        {
            if (MOUSE_STATE == 1)
                this.SetDesktopLocation(MousePosition.X - myLocation.X, MousePosition.Y - myLocation.Y);
        }



        private void lbTitle_MouseUp(object sender, MouseEventArgs e)
        {
            MOUSE_STATE = 0;
        }

        private void ptbMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool status = true;
            if (rdoNghi.Checked == true)
                status = false;
            int _permission = cbxDiv.SelectedIndex;
            Model.Employee u = new Model.Employee(txtID.Text, txtName.Text, txtAdd.Text, cbxDiv.SelectedValue.ToString(), txtPhone.Text, status, _permission);
            if (Controller.Connector.insertEmployee(u))
                MessageBox.Show("Sửa thành công nhà cung cấp " + txtID.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Sửa lỗi " + txtID.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            this.Close();
        }

        private void frmAddEmployee_Load(object sender, EventArgs e)
        {
            txtID.Text = curIdString;
            string strCmd = "select * from Bo_phan";
            DataTable dtDiv = new DataTable();
            dtDiv.Columns.Add("ID");
            dtDiv.Columns.Add("Name");
            List<Model.Division> divList = new List<Model.Division>();

            Controller.Connector.readDivisionData(strCmd, divList);
            foreach (Model.Division i in divList)
            {
                dtDiv.Rows.Add(i.IdString, i.Name);
            }

            cbxDiv.DataSource = dtDiv;
            cbxDiv.DisplayMember = "Name";
            cbxDiv.ValueMember = "ID";
            cbxDiv.SelectedIndex = -1;

            rdoLam.Checked = true;
        }
    }
}
