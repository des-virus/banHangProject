using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using banHangProject.Controller;
using Excel = Microsoft.Office.Interop.Excel;
using banHangProject.View.SaleManager.Sale;

namespace banHangProject.SaleManager.Sale {
    public partial class frmPrint : Form {
        public frmPrint() {
            InitializeComponent();
        }



        public frmPrint(DataTable _dtData, Model.Guess _curGuess, Model.Employee _curEmploy, string _truePrice, string _discount, string _totalPrice) {
            InitializeComponent();
            dtData = _dtData;
            int order = 1;
            foreach (DataRow dr in _dtData.Rows) {
                dgvData.Rows.Add(order++, dr["name"], dr["outPrice"], dr["unitName"], dr["num"], dr["total"]);
            }

            myBillOutList = new List<Model.BillOut>();
            Connector.readBillOutList(myBillOutList);
            curEmploy = _curEmploy;
            curGuess = _curGuess;

            // set label total
            lbTruePrice.Text = _truePrice;
            lbDiscount.Text = _discount;
            lbTotalPrice.Text = _totalPrice;
            makeToStr = new MakeToString(Convert.ToDouble(_truePrice.Replace(".", "")));
            makeToStr.BlockProcessing();
            lbMoneyByWord.Text = makeToStr.ReadThis() + " đồng";
            setData();
        }

        private void setData() {
            string curID = Model.BillOut.LABEL + Model.BillOut.CUR_ID;
            txtBillID.Text = curID;
            txtGuessName.Text = curGuess.Name;
            txtGuessPhone.Text = curGuess.Phone;
            txtGuessAdd.Text = curGuess.Add;
            txtEmployeeID.Text = curEmploy.IdString;
            txtEmployName.Text = curEmploy.Name;


        }

        // Attribute
        private static int MOUSE_STATE = 0;
        private Point myLocation = new Point();
        private Model.Guess curGuess;
        private Model.Employee curEmploy;
        private List<Model.BillOut> myBillOutList;
        private MakeToString makeToStr;
        private DataTable dtData;
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

        private void btnPay_Click(object sender, EventArgs e) {
            // Cập nhật HDX vào CSDL
            // Lấy số lượng cũ của từng mặt hàng trừ đi sl mua
            foreach (DataRow dr in dtData.Rows) {
                string id = dr["id"].ToString();
                string strCmd = "select soluongton from KHO_LK where malk = '" + id + "'";
                int oldNumber = Connector.getNumber(strCmd);
                int subNumber = int.Parse(dr["num"].ToString());
                int newNumber = oldNumber - subNumber;
                strCmd = string.Format("update KHO_LK set SOLUONGTON = {0} WHERE MALK = '{1}'", newNumber, id);
                Connector.excuteQuery(strCmd);
            }
            // Xuất HDX ra Excel
            exportToExcel();
        }

