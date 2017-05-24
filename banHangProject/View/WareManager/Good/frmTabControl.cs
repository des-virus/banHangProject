using banHangProject.Controller;
using banHangProject.Model;
using banHangProject.SaleManager.Sale;
using banHangProject.View.SaleManager.Sale;
using banHangProject.View.WareManager.Good;
using banHangProject.WareManager.Provider;
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
using Excel = Microsoft.Office.Interop.Excel;

namespace banHangProject.View.WareManager {

    public partial class frmTabControl : Form {
        public frmTabControl() {
            InitializeComponent();
            fInput = new frmInput();
            dtCombo = new DataTable();
            dtDgv = new DataTable();
            dtProvider = new DataTable();
            myItemList = new List<Model.Item>();
            myProviderList = new List<Provider>();
            myBillInList = new List<BillIn>();
        }

        // Attribute
        // dtCombo để gán dữ liệu cho combobox, dtDgv để gán dữ liệu cho datagridview
        // dtProvider để chứa dữ liệu khách hàng
        private DataTable dtCombo = null, dtDgv = null, dtProvider;
        private frmInput fInput;
        private List<Model.Item> myItemList = null;
        private List<Model.Provider> myProviderList = null;
        private List<Model.BillIn> myBillInList;
        private Employee curEmployee;
        private Model.Provider curProvider;
        private bool startCheck = false, isPay = false;
        private string[] strColName = { "totalSell", "id", "name", "procName", "unitName", "outPrice", "existNumber", "description", "img", "num", "total",  "display" };
        private string[] strProviderColName = { "data" };
        private string[] strHeader = { "Đã bán", "Mã LK", "Tên linh kiện", "NSX", "Đơn vị", "Giá", "SL tồn", "mô tả", "ảnh", "Số lượng", "Thành tiền" };
        private string curBillID = "";
        private int[] size = {10,  10, 25, 15, 15, 15, 10, 10, 10,  10, 15 };
        private int totalGood = 0, totalPrice = 0, discountPrice = 0, truePrice = 0;

        public Employee CurEmployee {
            get {
                return curEmployee;
            }

            set {
                curEmployee = value;
            }
        }




        // Close this tab by get parent
        private void btnClose_Click(object sender, EventArgs e) {

            TabControl t = this.Parent.Parent as TabControl;
            t.TabPages.Remove(t.SelectedTab);
        }

        // Set dữ liệu khách hàng
        private void setProvData() {
            lbProvName.Text = curProvider.Name;
            lbProvPhone.Text = curProvider.Phone;
            txtFindProvider.SelectedIndex = txtFindProvider.FindString(curProvider.Name + " " + curProvider.Phone);
        }

