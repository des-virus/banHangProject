using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using banHangProject.Model;
using System.Globalization;

namespace banHangProject.Controller {
    static class Connector {
        // Attribute
        private static string strImg = System.IO.Directory.GetCurrentDirectory() + "";
        private static string strConnect = "Data Source=DESTRUCTION-VIR;Initial Catalog=csdl;Persist Security Info=True;User ID=saadmin;Password=daicaphong";
        private static SqlConnection conn;


        // Method

        public static void openConnection() {
            // Tao ket noi
            conn = new SqlConnection(strConnect);

            // Mo ket noi
            if (conn.State != System.Data.ConnectionState.Open) {
                conn.Open();
            }
        }

        public static void closeConnection() {
            conn.Close();
            conn.Dispose();
        }
        public static bool readUnitData(string strCmd, List<Unit> myUnitList) {
            try {

                openConnection();

                // Doc du lieu
                SqlCommand myCmd = new SqlCommand(strCmd, conn);
                SqlDataReader myReader = myCmd.ExecuteReader();
                while (myReader.Read()) {
                    string id = myReader[0].ToString();
                    string name = myReader[1].ToString();
                    Unit u = new Unit(id, name);
                    myUnitList.Add(u);
                }
                conn.Close();
                conn.Dispose();
                return true;
            }
            catch (Exception ex) {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return false;
            }

        }



        public static bool insertUnit(Model.Unit _u) {
            try {

                openConnection();


                // Them don vi
                string strCmd = string.Format("INSERT INTO DON_VI VALUES('{0}', N'{1}')", _u.IdString, _u.Name);
                SqlCommand myCmd = new SqlCommand(strCmd, conn);
                SqlDataReader myReader = myCmd.ExecuteReader();

                conn.Close();
                conn.Dispose();
                return true;
            }
            catch (Exception ex) {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                conn.Close();
                conn.Dispose();
                return false;
            }

        }

        public static bool updateUnit(Model.Unit _u) {
            try {

                openConnection();


                // Them don vi
                string strCmd = string.Format("UPDATE DON_VI set TENDV = N'{0}' where MADV = '{1}'", _u.Name, _u.IdString);
                SqlCommand myCmd = new SqlCommand(strCmd, conn);
                SqlDataReader myReader = myCmd.ExecuteReader();

                conn.Close();
                conn.Dispose();
                return true;
            }
            catch (Exception ex) {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                conn.Close();
                conn.Dispose();
                return false;
            }

        }



        public static bool readProviderData(string strCmd, List<Model.Provider> myProviderList) {
            try {

                openConnection();

                // Doc du lieu
                SqlCommand myCmd = new SqlCommand(strCmd, conn);
                SqlDataReader myReader = myCmd.ExecuteReader();
                while (myReader.Read()) {
                    string id = myReader[0].ToString();
                    string name = myReader[1].ToString();
                    string add = myReader[2].ToString();
                    string phone = myReader[3].ToString();
                    Model.Provider p = new Provider(id, name, add, phone);
                    myProviderList.Add(p);
                }
                conn.Close();
                conn.Dispose();
                return true;
            }
            catch (Exception ex) {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return false;
            }

        }

        public static bool insertProvider(Model.Provider _p) {
            try {

                openConnection();


                // Them don vi
                string strCmd = string.Format("INSERT INTO NCC VALUES('{0}', N'{1}', N'{2}', '{3}')", _p.IdString, _p.Name, _p.Add, _p.Phone);
                SqlCommand myCmd = new SqlCommand(strCmd, conn);
                SqlDataReader myReader = myCmd.ExecuteReader();

                conn.Close();
                conn.Dispose();
                return true;
            }
            catch (Exception ex) {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                conn.Close();
                conn.Dispose();
                return false;
            }

        }

        public static bool updateProvider(Model.Provider _p) {
            try {

                openConnection();


                // Them don vi
                string strCmd = string.Format("UPDATE NCC set TENNCC = N'{0}', DIACHI = N'{1}', SDT = '{2}' where MANCC = '{3}'", _p.Name, _p.Add, _p.Phone, _p.IdString);
                SqlCommand myCmd = new SqlCommand(strCmd, conn);
                SqlDataReader myReader = myCmd.ExecuteReader();

                conn.Close();
                conn.Dispose();
                return true;
            }
            catch (Exception ex) {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                conn.Close();
                conn.Dispose();
                return false;
            }

        }
        public static bool readProducerData(string strCmd, List<Model.Producer> myProducerList) {
            try {

                openConnection();

                // Doc du lieu
                SqlCommand myCmd = new SqlCommand(strCmd, conn);
                SqlDataReader myReader = myCmd.ExecuteReader();
                while (myReader.Read()) {
                    string id = myReader[0].ToString();
                    string name = myReader[1].ToString();
                    string add = myReader[2].ToString();
                    string phone = myReader[3].ToString();
                    Model.Producer p = new Producer(id, name, add, phone);
                    myProducerList.Add(p);
                }
                conn.Close();
                conn.Dispose();
                return true;
            }
            catch (Exception ex) {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return false;
            }

        }

