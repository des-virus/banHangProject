using banHangProject.WareManager.Producer;
using banHangProject.WareManager.Label;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using banHangProject.Controller;
using banHangProject.WareManager.Item;
using banHangProject.WareManager.Unit;
using banHangProject.Model;
using System.Collections;
using System.Globalization;
using banHangProject.WareManager.Good;
using banHangProject.WareManager.Type;

namespace banHangProject.View.WareManager.Good {
    public partial class frmGood : Form {
        public frmGood() {
            InitializeComponent();
        }

        // Attribute
        private static string path = System.IO.Directory.GetCurrentDirectory().ToString() + "\\IMG\\";
        private static int MOUSE_STATE = 0;
        private string[] strColName = {  "order", "id", "name", "unit", "exsistNumber", "solve" };
        private string[] strHeader = { "STT", "Mã LK", "Tên linh kiện", "Đơn vị", "SL tồn", "SL Ban" };
        private int[] size = { 10, 10, 20, 30, 20, 20 };
        private string IMPath = "Unknown.jpg";
        private int totalType = 0, totalExist = 0;
        private BindingSource bsTemp = null;
        private DataTable dtTemp = null;
        private Employee curEmployee;
        private List<Model.Item> myItemList = null;
        private Point myLocation = new Point();
        private bool isLoaded = false;

        public Employee CurEmployee {
            get {
                return curEmployee;
            }

            set {
                curEmployee = value;
            }
        }



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

        private void llbUnit_Click(object sender, EventArgs e) {
            frmUnit myFrmUnit = new frmUnit();
            myFrmUnit.StartPosition = FormStartPosition.CenterParent;
            myFrmUnit.ShowDialog();
        }

        private void llbLogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            this.Close();
        }

        private void llbProvider_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            frmProvider myFrmProvider = new frmProvider();
            myFrmProvider.StartPosition = FormStartPosition.CenterParent;
            myFrmProvider.ShowDialog();
        }

        private void llbProducer_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            frmProducer myFrmProducer = new frmProducer();
            myFrmProducer.StartPosition = FormStartPosition.CenterParent;
            myFrmProducer.ShowDialog();
        }

        private void llbType_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            frmType myFrmType = new frmType();
            myFrmType.StartPosition = FormStartPosition.CenterParent;
            myFrmType.ShowDialog();
        }

        private void llbLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            frmLabel myFrmLabel = new frmLabel();
            myFrmLabel.StartPosition = FormStartPosition.CenterParent;
            myFrmLabel.ShowDialog();
        }


        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            frmBillIn fBillIn = new frmBillIn();
            fBillIn.ShowDialog();
        }

        private void ptbItem_Click(object sender, EventArgs e) {

        }

        private void ptbItem_DoubleClick(object sender, EventArgs e) {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK) {
                IMPath = dlg.FileName;
                ptbItem.Image = Image.FromFile(IMPath);
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            frmOrder fOrder = new frmOrder();
            fOrder.CurEmployee = CurEmployee;
            fOrder.ShowDialog();
        }

        private void dgvData_SelectionChanged(object sender, EventArgs e) {
            if (isLoaded) {
                try {
                    // Chọn index dgv
                    int index = dgvData.SelectedRows[0].Index;

                    // Chọn phần tử tương ứng trong list
                    Model.Item u = myItemList[index];

                    CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");

                    // Đổ dữ liệu
                    lbLabel.Text = u.LabelName;
                    lbInPrice.Text = u.InPrice.ToString("#,###", cul.NumberFormat);
                    lbOutPrice.Text = u.OutPrice.ToString("#,###", cul.NumberFormat);
                    lbProc.Text = u.ProcName;
                    lbProv.Text = u.ProvName;
                    rtbDescription.Text = u.Description;
                    if (u.Img.Trim() == "")
                        ptbItem.Image = Image.FromFile(path + IMPath);
                    else
                        ptbItem.Image = Image.FromFile(path + u.Img.Trim());

                }
                catch (Exception ex) {

                    MessageBox.Show("Lỗi ở frmGood/dgvData_CellClick " + ex.Message);
                }
            }
        }

        private void frmGood_Load(object sender, EventArgs e) {
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
            if (myItemList != null)
                myItemList = null;
            myItemList = new List<Model.Item>();
            string strCmd = "select * from KHO_LK";
            Connector.readItemData(strCmd, myItemList);

            // Set data table column
            for (int i = 0; i < strColName.Length; i++) {
                dtTemp.Columns.Add(strColName[i]);
            }

            // Reset tổng số linh kiện về 0
            totalExist = 0;

            // Set data to data table
            for (int i = 0; i < myItemList.Count; i++) {
                Model.Item u = myItemList[i];
                totalExist += u.ExistNumber;
                dtTemp.Rows.Add( i + 1, u.IdString, u.Name, u.LabelName, u.ExistNumber, u.Solve);
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


            // Set dữ liệu tổng cho kho
            string strCmd1 = "select count(*) from loai_lk";
            totalType = Connector.getNumber(strCmd1);
            lbTotalExist.Text = totalExist.ToString();
            lbTotalType.Text = totalType.ToString();


            isLoaded = true;
        }
    }
}