        private void frmTabControl_Load(object sender, EventArgs e) {
            // Lấy dữ liệu từ SQL
            string strCmd = "select * from KHO_LK";
            Connector.readItemData(strCmd, myItemList);
            strCmd = "select * from NCC";
            Connector.readProviderData(strCmd, myProviderList);
            Connector.readBillInList(myBillInList);

            // Chọn mã HĐ hiện tại
            curBillID = Model.BillIn.LABEL + string.Format("{0:000}", Model.BillIn.CUR_ID);

            // Chọn khách hàng mặc định là khách lẻ
            curProvider = myProviderList.ElementAt(0);
            setProvData();

            // Chọn nhân viên là nhân viên đang đăng nhập
            lbEmployeeName.Text = curEmployee.Name;

            // Thêm các cột cho 2 bảng
            for (int i = 0; i < strColName.Length; i++) {
                dtCombo.Columns.Add(strColName[i]);
                dtDgv.Columns.Add(strColName[i]);
            }

            // Thêm cột cho bảng ncc
            for (int i = 0; i < strProviderColName.Length; i++) {
                dtProvider.Columns.Add(strProviderColName[i]);
            }


            // Thêm dữ liệu vào bảng khách hàng
            foreach (Model.Provider u in myProviderList) {
                dtProvider.Rows.Add(u.Name + " " + u.Phone);
            }


            // Gán datasource trước không lỗi
            dgvData.DataSource = dtDgv;
            txtFindProvider.DataSource = dtProvider;
            txtFindProvider.DisplayMember = "data";

            // Đặt độ rộng, header text
            for (int i = 0; i < strHeader.Length; i++) {
                dgvData.Columns[i].Width = (dgvData.Width / 100) * size[i];
                dgvData.Columns[i].HeaderText = strHeader[i];
            }
            // Đổ dữ liệu vào bảng combo
            foreach (Model.Item u in myItemList) {
                dtCombo.Rows.Add(u.Solve, u.IdString, u.Name, u.ProcName, u.UnitName, u.OutPrice, u.ExistNumber, u.Description, u.Img, 1, u.InPrice,  u.Name + "\nMã linh kiện: " + u.IdString + "\nGiá nhập: " + u.InPrice + "\nSL tồn: " + u.ExistNumber);
            }



            // Set font, chế độ chọn theo hàng
            dgvData.DefaultCellStyle.Font = new Font("Segoe UI", 12);
            dgvData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Vẽ combobox
            cbox1.DrawMode = DrawMode.OwnerDrawVariable;
            cbox1.DrawItem += new DrawItemEventHandler(comboBox2_DrawItem);
            cbox1.MeasureItem += new MeasureItemEventHandler(comboBox2_MeasureItem);
            cbox1.SelectedIndexChanged += new EventHandler(comboBox2_SelectedIndexChanged);
            //cbox1.DropDownWidth = 250;
            cbox1.DropDownHeight = 300;
            cbox1.MaxDropDownItems = 6;


            cbox1.ValueMember = "id";
            cbox1.DisplayMember = "display";
            cbox1.DataSource = new BindingSource(dtCombo, null);
            //cbox1.SelectedIndex = -1;

            // Auto complete & drop down ở combo box
            cbox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbox1.AutoCompleteSource = AutoCompleteSource.ListItems;

            // Auto complete & drop down ở textbox
            txtFindProvider.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtFindProvider.AutoCompleteSource = AutoCompleteSource.ListItems;

            // Start check
            startCheck = true;

            // Set column display
            //dgvData.Columns["display"].Visible = false;
            //dgvData.Columns["existNumber"].Visible = false;
            //dgvData.Columns["description"].Visible = false;
            //dgvData.Columns["img"].Visible = false;

            // Add column
            //string strCmd = "select
        }

        private void comboBox2_MeasureItem(object sender, MeasureItemEventArgs e) {
            ComboBoxEx cbox = (ComboBoxEx)sender;
            DataRowView item = (DataRowView)cbox.Items[e.Index];
            string txt = item["display"].ToString();
            int height = Convert.ToInt32(e.Graphics.MeasureString(txt, cbox.Font).Height);

            e.ItemHeight = height + 4;
            e.ItemWidth = cbox.DropDownWidth;

            cbox.ItemHeights.Add(e.ItemHeight);
        }

        private void comboBox2_DrawItem(object sender, DrawItemEventArgs e) {
            ComboBoxEx cbox = (ComboBoxEx)sender;
            DataRowView item = (DataRowView)cbox.Items[e.Index];
            string txt = item["display"].ToString();

            e.DrawBackground();
            e.Graphics.DrawString(txt, cbox.Font, System.Drawing.Brushes.Black, new RectangleF(e.Bounds.X + 2, e.Bounds.Y + 2, e.Bounds.Width, e.Bounds.Height));
            e.Graphics.DrawLine(new Pen(Color.LightGray), e.Bounds.X, e.Bounds.Top + e.Bounds.Height - 1, e.Bounds.Width, e.Bounds.Top + e.Bounds.Height - 1);
            e.DrawFocusRectangle();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e) {
            ComboBoxEx cbox = (ComboBoxEx)sender;
            if (cbox.SelectedItem == null) return;

            DataRowView item = (DataRowView)cbox.SelectedItem;
        }

        private void comboBox1_DrawItem(object sender, DrawItemEventArgs e) {
            if (e.Index == -1)
                return;
            ComboBox combo = ((ComboBox)sender);
            using (SolidBrush brush = new SolidBrush(e.ForeColor)) {
                Font font = e.Font;
                //if (/*Condition Specifying That Text Must Be Bold*/)
                font = new System.Drawing.Font(font, FontStyle.Bold);
                e.DrawBackground();
                e.Graphics.DrawString(combo.Items[e.Index].ToString(), font, brush, e.Bounds);
                e.DrawFocusRectangle();
            }
        }