        public static bool insertProducer(Model.Producer _p) {
            try {

                openConnection();


                // Them don vi
                string strCmd = string.Format("INSERT INTO NSX VALUES('{0}', N'{1}', N'{2}', '{3}')", _p.IdString, _p.Name, _p.Add, _p.Phone);
                SqlCommand myCmd = new SqlCommand(strCmd, conn);
                SqlDataReader myReader = myCmd.ExecuteReader();

                conn.Close();
                conn.Dispose();
                return true;
            }
            catch (Exception ex) {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                conn.Close();
                conn.Dispose();
                return false;
            }

        }

        public static bool updateProducer(Model.Producer _p) {
            try {

                openConnection();


                // Them don vi
                string strCmd = string.Format("UPDATE NSX set TENNSX = N'{0}', DIACHI = N'{1}', SDT = '{2}' where MANSX = '{3}'", _p.Name, _p.Add, _p.Phone, _p.IdString);
                SqlCommand myCmd = new SqlCommand(strCmd, conn);
                SqlDataReader myReader = myCmd.ExecuteReader();

                conn.Close();
                conn.Dispose();
                return true;
            }
            catch (Exception ex) {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                conn.Close();
                conn.Dispose();
                return false;
            }

        }

        public static bool readTypeData(string strCmd, List<Model.Type> myTypeList) {
            try {

                // Tao ket noi
                conn = new SqlConnection(strConnect);

                // Mo ket noi
                if (conn.State != System.Data.ConnectionState.Open) {
                    conn.Open();
                }

                // Doc du lieu
                SqlCommand myCmd = new SqlCommand(strCmd, conn);
                SqlDataReader myReader = myCmd.ExecuteReader();
                while (myReader.Read()) {
                    string id = myReader[0].ToString();
                    string name = myReader[1].ToString();
                    Model.Type u = new Model.Type(id, name);
                    myTypeList.Add(u);
                }
                conn.Close();
                conn.Dispose();
                return true;
            }
            catch (Exception ex) {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return false;
            }

        }

        public static bool updateType(Model.Type _u) {
            try {

                // Tao ket noi
                conn = new SqlConnection(strConnect);

                // Mo ket noi
                if (conn.State != System.Data.ConnectionState.Open) {
                    conn.Open();
                }


                // Them don vi
                string strCmd = string.Format("UPDATE LOAI_LK set TENLOAI = N'{0}' where MALOAI = '{1}'", _u.Name, _u.IdString);
                SqlCommand myCmd = new SqlCommand(strCmd, conn);
                SqlDataReader myReader = myCmd.ExecuteReader();

                conn.Close();
                conn.Dispose();
                return true;
            }
            catch (Exception ex) {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                conn.Close();
                conn.Dispose();
                return false;
            }

        }


        public static bool insertType(Model.Type _u) {
            try {

                // Tao ket noi
                conn = new SqlConnection(strConnect);

                // Mo ket noi
                if (conn.State != System.Data.ConnectionState.Open) {
                    conn.Open();
                }


                // Them don vi
                string strCmd = string.Format("INSERT INTO LOAI_LK VALUES('{0}', '{1}')", _u.IdString, _u.Name);
                SqlCommand myCmd = new SqlCommand(strCmd, conn);
                SqlDataReader myReader = myCmd.ExecuteReader();

                conn.Close();
                conn.Dispose();
                return true;
            }
            catch (Exception ex) {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                conn.Close();
                conn.Dispose();
                return false;
            }

        }



        public static bool readLabelData(string strCmd, List<Label> myLabelList) {
            try {

                // Tao ket noi
                conn = new SqlConnection(strConnect);

                // Mo ket noi
                if (conn.State != System.Data.ConnectionState.Open) {
                    conn.Open();
                }

                // Doc du lieu
                SqlCommand myCmd = new SqlCommand(strCmd, conn);
                SqlDataReader myReader = myCmd.ExecuteReader();
                while (myReader.Read()) {
                    string id = myReader[0].ToString();
                    string name = myReader[1].ToString();
                    string idType = myReader[2].ToString();
                    Label u = new Label(id, name, idType);
                    myLabelList.Add(u);
                }
                conn.Close();
                conn.Dispose();
                return true;
            }
            catch (Exception ex) {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return false;
            }

        }

