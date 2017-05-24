using banHangProject.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace banHangProject.WareManager.Good {
    public partial class frmBillIn : Form {
        public frmBillIn() {
            InitializeComponent();

        }

        // Attribute
        // BindingSource và DataTable để lấy lọc dữ liệu
        private BindingSource bsTemp = null;
        private DataTable dtBill = null;
        private string[] strColName = { "order", "id", "date", "guessName", "employName", "totalPrice" };
        private string[] strColDetailName = { "order", "date", "price", "number" };
        private int[] sizeDetail = { 20, 30, 30, 20 };
        private string[] strHeader = { "*", "Mã hóa đơn", "Ngày xuất", "Khách hàng", "Nhân viên bán", "Tổng giá trị" };
        private int[] size = { 5, 13, 17, 30, 25, 20 };
        private List<Model.BillIn> myBillInList = null;
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

        private void frmBillIn_Load(object sender, EventArgs e) {
            // Init source
            // Trong các hàm cms gọi lại load -> gán lại về null
            // để bộ dọn rác tự dọn rồi khởi tạo lại
            if (dtBill != null)
                dtBill = null;
            if (bsTemp != null)
                bsTemp = null;
            dtBill = new DataTable();
            bsTemp = new BindingSource();

            // Ý tưởng cả đoạn dưới:
            //- Lấy dữ liệu vào data table
            //- Gán data table cho bindingsource
            //- Gán bindingsource cho datagridview.datasource
            //** làm quanh vậy để làm gì?
            //** vì không làm thế méo lọc được :v

            // Get data
            if (myBillInList != null)
                myBillInList = null;
            myBillInList = new List<Model.BillIn>();
            Connector.readBillInList(myBillInList);

            // Set data table column
            for (int i = 0; i < strHeader.Length; i++) {
                dtBill.Columns.Add(strColName[i]);
            }


            // Set data to data table
            CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");
            for (int i = 0; i < myBillInList.Count; i++) {
                dtBill.Rows.Add(i, myBillInList.ElementAt(i).Id, myBillInList.ElementAt(i).Date.ToString("dd/MM/yyy"), myBillInList.ElementAt(i).ProvName, myBillInList.ElementAt(i).EmployName, myBillInList.ElementAt(i).TotalPrice.ToString("#,###", cul.NumberFormat));
            }

            // Set source
            bsTemp.DataSource = dtBill;
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

        private void btnExit_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e) {
            // Lấy index hóa đơn đang được chọn
            int index = dgvData.SelectedRows[0].Index;

            // Clear dữ liệu cũ
            dgvDetail.Rows.Clear();

            // Đổ dữ liệu trực tiếp và dgvDetail
            for (int i = 0; i < myBillInList.ElementAt(index).MyBillInDetailList.Count; i++) {
                dgvDetail.Rows.Add(i + 1, myBillInList.ElementAt(index).MyBillInDetailList.ElementAt(i).NameItem, myBillInList.ElementAt(index).MyBillInDetailList.ElementAt(i).Cost, myBillInList.ElementAt(index).MyBillInDetailList.ElementAt(i).Count);

            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e) {
            string filter = string.Format("id like '%{0}%' or provName like '%{1}%' or employName like '%{2}%' or guessName like '%{3}%'or date like '%{4}%'", txtSearch.Text, txtSearch.Text, txtSearch.Text, txtSearch.Text, txtSearch.Text);
            bsTemp.Filter = filter;
            dgvData.DataSource = bsTemp;

        }
    }
}
