using banHangProject.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banHangProject.Model {
    class BillIn {
        // Static
        public static int CUR_ID = 0;
        public const string LABEL = "HDN";

        // Attribute
        //id= "HDX" + date.tostring()+ Cur_ID;
        private string id;
        private DateTime date;
        private string employId;
        private string employName;
        private string provId;
        private string provName;
        private int totalPrice;
        private List<BillInDetail> myBillInDetailList;

        public string Id {
            get {
                return id;
            }

            set {
                id = value;
            }
        }

        public DateTime Date {
            get {
                return date;
            }

            set {
                date = value;
            }
        }

        public string EmployId {
            get {
                return employId;
            }

            set {
                employId = value;
            }
        }

        public string EmployName {
            get {
                return employName;
            }

            set {
                employName = value;
            }
        }

        public string ProvId {
            get {
                return provId;
            }

            set {
                provId = value;
            }
        }

        public string ProvName {
            get {
                return provName;
            }

            set {
                provName = value;
            }
        }

        public int TotalPrice {
            get {
                return totalPrice;
            }

            set {
                totalPrice = value;
            }
        }

        public List<BillInDetail> MyBillInDetailList {
            get {
                return myBillInDetailList;
            }

            set {
                myBillInDetailList = value;
            }
        }

        // Constructor
        public BillIn(string _id, DateTime _date, string _employId, string _provId, int _totalPrice) {
            MyBillInDetailList = new List<BillInDetail>();
            Id = _id;
            Date = _date;
            EmployId = _employId;
            ProvId = _provId;
            TotalPrice = _totalPrice;

            EmployName = Connector.getEmployName(_employId);
            ProvName = Connector.getNameProv(_provId);
            Connector.readBillInDetailList(Id, myBillInDetailList);
            int id = int.Parse(Id.Substring(LABEL.Length, Id.Length - LABEL.Length));
            CUR_ID = CUR_ID > id ? CUR_ID : (id + 1);
        }

        public BillIn(DateTime _date, string _employId, string _provId, int _totalPrice, List<Model.BillInDetail> _list) {
            myBillInDetailList = new List<BillInDetail>();
            Id = LABEL + string.Format("{0:000}", CUR_ID);
            Date = _date;
            EmployId = _employId;
            ProvId = _provId;
            TotalPrice = _totalPrice;

            EmployName = Connector.getEmployName(_employId);
            ProvName = Connector.getNameProv(_provId);
            myBillInDetailList = _list;
            int id = int.Parse(Id.Substring(LABEL.Length, Id.Length - LABEL.Length));
            CUR_ID++;
        }

        // Property
    }
}