        public static bool insertLabel(Model.Label _u) {
            try {

                // Tao ket noi
                conn = new SqlConnection(strConnect);

                // Mo ket noi
                if (conn.State != System.Data.ConnectionState.Open) {
                    conn.Open();
                }


                // Them don vi
                string strCmd = string.Format("INSERT INTO NHAN_HIEU VALUES('{0}', '{1}', '{2}')", _u.IdString, _u.Name, _u.IdType);
                SqlCommand myCmd = new SqlCommand(strCmd, conn);
                SqlDataReader myReader = myCmd.ExecuteReader();

                conn.Close();
                conn.Dispose();
                return true;
            }
            catch (Exception ex) {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                conn.Close();
                conn.Dispose();
                return false;
            }

        }

        public static bool updateLabel(Model.Label _u) {
            try {

                // Tao ket noi
                conn = new SqlConnection(strConnect);

                // Mo ket noi
                if (conn.State != System.Data.ConnectionState.Open) {
                    conn.Open();
                }


                // Them nhan hieu
                string strCmd = string.Format("UPDATE NHAN_HIEU set TENNH = N'{0}', MALOAI = '{1}' where MANH = '{2}'", _u.Name, _u.IdType, _u.IdString);
                SqlCommand myCmd = new SqlCommand(strCmd, conn);
                SqlDataReader myReader = myCmd.ExecuteReader();

                conn.Close();
                conn.Dispose();
                return true;
            }
            catch (Exception ex) {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                conn.Close();
                conn.Dispose();
                return false;
            }

        }


        public static bool readGuessData(string strCmd, List<Model.Guess> myGuessList) {
            try {

                // Tao ket noi
                conn = new SqlConnection(strConnect);

                // Mo ket noi
                if (conn.State != System.Data.ConnectionState.Open) {
                    conn.Open();
                }

                // Doc du lieu
                SqlCommand myCmd = new SqlCommand(strCmd, conn);
                SqlDataReader myReader = myCmd.ExecuteReader();
                while (myReader.Read()) {
                    string id = myReader[0].ToString();
                    string name = myReader[1].ToString();
                    string add = myReader[2].ToString();
                    string memId = myReader[3].ToString();
                    string phone = myReader[4].ToString();
                    Guess u = new Guess(id, name, add, memId, phone);
                    myGuessList.Add(u);
                }
                conn.Close();
                conn.Dispose();
                return true;
            }
            catch (Exception ex) {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return false;
            }

        }

        public static bool insertGuess(Model.Guess _u) {
            try {

                // Tao ket noi
                conn = new SqlConnection(strConnect);

                // Mo ket noi
                if (conn.State != System.Data.ConnectionState.Open) {
                    conn.Open();
                }


                // Them don vi
                string strCmd = string.Format("INSERT INTO KHACH_HANG VALUES('{0}', N'{1}', N'{2}', '{3}', '{4}')", _u.IdString, _u.Name, _u.Add, _u.MemId, _u.Phone);
                SqlCommand myCmd = new SqlCommand(strCmd, conn);
                SqlDataReader myReader = myCmd.ExecuteReader();

                conn.Close();
                conn.Dispose();
                return true;
            }
            catch (Exception ex) {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                conn.Close();
                conn.Dispose();
                return false;
            }

        }

        public static bool updateGuess(Model.Guess _u) {
            try {

                // Tao ket noi
                conn = new SqlConnection(strConnect);

                // Mo ket noi
                if (conn.State != System.Data.ConnectionState.Open) {
                    conn.Open();
                }


                // Them nhan hieu
                string strCmd = string.Format("UPDATE KHACH_HANG set TENKH = N'{0}', DIACHI = N'{1}', SDT = '{2}' where MAKH = '{3}'", _u.Name, _u.Add, _u.Phone, _u.IdString);
                SqlCommand myCmd = new SqlCommand(strCmd, conn);
                SqlDataReader myReader = myCmd.ExecuteReader();

                conn.Close();
                conn.Dispose();
                return true;
            }
            catch (Exception ex) {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                conn.Close();
                conn.Dispose();
                return false;
            }


        }


        public static bool readDivisionData(string strCmd, List<Division> myDivisionList) {
            try {

                // Tao ket noi
                conn = new SqlConnection(strConnect);

                // Mo ket noi
                if (conn.State != System.Data.ConnectionState.Open) {
                    conn.Open();
                }

                // Doc du lieu
                SqlCommand myCmd = new SqlCommand(strCmd, conn);
                SqlDataReader myReader = myCmd.ExecuteReader();
                while (myReader.Read()) {
                    string id = myReader[0].ToString();
                    string name = myReader[1].ToString();
                    float amount = float.Parse(myReader[2].ToString(),
                    NumberStyles.AllowCurrencySymbol |
                    NumberStyles.AllowThousands |
                    NumberStyles.AllowDecimalPoint);
                    decimal salary = decimal.Parse(myReader[2].ToString(), NumberStyles.AllowCurrencySymbol
                                                                          | NumberStyles.AllowThousands
                                                                          | NumberStyles.AllowDecimalPoint);
                    Division u = new Division(id, name, salary);
                    myDivisionList.Add(u);
                }
                conn.Close();
                conn.Dispose();
                return true;
            }
            catch (Exception ex) {
                System.Windows.Forms.MessageBox.Show("lOI: " + ex.Message);
                return false;
            }

        }