        private void exportToExcel() {
            Excel.Application exApp = new Excel.Application();
            Excel.Workbook exBook = exApp.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);
            Excel.Worksheet exSheet = (Excel.Worksheet)exBook.Worksheets[1];
            try {
                // dinh dang chung
                Excel.Range tenCuaHang = (Excel.Range)exSheet.Cells[1, 1];
                tenCuaHang.Font.Size = 18;
                tenCuaHang.Font.Bold = true;
                tenCuaHang.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                tenCuaHang.Value = "CỬA HÀNG LINH KIỆN ĐIỆN TỬ PTH";
                exSheet.Range["A1", "F1"].Merge(true);


                Excel.Range dcCuahang = (Excel.Range)exSheet.Cells[3, 1];
                //dcCuahang.WrapText = true;
                dcCuahang.Font.Size = 12;
                dcCuahang.Value = "Địa chỉ: Trường ĐH GTVT";
                exSheet.Range["A3", "C3"].Merge(true);

                Excel.Range dcCuahang2 = (Excel.Range)exSheet.Cells[4, 1];
                //dcCuahang.WrapText = true;
                dcCuahang2.Font.Size = 12;
                dcCuahang2.Value = "             Khoa CNTT";
                exSheet.Range["A4", "C4"].Merge(true);

                Excel.Range dtCuahang = (Excel.Range)exSheet.Cells[5, 1];
                dtCuahang.Font.Size = 12;
                dtCuahang.Font.Color = Color.Black;
                dtCuahang.Value = "SĐT: 0123.456.789";
                exSheet.Range["A5", "C5"].Merge(true);


                Excel.Range header = (Excel.Range)exSheet.Cells[7, 1];
                exSheet.Range["A7", "F7"].Merge(true);
                header.Font.Size = 13;
                header.Font.Bold = true;
                header.Value = "HÓA ĐƠN THANH TOÁN";
                header.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

                // dinh dang tieu de bang
                exSheet.Range["A10", "G10"].Font.Bold = true;
                exSheet.Range["A10", "G10"].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                exSheet.Range["A10"].Value = "STT";
                exSheet.Range["B10"].Value = "Tên sản phẩm";
                exSheet.Range["C10"].Value = "Đơn vị tính";
                exSheet.Range["D10"].Value = "Số lượng";
                exSheet.Range["E10"].Value = "Đơn giá";
                exSheet.Range["F10"].Value = "Thành tiền";
                exSheet.Range["A10"].ColumnWidth = 4;
                exSheet.Range["B10"].ColumnWidth = 28;
                exSheet.Range["C10"].ColumnWidth = 10;
                exSheet.Range["D10"].ColumnWidth = 15;
                exSheet.Range["E10"].ColumnWidth = 10;
                exSheet.Range["F10"].ColumnWidth = 10;


                // Dinh dang ngay in
                Excel.Range ngay = (Excel.Range)exSheet.Cells[8, 4];
                ngay.Font.Size = 12;
                ngay.Font.Color = Color.Black;
                ngay.Font.Bold = true;
                ngay.Value = "Ngày xuất: " + dateTimePicker1.Text;
                exSheet.Range["D8", "F8"].Merge(true);


                // Dinh dang so hoa don
                Excel.Range sohd = (Excel.Range)exSheet.Cells[8, 1];
                ngay.Font.Size = 12;
                ngay.Font.Color = Color.Black;
                ngay.Font.Bold = true;
                ngay.Value = "Số HĐ: " + txtBillID.Text;
                exSheet.Range["A8", "B8"].Merge(true);

                // In du lieu

                for (int i = 0; i < dgvData.Rows.Count - 1; i++) {
                    exSheet.Range["A" + (i + 11).ToString(), "F" + (i + 11).ToString()].Font.Bold = false;
                    exSheet.Range["A" + (i + 11).ToString()].Value = dgvData.Rows[i].Cells["order"].Value.ToString();
                    exSheet.Range["B" + (i + 11).ToString()].Value = dgvData.Rows[i].Cells["name"].Value.ToString();
                    exSheet.Range["C" + (i + 11).ToString()].Value = dgvData.Rows[i].Cells["unit"].Value.ToString();
                    exSheet.Range["D" + (i + 11).ToString()].Value = dgvData.Rows[i].Cells["outPrice"].Value.ToString();
                    exSheet.Range["E" + (i + 11).ToString()].Value = dgvData.Rows[i].Cells["num"].Value.ToString();
                    exSheet.Range["F" + (i + 11).ToString()].Value = dgvData.Rows[i].Cells["total"].Value.ToString();

                }

                // In cot tong tien
                exSheet.Range["A" + (10 + dgvData.Rows.Count).ToString(), "F" + (10 + dgvData.Rows.Count).ToString()].Font.Bold = true;
                exSheet.Range["A" + (10 + dgvData.Rows.Count).ToString()].Value = "Tiền hàng";
                exSheet.Range["E" + (10 + dgvData.Rows.Count).ToString()].Value = lbTotalPrice.Text;

                // Tổng ck
                exSheet.Range["A" + (11 + dgvData.Rows.Count).ToString(), "F" + (10 + dgvData.Rows.Count).ToString()].Font.Bold = true;
                exSheet.Range["A" + (11 + dgvData.Rows.Count).ToString()].Value = "Chiết khấu";
                exSheet.Range["E" + (11 + dgvData.Rows.Count).ToString()].Value = lbDiscount.Text;

                // Tiền phải trả
                exSheet.Range["A" + (12 + dgvData.Rows.Count).ToString(), "F" + (10 + dgvData.Rows.Count).ToString()].Font.Bold = true;
                exSheet.Range["A" + (12 + dgvData.Rows.Count).ToString()].Value = "Thành tiền";
                exSheet.Range["E" + (12 + dgvData.Rows.Count).ToString()].Value = lbTruePrice.Text;

                // Bằng chữ
                exSheet.Range["A" + (13 + dgvData.Rows.Count).ToString(), "F" + (10 + dgvData.Rows.Count).ToString()].Font.Bold = true;
                exSheet.Range["A" + (13 + dgvData.Rows.Count).ToString()].Value = "Thành tiền";
                exSheet.Range["E" + (13 + dgvData.Rows.Count).ToString()].Value = lbMoneyByWord.Text;

                // Border
                // Excel.Border myBorder = new Excel.Border();


                exSheet.Name = "Hang";
                exBook.Activate();
                SaveFileDialog svFile = new SaveFileDialog();
                svFile.Filter = "Excel document(*.xlsx)|*.xlsx";
                svFile.FilterIndex = 1;
                svFile.AddExtension = true;
                svFile.DefaultExt = ".xlsx";
                if (svFile.ShowDialog() == DialogResult.OK)
                    exBook.SaveAs(svFile.FileName.ToString());
                MessageBox.Show("Đã xuất file excel!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                exApp.Quit();
            }
            catch (Exception ex) {
                exApp.Quit();
                MessageBox.Show("Lỗi xuất Excel ở frmPrint: " + ex.Message);
            }
        }
    }
}
