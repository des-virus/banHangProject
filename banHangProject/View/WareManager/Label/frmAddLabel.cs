﻿using banHangProject.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace banHangProject.WareManager.Label {
    public partial class frmAddLabel : Form {
        public frmAddLabel() {
            InitializeComponent();
        }

        public frmAddLabel(string _curIdString) {
            InitializeComponent();
            myTypeList = new List<Model.Type>();
            curIdString = _curIdString;
            // Lấy dữ liệu loại lk
            DataTable dtTemp = new DataTable();
            string strCmd = "select * from loai_lk";
            Connector.readTypeData(strCmd, myTypeList);

            // Đổ dữ liệu vào table
            dtTemp.Columns.Add("id");
            dtTemp.Columns.Add("name");

            // Set data to data table
            foreach (Model.Type u in myTypeList) {
                dtTemp.Rows.Add(u.IdString, u.Name);
            }
            // Set dữ liệu cho combobox
            cbType.ValueMember = "id";
            cbType.DisplayMember = "name";
            cbType.DataSource = dtTemp;
        }

        // Attribute
        private List<Model.Type> myTypeList;
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


        private void frmAddLabel_Load(object sender, EventArgs e) {
            txtID.Text = curIdString;
        }



        private void btnAdd_Click(object sender, EventArgs e) {
            Model.Label u = new Model.Label(txtID.Text, txtName.Text, cbType.SelectedValue.ToString(), cbType.Text);
            if(Controller.Connector.insertLabel(u))
                MessageBox.Show("Thêm mới thành công nhãn hiệu " + txtID.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Thêm mới thành công nhãn hiệu " + txtID.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }
    }
}