        public static bool insertDivision(Model.Division _u) {
            try {

                // Tao ket noi
                conn = new SqlConnection(strConnect);

                // Mo ket noi
                if (conn.State != System.Data.ConnectionState.Open) {
                    conn.Open();
                }


                // Them don vi
                string strCmd = string.Format("INSERT INTO BO_PHAN VALUES('{0}', N'{1}', '{2}')", _u.IdString, _u.Name, _u.Salary);
                SqlCommand myCmd = new SqlCommand(strCmd, conn);
                SqlDataReader myReader = myCmd.ExecuteReader();

                conn.Close();
                conn.Dispose();
                return true;
            }
            catch (Exception ex) {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                conn.Close();
                conn.Dispose();
                return false;
            }

        }

        public static bool updateDivision(Model.Division _u) {
            try {

                // Tao ket noi
                conn = new SqlConnection(strConnect);

                // Mo ket noi
                if (conn.State != System.Data.ConnectionState.Open) {
                    conn.Open();
                }


                // Them don vi
                string strCmd = string.Format("UPDATE BO_PHAN set TENBP = N'{0}', LUONG = '{1}' where MABP = '{2}'", _u.Name, _u.Salary, _u.IdString);
                SqlCommand myCmd = new SqlCommand(strCmd, conn);
                SqlDataReader myReader = myCmd.ExecuteReader();

                conn.Close();
                conn.Dispose();
                return true;
            }
            catch (Exception ex) {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                conn.Close();
                conn.Dispose();
                return false;
            }

        }


        public static bool readItemData(string strCmd, List<Item> myItemList) {
            try {

                // Tao ket noi
                conn = new SqlConnection(strConnect);

                // Mo ket noi
                if (conn.State != System.Data.ConnectionState.Open) {
                    conn.Open();
                }

                // Doc du lieu
                SqlCommand myCmd = new SqlCommand(strCmd, conn);
                SqlDataReader myReader = myCmd.ExecuteReader();
                while (myReader.Read()) {
                    string idString = myReader[0].ToString();
                    string name = myReader[1].ToString();
                    string labelId = myReader[2].ToString();
                    string procId = myReader[3].ToString();
                    string provId = myReader[4].ToString();
                    string unitId = myReader[5].ToString();
                    int inPrice = int.Parse(myReader[6].ToString());
                    int outPrice = int.Parse(myReader[7].ToString());
                    int existNumber = int.Parse(myReader["SOLUONGTON"].ToString());
                    string description = myReader[9].ToString();
                    string img = myReader[10].ToString();
                    Item u = new Item(idString, name, labelId, procId, provId, unitId, inPrice, outPrice, existNumber, description, img);
                    myItemList.Add(u);
                }
                conn.Close();
                conn.Dispose();
                return true;
            }
            catch (Exception ex) {
                System.Windows.Forms.MessageBox.Show("Lỗi ở readItemData:  " + ex.Message);
                return false;
            }

        }

        public static bool insertItem(Model.Item _u) {
            try {

                // Tao ket noi
                conn = new SqlConnection(strConnect);

                // Mo ket noi
                if (conn.State != System.Data.ConnectionState.Open) {
                    conn.Open();
                }


                // Them don vi
                string strCmd = string.Format("INSERT INTO KHO_LK VALUES('{0}', N'{1}', '{2}', '{3}', '{4}', {5}, {6}, {7}, N'{8}', '{9}', '{10}')", _u.IdString, _u.Name, _u.LabelId, _u.ProcId, _u.ProvId, _u.UnitId, _u.InPrice, _u.OutPrice, _u.ExistNumber, _u.Description, _u.Img);
                SqlCommand myCmd = new SqlCommand(strCmd, conn);
                SqlDataReader myReader = myCmd.ExecuteReader();

                conn.Close();
                conn.Dispose();
                return true;
            }
            catch (Exception ex) {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                conn.Close();
                conn.Dispose();
                return false;
            }

        }

