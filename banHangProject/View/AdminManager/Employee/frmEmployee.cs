using banHangProject.WareManager.Producer;
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
    public partial class frmEmployee : Form {
        public frmEmployee() {
            InitializeComponent();
        }
        private BindingSource bsTemp = null;
        private DataTable dtTemp = null;
        private string[] strColumName = { "order", "id", "name", "add", "divId", "divName", "phone", "Pass", "status", "permission" };
        private string[] strHeader = { "STT", "Mã NV", "Tên NV", "Địa chỉ", "Mã CV", "Tên CV", "SDT", "Mật Khẩu", "Tình trạng", "Quyền" };
        private int[] size = { 5, 10, 25, 15, 0, 15, 15, 0, 15, 0 };
        private List<Model.Employee> myEmployeeList = null;
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

        private void frmEmployee_Load(object sender, EventArgs e)
        {
            if (dtTemp != null)
                dtTemp = null;
            if (bsTemp != null)
                bsTemp= null;
            if (myEmployeeList != null)
                myEmployeeList = null;

            dtTemp = new DataTable();
            bsTemp = new BindingSource();
            myEmployeeList = new List<Model.Employee>();


            string strCmd = "select * from Nhan_vien";
            Controller.Connector.readEmployeeData(strCmd, myEmployeeList);

            for (int i = 0; i < strColumName.Length; i++)
            {
                dtTemp.Columns.Add(strColumName[i]);
            }
         
            
            foreach (Model.Employee u in myEmployeeList)
            {
                string s = "Đang làm việc";
                if (!u.Status)
                    s = "Đã nghỉ làm";
                dtTemp.Rows.Add(u.Id, u.IdString, u.Name, u.Add, u.DivId, u.DivName, u.Phone, u.Password, s, u.Permission);
            }

            bsTemp.DataSource = dtTemp;
            dgvData.DataSource = bsTemp.DataSource;

            for (int i = 0; i < strHeader.Length; i++)
            {
                dgvData.Columns[i].Width = (dgvData.Width / 100) * size[i];
                dgvData.Columns[i].HeaderText = strHeader[i];
            }

            dgvData.Columns[4].Visible = false;
            dgvData.Columns[7].Visible = false;
            dgvData.Columns[9].Visible = false;
            // Set font, chế độ chọn theo hàng
            dgvData.DefaultCellStyle.Font = new Font("Segoe UI", 12);
            dgvData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string filter = string.Format("name like '%{0}%' or id like '%{1}%' or phone like '%{2}%' or add like '%{3}%'", txtSearch.Text, txtSearch.Text, txtSearch.Text, txtSearch.Text);
            bsTemp.Filter = filter;
            dgvData.DataSource = bsTemp;

        }

        private void cmsAddMenu_Click(object sender, EventArgs e)
        {
            int index = myEmployeeList.Count - 1;
            int curId = myEmployeeList.ElementAt<Model.Employee>(index).Id;
            curId++;
            string curIdString = Model.Employee.LABEL + string.Format("{0:000}", curId);
            frmAddEmployee frmAdd = new frmAddEmployee(curIdString);
            frmAdd.StartPosition = FormStartPosition.CenterParent;
            DialogResult dlg = frmAdd.ShowDialog(this);
            if (dlg == DialogResult.Cancel)
                frmEmployee_Load(null, null);
            dgvData.FirstDisplayedScrollingRowIndex = dgvData.RowCount - 2;
        }

        private void cmsEditMenu_Click(object sender, EventArgs e)
        {
            DataGridViewRow curRow = dgvData.Rows[dgvData.CurrentCell.RowIndex];
            string curIdString = curRow.Cells[1].Value.ToString();
            string curName = curRow.Cells[2].Value.ToString();
            string curAdd = curRow.Cells[3].Value.ToString();
            string curDivid = curRow.Cells[5].Value.ToString();
            string curPhone = curRow.Cells[6].Value.ToString();
            string curStatus = curRow.Cells[8].Value.ToString();
            bool status = false;
            if (curStatus.Trim().Equals("Đang làm việc"))
                status = true;
            int curpermission = Int32.Parse(curRow.Cells[9].Value.ToString());

            frmEditEmployee frmEdit = new frmEditEmployee(curIdString, curName, curAdd,curDivid, curPhone, status, curpermission);
            frmEdit.StartPosition = FormStartPosition.CenterParent;
            DialogResult dlg = frmEdit.ShowDialog(this);
            if (dlg == DialogResult.Cancel)
                frmEmployee_Load(null, null);
            dgvData.FirstDisplayedScrollingRowIndex = dgvData.RowCount - 2;
        }
        private void dgvData_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
        {
            dgvData.ClearSelection();
            int rowSelected = e.RowIndex;
            if (e.RowIndex != -1)
            {
                this.dgvData.Rows[rowSelected].Selected = true;
            }
            e.ContextMenuStrip = cmsMainMenu;
        }
    }
}