        private void cbox1_SelectedIndexChanged(object sender, EventArgs e) {
            // Start check để ban đầu load form lên không chạy sự kiện này
            if (startCheck) {
                // Lấy vị trí đang được chọn ở combobox
                int index = cbox1.SelectedIndex;

                // Thêm phần tử vào dgv
                DataRow drow = dtCombo.Rows[index];
                foreach (DataRow dr in dtDgv.Rows) {
                    if (dr["id"] == drow["id"]) {
                        MessageBox.Show("Đã có mặt hàng này");
                        return;
                    }
                }
                dtDgv.ImportRow(drow);
                dgvData.DataSource = dtDgv;

                // Chọn luôn phần tử vừa thêm để tránh lỗi update số lượng của cột 1 - fixed
                dgvData.FirstDisplayedScrollingRowIndex = dgvData.RowCount - 1;
                //dgvData.Select(dgvData.Rows[dgvData.RowCount - 1].Cells[0]);

                // Update giá, số lượng
                displayMoney("1", drow["outPrice"].ToString(), true);
            }
        }

        private void cmsChangeNumber_Click(object sender, EventArgs e) {
            int index = dgvData.SelectedRows[0].Index;
            DataRow drow = dtDgv.Rows[index];
            fInput.MyStr = drow["num"].ToString();
            fInput.Price = drow["outPrice"].ToString();
            if (fInput.ShowDialog() == DialogResult.OK) {
                displayMoney(fInput.MyStr, fInput.Price + "", true);
            }
        }



        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e) {
            int index = dgvData.SelectedRows[0].Index;
            DataRow drow = dtDgv.Rows[index];
            rtbDescription.Text = drow["description"].ToString();
            string img = drow["img"].ToString();
            if (img.Trim() != "")
                ptbProduce.Image = Image.FromFile("E:\\test\\img\\" + img);
        }

        private void txtFindProvider_SelectedIndexChanged(object sender, EventArgs e) {
            if (startCheck) {
                // Lấy vị trí đang được chọn ở combobox
                int index = txtFindProvider.SelectedIndex;

                // Lấy vị trí tương ứng ở bên guess list gán vào current guess
                curProvider = myProviderList.ElementAt(index);

                // Cập nhật khách hàng
                setProvData();

            }
        }