        public static bool updateItem(Model.Item _u) {
            try {

                // Tao ket noi
                conn = new SqlConnection(strConnect);

                // Mo ket noi
                if (conn.State != System.Data.ConnectionState.Open) {
                    conn.Open();
                }


                // Them don vi
                string strCmd = string.Format("UPDATE KHOLK set TENLK = N'{0}', manh = '{1}', mansx = '{2}', mancc = '{3}', madv = '{4}', gianhap = {5}, giaxuat = {6}, slton = {7}, mota = N'{8}', img = '{9}' where malk = '{10}'", _u.Name, _u.LabelId, _u.ProcId, _u.ProcId, _u.UnitId, _u.InPrice, _u.OutPrice, _u.ExistNumber, _u.Description, _u.Img, _u.IdString);
                SqlCommand myCmd = new SqlCommand(strCmd, conn);
                SqlDataReader myReader = myCmd.ExecuteReader();

                conn.Close();
                conn.Dispose();
                return true;
            }
            catch (Exception ex) {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                conn.Close();
                conn.Dispose();
                return false;
            }

        }


        public static bool readEmployeeData(string strCmd, List<Employee> myEmployeeList) {
            try {

                openConnection();

                // Doc du lieu
                SqlCommand myCmd = new SqlCommand(strCmd, conn);
                SqlDataReader myReader = myCmd.ExecuteReader();
                while (myReader.Read()) {
                    string idString = myReader.GetString(0);
                    string name = myReader.GetString(1);
                    string add = myReader.GetString(2);
                    string divId = myReader.GetString(3);
                    string phone = myReader.GetString(4);
                    string pass = myReader.GetString(5);
                    bool status = myReader.GetBoolean(6);
                    int permission = myReader.GetInt32(7);
                    Employee u = new Employee(idString, name, add, divId, phone, pass, status, permission);
                    myEmployeeList.Add(u);
                }
                conn.Close();
                conn.Dispose();
                return true;
            }
            catch (Exception ex) {
                System.Windows.Forms.MessageBox.Show("Lỗi ở readEmployeeData:  " + ex.Message);
                return false;
            }

        }

        public static bool insertEmployee(Model.Employee _u) {
            try {

                openConnection();


                // Them don vi
                string strCmd = string.Format("INSERT INTO NHAN_VIEN VALUES('{0}', N'{1}', N'{2}', '{3}', '{4}', '{5}', {6}, {7})", _u.IdString, _u.Name, _u.Add, _u.DivId, _u.Phone, _u.Password, _u.Status, _u.Permission);
                SqlCommand myCmd = new SqlCommand(strCmd, conn);
                SqlDataReader myReader = myCmd.ExecuteReader();

                closeConnection();
                return true;
            }
            catch (Exception ex) {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                closeConnection();
                return false;
            }

        }

        public static bool updateEmployee(Model.Employee _u) {
            try {

                openConnection();

                // Them don vi
                string strCmd = string.Format("UPDATE NHAN_VIEN set TENNV = N'{0}', DIACHI = N'{1}', MABP = '{2}', SDT = '{3}', TINHTRANG = '{4}', QUYEN = {5} where MANV = '{6}'", _u.Name, _u.Add, _u.DivId, _u.Phone, _u.Status, _u.Permission, _u.IdString);
                SqlCommand myCmd = new SqlCommand(strCmd, conn);
                SqlDataReader myReader = myCmd.ExecuteReader();

                closeConnection();
                return true;
            }
            catch (Exception ex) {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                closeConnection();
                return false;
            }

        }


        public static bool readBillOutDetailList(string _id, List<Model.BillOutDetail> _myList) {
            try {
                openConnection();
                string strCmd = string.Format("select * from CTHDB where MAHDB = '{0}'", _id);
                SqlCommand myCmd = new SqlCommand(strCmd, conn);
                SqlDataReader myReader = myCmd.ExecuteReader();
                while (myReader.Read()) {
                    string idItem = myReader.GetString(1);
                    int cost = myReader.GetInt32(2);
                    int count = myReader.GetInt32(3);
                    Model.BillOutDetail b = new BillOutDetail(_id, idItem, cost, count);
                    _myList.Add(b);
                }
                closeConnection();
                return true;
            }
            catch (Exception ex) {
                System.Windows.Forms.MessageBox.Show("Lỗi ở đọc cthd bán " + ex.Message);
                return false;
            }

        }


        public static bool readBillOutList(List<Model.BillOut> _myList) {
            try {
                openConnection();
                string strCmd = string.Format("select * from HD_BAN");
                SqlCommand myCmd = new SqlCommand(strCmd, conn);
                SqlDataReader myReader = myCmd.ExecuteReader();
                while (myReader.Read()) {
                    string id = myReader.GetString(0);
                    DateTime date = myReader.GetDateTime(1);
                    string employId = myReader.GetString(2);
                    string guessId = myReader.GetString(3);
                    int totalPrice = myReader.GetInt32(4);
                    
                    Model.BillOut b = new BillOut(id, date, employId, guessId, totalPrice);
                    _myList.Add(b);
                }
                closeConnection();
                return true;
            }
            catch (Exception) {
                return false;
            }

        }

