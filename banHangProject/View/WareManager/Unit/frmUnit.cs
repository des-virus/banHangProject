﻿using banHangProject.Controller;
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

namespace banHangProject.WareManager.Unit {
   
    public partial class frmUnit : Form {
        public frmUnit() {
            InitializeComponent();
        }


        // Attribute
        // BindingSource và DataTable để lấy lọc dữ liệu
        private BindingSource bsTemp = null;
        private DataTable dtTemp = null;
        private string[] strColName = { "order", "id", "name"};
        private string[] strHeader = { "STT", "Mã đơn vị", "Tên đơn vị"};
        private int[] size = { 10, 30, 60};
        private List<Model.Unit> myUnitList = null;
        private static int MOUSE_STATE = 0;
        private Point myLocation = new Point();


        //test
        
        

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


        // end coppy
        private void frmUnit_Load(object sender, EventArgs e) {
            // Init source
            // Trong các hàm cms gọi lại load -> gán lại về null
            // để bộ dọn rác tự dọn rồi khởi tạo lại
            if (dtTemp != null)
                dtTemp = null;
            if (bsTemp != null)
                bsTemp = null;
            dtTemp = new DataTable();
            bsTemp = new BindingSource();

            // Ý tưởng cả đoạn dưới:
            //- Lấy dữ liệu vào data table
            //- Gán data table cho bindingsource
            //- Gán bindingsource cho datagridview.datasource
            //** làm quanh vậy để làm gì?
            //** vì không làm thế méo lọc được :v

            // Get data
            if (myUnitList != null)
                myUnitList = null;
            myUnitList = new List<Model.Unit>();
            string strCmd = "select * from DON_VI";
            Connector.readUnitData(strCmd, myUnitList);

            // Set data table column
            for (int i = 0; i < strHeader.Length; i++) {
                dtTemp.Columns.Add(strColName[i]);
            }


            // Set data to data table
            foreach (Model.Unit u in myUnitList) {
                dtTemp.Rows.Add(u.Id, u.IdString, u.Name);
            }

            // Set source
            bsTemp.DataSource = dtTemp;
            dgvData.DataSource = bsTemp.DataSource;

            // Set view for data grid view
            for (int i = 0; i < strHeader.Length; i++) {
                dgvData.Columns[i].Width = (dgvData.Width / 100) * size[i];
                dgvData.Columns[i].HeaderText = strHeader[i];
            }

            // Set font, chế độ chọn theo hàng
            dgvData.DefaultCellStyle.Font = new Font("Segoe UI", 12);
            dgvData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }

        private void cmsAddMenu_Click(object sender, EventArgs e) {
            int index = myUnitList.Count - 1;
            int curId = myUnitList.ElementAt<Model.Unit>(index).Id;
            curId++;
            string curIdString = Model.Unit.LABEL + string.Format("{0:000}", curId);
            frmAddUnit frmAdd = new frmAddUnit(curIdString);
            frmAdd.StartPosition = FormStartPosition.CenterParent;
            DialogResult dlg = frmAdd.ShowDialog(this);
            if (dlg == DialogResult.Cancel)
                frmUnit_Load(null, null);
            dgvData.FirstDisplayedScrollingRowIndex = dgvData.RowCount - 2;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e) {
            string filter = string.Format("name like '%{0}%' or id like '%{1}%'", txtSearch.Text, txtSearch.Text);
            bsTemp.Filter = filter;
            dgvData.DataSource = bsTemp;
            
        }
        

        private void cmsEditMenu_Click(object sender, EventArgs e) {
            // Ý tưởng:
            //- Lấy hàng hiện tại
            //- Lấy dữ liệu: id, name
            //- Nhét vào hàm tạo thằng Edit
            //- Đặt form ra giữa
            //- Thằng Edit xử lý xong gọi lại form load lại dữ liệu 
            //- Chọn thằng cuối. Maybe chọn thằng vừa định sửa
            DataGridViewRow curRow = dgvData.Rows[dgvData.CurrentCell.RowIndex];
            string curIdString = curRow.Cells[1].Value.ToString();
            string curName = curRow.Cells[2].Value.ToString();
            frmEditUnit frmEdit = new frmEditUnit(curIdString, curName);
            frmEdit.StartPosition = FormStartPosition.CenterParent;
            DialogResult dlg = frmEdit.ShowDialog(this);
            if (dlg == DialogResult.Cancel)
                frmUnit_Load(null, null);
            dgvData.FirstDisplayedScrollingRowIndex = dgvData.RowCount - 2;
        }

        private void dgvData_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e) {
            dgvData.ClearSelection();
            int rowSelected = e.RowIndex;
            if (e.RowIndex != -1) {
                this.dgvData.Rows[rowSelected].Selected = true;
            }
            e.ContextMenuStrip = cmsMainMenu;
        }

        
    }
}