        private void cmsDelete_Click(object sender, EventArgs e) {
            // Lấy vị trí ở dgv
            int index = dgvData.SelectedRows[0].Index;

            // Xóa vị trí tương ứng ở dataDgv
            if (MessageBox.Show("Bạn có muốn xóa khỏi giỏ hàng", "Xóa khỏi giỏ hàng", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK) {
                dtDgv.Rows.RemoveAt(index);
                dgvData.DataSource = dtDgv;

                // Cập nhật lại tiền, số lượng
                displayMoney("", "", false);
            }
        }


        private void btnPay_Click(object sender, EventArgs e) {
            if (isPay) {
                if (MessageBox.Show("Hóa đơn đã thanh toán, bạn có muốn xuất file Excel?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    exportToExcel();
                return;
            }
            // Nhấn nút sẽ cập nhật dữ liệu vào csdl
            List<Model.BillInDetail> myBillInDetailList = new List<BillInDetail>();
            foreach (DataRow dr in dtDgv.Rows) {
                Model.BillInDetail b = new BillInDetail(curBillID, dr["id"].ToString(), int.Parse(dr["outPrice"].ToString()), int.Parse(dr["num"].ToString()));
                myBillInDetailList.Add(b);
            }
            BillIn bill = new BillIn(System.DateTime.Today.Date, CurEmployee.IdString, curProvider.IdString, truePrice, myBillInDetailList);
            Connector.insertBillIn(bill);
            isPay = true;
            // Hiện hộp thoại hỏi có xuất file excel hay không?
            if (MessageBox.Show("Thanh toán thành công, bạn có muốn xuất file Excel?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                exportToExcel();

        }

        private void ptbAddProvider_Click(object sender, EventArgs e) {
            int index = myProviderList.Count - 1;
            int curId = myProviderList.ElementAt<Model.Provider>(index).Id;
            curId++;
            string curIdString = Model.Provider.LABEL + string.Format("{0:000}", curId);
            frmAddProvider frmAdd = new frmAddProvider(curIdString);
            frmAdd.StartPosition = FormStartPosition.CenterParent;
            DialogResult dlg = frmAdd.ShowDialog(this);
            Provider u = null;
            // Sau khi thêm khách thì khách được thêm vào sẽ được chọn luôn.
            if (dlg == DialogResult.OK) {

                // Refresh lại list
                string strCmd = "select * from KHACH_HANG";
                Connector.readProviderData(strCmd, myProviderList);
                dtProvider.Clear();
                foreach (Provider x in myProviderList) {
                    if (x.IdString == curIdString) {
                        u = new Provider(x);
                    }
                    dtProvider.Rows.Add(x.Name + " " + x.Phone);
                }
                if (u != null) {
                    curProvider = u;
                    setProvData();
                }
            }

        }

        // Đối string là số lượng cần update, sử dụng khi thay đổi số lượng
        // Đối bool để kiểm tra xem có phải vừa thay số lượng hay không?
        // Vì khi combo box thêm vào không kiểm tra sẽ set hết số lượng về 1
        private void displayMoney(string number, string price, bool isUpdate) {
            // Lấy vị trí đang được chọn ở dgv, tìm vị trí tương ứng trong dataTable
            // rồi set lại số lượng
            try {
                int index = dgvData.SelectedRows[0].Index;
                DataRow drow = dtDgv.Rows[index];
                if (isUpdate) {
                    drow["num"] = number;
                    drow["outPrice"] = price;
                // Đặt lại thành tiền.
                int outPrice = int.Parse(drow["outPrice"].ToString());
                int num = int.Parse(number);
                drow["total"] = (outPrice * num).ToString();
                dgvData.DataSource = dtDgv;
                }


                // Lấy số lượng ra để tính toán --> Sai vì hắn cộng dồng.
                // Duyệt vòng lặp để tính

                foreach (DataRow dr in dtDgv.Rows) {
                    string strOutPrice = dr["outPrice"].ToString();
                    string strNum = dr["num"].ToString();
                    int num1 = int.Parse(strNum);
                    int outPrice1 = int.Parse(strOutPrice);
                    totalPrice += num1 * outPrice1;
                }
                totalGood = dtDgv.Rows.Count;
                truePrice = totalPrice;

                // Hiển thị tổng hàng, tiền hàng, chiết khấu, tiền phải trả
                CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");
                lbTotalGood.Text = totalGood.ToString();
                lbTotalPrice.Text = totalPrice.ToString("#,###", cul.NumberFormat);

                // Hiển thị tiền bằng chữ
                MakeToString makeToStr = new MakeToString(Convert.ToDouble(truePrice));
                makeToStr.BlockProcessing();
                rtbMoneyByWord.Text = makeToStr.ReadThis() + " đồng";
            }


            catch (Exception) {

                MessageBox.Show("Phải có ít nhất một mặt hàng");
            }
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
                ngay.Value = "Ngày xuất: " + System.DateTime.Today;
                exSheet.Range["D8", "F8"].Merge(true);


                // Dinh dang so hoa don
                Excel.Range sohd = (Excel.Range)exSheet.Cells[8, 1];
                ngay.Font.Size = 12;
                ngay.Font.Color = Color.Black;
                ngay.Font.Bold = true;
                sohd.Value = "Số HĐ: " + curBillID;
                exSheet.Range["A8", "B8"].Merge(true);

                // In du lieu

                for (int i = 0; i < dgvData.Rows.Count; i++) {
                    exSheet.Range["A" + (i + 11).ToString(), "F" + (i + 11).ToString()].Font.Bold = false;
                    exSheet.Range["A" + (i + 11).ToString()].Value = (i + 1);
                    exSheet.Range["B" + (i + 11).ToString()].Value = dgvData.Rows[i].Cells["name"].Value.ToString();
                    exSheet.Range["C" + (i + 11).ToString()].Value = dgvData.Rows[i].Cells["unitName"].Value.ToString();
                    exSheet.Range["D" + (i + 11).ToString()].Value = dgvData.Rows[i].Cells["num"].Value.ToString();
                    exSheet.Range["E" + (i + 11).ToString()].Value = dgvData.Rows[i].Cells["outPrice"].Value.ToString();
                    exSheet.Range["F" + (i + 11).ToString()].Value = dgvData.Rows[i].Cells["total"].Value.ToString();

                }

                // In cot tong tien
                exSheet.Range["A" + (11 + dgvData.Rows.Count).ToString(), "F" + (11 + dgvData.Rows.Count).ToString()].Font.Bold = true;
                exSheet.Range["A" + (11 + dgvData.Rows.Count).ToString()].Value = "Tiền hàng";
                exSheet.Range["F" + (11 + dgvData.Rows.Count).ToString()].Value = totalPrice + " ";

                // Tổng ck
                exSheet.Range["A" + (12 + dgvData.Rows.Count).ToString(), "F" + (12 + dgvData.Rows.Count).ToString()].Font.Bold = true;
                exSheet.Range["A" + (12 + dgvData.Rows.Count).ToString()].Value = "Chiết khấu";
                exSheet.Range["F" + (12 + dgvData.Rows.Count).ToString()].Value = discountPrice + " ";

                // Tiền phải trả
                exSheet.Range["A" + (13 + dgvData.Rows.Count).ToString(), "F" + (13 + dgvData.Rows.Count).ToString()].Font.Bold = true;
                exSheet.Range["A" + (13 + dgvData.Rows.Count).ToString()].Value = "Thành tiền";
                exSheet.Range["F" + (13 + dgvData.Rows.Count).ToString()].Value = truePrice + " ";

                // Bằng chữ
                exSheet.Range["A" + (14 + dgvData.Rows.Count).ToString(), "F" + (14 + dgvData.Rows.Count).ToString()].Font.Bold = true;
                exSheet.Range["A" + (14 + dgvData.Rows.Count).ToString()].Value = "Bằng chữ: " + rtbMoneyByWord.Text;

                //Border
                BorderAround(exSheet.Range["A10", "F" + (10 + dgvData.Rows.Count).ToString()], System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Black));
                BorderAround2(exSheet.Range["A" + (11 + dgvData.Rows.Count).ToString(), "F" + (14 + dgvData.Rows.Count).ToString()], System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Black));


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
                MessageBox.Show("Lỗi xuất Excel : " + ex.Message);
            }
        }

        private void BorderAround(Excel.Range range, int colour) {
            Excel.Borders borders = range.Borders;
            borders[Excel.XlBordersIndex.xlEdgeLeft].LineStyle = Excel.XlLineStyle.xlContinuous;
            borders[Excel.XlBordersIndex.xlEdgeTop].LineStyle = Excel.XlLineStyle.xlContinuous;
            borders[Excel.XlBordersIndex.xlEdgeBottom].LineStyle = Excel.XlLineStyle.xlContinuous;
            borders[Excel.XlBordersIndex.xlEdgeRight].LineStyle = Excel.XlLineStyle.xlContinuous;
            borders.Color = colour;
            borders[Excel.XlBordersIndex.xlInsideVertical].LineStyle = Excel.XlLineStyle.xlDash;
            borders[Excel.XlBordersIndex.xlInsideHorizontal].LineStyle = Excel.XlLineStyle.xlDash;
            borders[Excel.XlBordersIndex.xlDiagonalUp].LineStyle = Excel.XlLineStyle.xlLineStyleNone;
            borders[Excel.XlBordersIndex.xlDiagonalDown].LineStyle = Excel.XlLineStyle.xlLineStyleNone;
            borders = null;
        }

        private void BorderAround2(Excel.Range range, int colour) {
            Excel.Borders borders = range.Borders;
            borders[Excel.XlBordersIndex.xlEdgeLeft].LineStyle = Excel.XlLineStyle.xlContinuous;
            borders[Excel.XlBordersIndex.xlEdgeTop].LineStyle = Excel.XlLineStyle.xlContinuous;
            borders[Excel.XlBordersIndex.xlEdgeBottom].LineStyle = Excel.XlLineStyle.xlContinuous;
            borders[Excel.XlBordersIndex.xlEdgeRight].LineStyle = Excel.XlLineStyle.xlContinuous;
            borders.Color = colour;
            borders[Excel.XlBordersIndex.xlInsideVertical].LineStyle = Excel.XlLineStyle.xlContinuous;
            borders[Excel.XlBordersIndex.xlInsideHorizontal].LineStyle = Excel.XlLineStyle.xlContinuous;
            borders[Excel.XlBordersIndex.xlDiagonalUp].LineStyle = Excel.XlLineStyle.xlLineStyleNone;
            borders[Excel.XlBordersIndex.xlDiagonalDown].LineStyle = Excel.XlLineStyle.xlLineStyleNone;
            borders = null;
        }
    }
}