        public static bool readBillInList(List<Model.BillIn> _myList) {
            try {
                openConnection();
                string strCmd = string.Format("select * from HD_NHAP");
                SqlCommand myCmd = new SqlCommand(strCmd, conn);
                SqlDataReader myReader = myCmd.ExecuteReader();
                while (myReader.Read()) {
                    string id = myReader.GetString(0);
                    DateTime date = myReader.GetDateTime(1);
                    string employId = myReader.GetString(2);
                    string provId = myReader.GetString(3);
                    int totalPrice = myReader.GetInt32(4);

                    Model.BillIn b = new BillIn(id, date, employId, provId, totalPrice);
                    _myList.Add(b);
                }
                closeConnection();
                return true;
            }
            catch (Exception) {
                return false;
            }

        }


        public static bool readBillInDetailList(string _id, List<Model.BillInDetail> _myList) {
            try {
                openConnection();
                string strCmd = string.Format("select * from CTHDN where MAHDN = '{0}'", _id);
                SqlCommand myCmd = new SqlCommand(strCmd, conn);
                SqlDataReader myReader = myCmd.ExecuteReader();
                while (myReader.Read()) {
                    string idItem = myReader.GetString(1);
                    int cost = myReader.GetInt32(2);
                    int count = myReader.GetInt32(3);
                    Model.BillInDetail b = new BillInDetail(_id, idItem, cost, count);
                    _myList.Add(b);
                }
                closeConnection();
                return true;
            }
            catch (Exception ex) {
                System.Windows.Forms.MessageBox.Show("Lỗi ở đọc cthd bán " + ex.Message);
                return false;
            }

        }


        public static bool insertBillOutDetail(Model.BillOutDetail _u) {
            try {

                // Tao ket noi
                conn = new SqlConnection(strConnect);

                // Mo ket noi
                if (conn.State != System.Data.ConnectionState.Open) {
                    conn.Open();
                }


                // Them don vi
                string strCmd = string.Format("INSERT INTO CTHDB VALUES('{0}', '{1}', '{2}', '{3}')", _u.IdBillOut, _u.IdItem, _u.Cost, _u.Count);
                SqlCommand myCmd = new SqlCommand(strCmd, conn);
                SqlDataReader myReader = myCmd.ExecuteReader();

                conn.Close();
                conn.Dispose();
                return true;
            }
            catch (Exception ex) {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                conn.Close();
                conn.Dispose();
                return false;
            }

        }

        public static bool insertBillOut(Model.BillOut _u) {
            try {

                openConnection();


                // Them hoa don
                string strCmd = string.Format("INSERT INTO HD_BAN VALUES('{0}', '{1}', '{2}', '{3}', {4})", _u.Id, _u.Date, _u.EmployId, _u.GuessId, _u.TotalPrice);
                SqlCommand myCmd = new SqlCommand(strCmd, conn);
                SqlDataReader myReader = myCmd.ExecuteReader();

                // Them CTHD
                foreach (BillOutDetail b in _u.MyList) {
                    Connector.insertBillOutDetail(b);
                }

                closeConnection();
                return true;
            }
            catch (Exception ex) {
                System.Windows.Forms.MessageBox.Show("Lỗi ở thêm Connector/Thêm HĐB: " + ex.Message);
                closeConnection();
                return false;
            }

        }

        public static bool insertBillInDetail(Model.BillInDetail _u) {
            try {

                // Tao ket noi
                conn = new SqlConnection(strConnect);

                // Mo ket noi
                if (conn.State != System.Data.ConnectionState.Open) {
                    conn.Open();
                }


                // Them don vi
                string strCmd = string.Format("INSERT INTO CTHDN VALUES('{0}', '{1}', '{2}', '{3}')", _u.IdBillIn, _u.IdItem, _u.Cost, _u.Count);
                SqlCommand myCmd = new SqlCommand(strCmd, conn);
                SqlDataReader myReader = myCmd.ExecuteReader();

                conn.Close();
                conn.Dispose();
                return true;
            }
            catch (Exception ex) {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                conn.Close();
                conn.Dispose();
                return false;
            }

        }

        public static bool insertBillIn(Model.BillIn _u) {
            try {

                openConnection();


                // Them hoa don
                string strCmd = string.Format("INSERT INTO HD_NHAP VALUES('{0}', '{1}', '{2}', '{3}', {4})", _u.Id, _u.Date, _u.EmployId, _u.ProvId, _u.TotalPrice);
                SqlCommand myCmd = new SqlCommand(strCmd, conn);
                SqlDataReader myReader = myCmd.ExecuteReader();

                // Them CTHD
                foreach (BillInDetail b in _u.MyBillInDetailList) {
                    Connector.insertBillInDetail(b);
                }

                closeConnection();
                return true;
            }
            catch (Exception ex) {
                System.Windows.Forms.MessageBox.Show("Lỗi ở thêm Connector/Thêm HĐB: " + ex.Message);
                closeConnection();
                return false;
            }

        }
        // Other
        public static string getNameType(string idType) {
            try {
                openConnection();
                string strCmd = string.Format("select tenloai from LOAI_LK where maloai = '{0}'", idType);
                string name = "";

                // Doc du lieu
                SqlCommand myCmd = new SqlCommand(strCmd, conn);
                SqlDataReader myReader = myCmd.ExecuteReader();
                while (myReader.Read()) {
                    name = myReader[0].ToString();
                }
                closeConnection();
                return name;
            }
            catch (Exception ex) {
                System.Windows.Forms.MessageBox.Show("Loi o getNameType: " + ex.Message);
                closeConnection();
                return "";
            }
        }

        public static string getDiscountPercent(string _memId) {
            try {

                // Tao ket noi
                conn = new SqlConnection(strConnect);
                string strCmd = string.Format("select CHIET_KHAU from LOAI_TV where MATV = '{0}'", _memId);
                string name = "";

                // Mo ket noi
                if (conn.State != System.Data.ConnectionState.Open) {
                    conn.Open();
                }

                // Doc du lieu
                SqlCommand myCmd = new SqlCommand(strCmd, conn);
                SqlDataReader myReader = myCmd.ExecuteReader();
                while (myReader.Read()) {
                    name = myReader[0].ToString();
                }
                conn.Close();
                conn.Dispose();
                return name;
            }
            catch (Exception ex) {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return "";
            }
        }

        public static string getNameProc(string idProc) {
            try {

                // Tao ket noi
                conn = new SqlConnection(strConnect);
                string strCmd = string.Format("select tennsx from NSX where mansx = '{0}'", idProc);
                string name = "";

                // Mo ket noi
                if (conn.State != System.Data.ConnectionState.Open) {
                    conn.Open();
                }

                // Doc du lieu
                SqlCommand myCmd = new SqlCommand(strCmd, conn);
                SqlDataReader myReader = myCmd.ExecuteReader();
                while (myReader.Read()) {
                    name = myReader[0].ToString();
                }
                conn.Close();
                conn.Dispose();
                return name;
            }
            catch (Exception ex) {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return "";
            }
        }

        public static string getNameProv(string idProv) {
            try {

                // Tao ket noi
                conn = new SqlConnection(strConnect);
                string strCmd = string.Format("select tenncc from ncc where mancc = '{0}'", idProv);
                string name = "";

                // Mo ket noi
                if (conn.State != System.Data.ConnectionState.Open) {
                    conn.Open();
                }

                // Doc du lieu
                SqlCommand myCmd = new SqlCommand(strCmd, conn);
                SqlDataReader myReader = myCmd.ExecuteReader();
                while (myReader.Read()) {
                    name = myReader[0].ToString();
                }
                conn.Close();
                conn.Dispose();
                return name;
            }
            catch (Exception ex) {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return "";
            }
        }


        public static string getNameUnit(string idUnit) {
            try {

                // Tao ket noi
                conn = new SqlConnection(strConnect);
                string strCmd = string.Format("select tendv from don_vi where madv = '{0}'", idUnit);
                string name = "";

                // Mo ket noi
                if (conn.State != System.Data.ConnectionState.Open) {
                    conn.Open();
                }

                // Doc du lieu
                SqlCommand myCmd = new SqlCommand(strCmd, conn);
                SqlDataReader myReader = myCmd.ExecuteReader();
                while (myReader.Read()) {
                    name = myReader[0].ToString();
                }
                conn.Close();
                conn.Dispose();
                return name;
            }
            catch (Exception ex) {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return "";
            }
        }


        public static string getNameLabel(string idLabel) {
            try {

                // Tao ket noi
                conn = new SqlConnection(strConnect);
                string strCmd = string.Format("select tennh from nhan_hieu where manh = '{0}'", idLabel);
                string name = "";

                // Mo ket noi
                if (conn.State != System.Data.ConnectionState.Open) {
                    conn.Open();
                }

                // Doc du lieu
                SqlCommand myCmd = new SqlCommand(strCmd, conn);
                SqlDataReader myReader = myCmd.ExecuteReader();
                while (myReader.Read()) {
                    name = myReader[0].ToString();
                }
                conn.Close();
                conn.Dispose();
                return name;
            }
            catch (Exception ex) {
                System.Windows.Forms.MessageBox.Show("Lỗi ở getLabelName (Other): " + ex.Message);
                return "";
            }
        }

        public static string getDivName(string divId) {
            try {
                string strCmd = string.Format("select tenbp from bo_phan where mabp = '{0}'", divId);
                string name = "";
                openConnection();

                // Doc du lieu
                SqlCommand myCmd = new SqlCommand(strCmd, conn);
                SqlDataReader myReader = myCmd.ExecuteReader();
                while (myReader.Read()) {
                    name = myReader[0].ToString();
                }
                closeConnection();
                return name;
            }
            catch (Exception ex) {
                System.Windows.Forms.MessageBox.Show("Lỗi ở getLabelName (Other): " + ex.Message);
                return "";
            }
        }

        public static string getMemName(string memId) {
            try {
                string strCmd = string.Format("select tentv from LOAI_TV where matv = '{0}'", memId);
                string name = "";
                openConnection();

                // Doc du lieu
                SqlCommand myCmd = new SqlCommand(strCmd, conn);
                SqlDataReader myReader = myCmd.ExecuteReader();
                while (myReader.Read()) {
                    name = myReader[0].ToString();
                }
                closeConnection();
                return name;
            }
            catch (Exception ex) {
                System.Windows.Forms.MessageBox.Show("Lỗi ở getMemName (Other): " + ex.Message);
                return "";
            }
        }

        public static string getItemName(string memId) {
            try {
                string strCmd = string.Format("select tenlk from KHO_LK where malk = '{0}'", memId);
                string name = "";
                openConnection();

                // Doc du lieu
                SqlCommand myCmd = new SqlCommand(strCmd, conn);
                SqlDataReader myReader = myCmd.ExecuteReader();
                while (myReader.Read()) {
                    name = myReader[0].ToString();
                }
                closeConnection();
                return name;
            }
            catch (Exception ex) {
                System.Windows.Forms.MessageBox.Show("Lỗi ở getItemName (Other): " + ex.Message);
                return "";
            }
        }

        public static string getGuessName(string memId) {
            try {
                string strCmd = string.Format("select tenkh from KHACH_HANG where MAKH = '{0}'", memId);
                string name = "";
                openConnection();

                // Doc du lieu
                SqlCommand myCmd = new SqlCommand(strCmd, conn);
                SqlDataReader myReader = myCmd.ExecuteReader();
                while (myReader.Read()) {
                    name = myReader[0].ToString();
                }
                closeConnection();
                return name;
            }
            catch (Exception ex) {
                System.Windows.Forms.MessageBox.Show("Lỗi ở getGuessName (Other): " + ex.Message);
                return "";
            }
        }


        public static string getEmployName(string memId) {
            try {
                string strCmd = string.Format("select TENNV from nhan_vien where manv = '{0}'", memId);
                string name = "";
                openConnection();

                // Doc du lieu
                SqlCommand myCmd = new SqlCommand(strCmd, conn);
                SqlDataReader myReader = myCmd.ExecuteReader();
                while (myReader.Read()) {
                    name = myReader[0].ToString();
                }
                closeConnection();
                return name;
            }
            catch (Exception ex) {
                System.Windows.Forms.MessageBox.Show("Lỗi ở getEmployeeName (Other): " + ex.Message);
                return "";
            }
        }

        public static int getTotalSolve(string memId) {
            try {
                string strCmd = string.Format("select sum(SOLUONG) from CTHDB where MALK = '{0}'", memId);
                int name = 0;
                openConnection();

                // Doc du lieu
                SqlCommand myCmd = new SqlCommand(strCmd, conn);
                SqlDataReader myReader = myCmd.ExecuteReader();
                while (myReader.Read()) {
                    name = myReader.GetInt32(0);
                }
                closeConnection();
                return name;
            }
            catch (Exception ex) {
                System.Windows.Forms.MessageBox.Show("Lỗi ở getGuessName (Other): " + ex.Message);
                return 0;
            }
        }



        public static int getNumber(string strCmd) {
            try {
                int num = 0;
                openConnection();

                // Doc du lieu
                SqlCommand myCmd = new SqlCommand(strCmd, conn);
                SqlDataReader myReader = myCmd.ExecuteReader();
                while (myReader.Read()) {
                    num = myReader.GetInt32(0);
                }
                closeConnection();
                return num;
            }
            catch (Exception ex) {
                System.Windows.Forms.MessageBox.Show("Lỗi ở getEmployeeName (Other): " + ex.Message);
                return 0;
            }
        }

        public static bool excuteQuery(string _strCmd) {
            try {

                openConnection();

                // Them don vi
                SqlCommand myCmd = new SqlCommand(_strCmd, conn);
                SqlDataReader myReader = myCmd.ExecuteReader();

                closeConnection();
                return true;
            }
            catch (Exception ex) {
                System.Windows.Forms.MessageBox.Show("Lỗi ở Connection/executeQuery: " + ex.Message);
                closeConnection();
                return false;
            }

        }
    }


}


