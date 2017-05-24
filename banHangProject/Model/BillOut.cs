using banHangProject.Controller;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banHangProject.Model {
    public class BillOut {
        // Static
        public static int CUR_ID = 0;
        public const string LABEL = "HDX";

        // Attribute
            //id= "HDX" + date.tostring()+ Cur_ID;
        private string id;
        private DateTime date;
        private string employId;
        private string employName;
        private string guessId;
        private string guessName;
        private int totalPrice;
        private List<BillOutDetail> myBillOutDetailList;

        // Constructor
        public BillOut(string _id, DateTime _date, string _employId, string _guessId, int _totalPrice) {
            myBillOutDetailList = new List<BillOutDetail>();
            Id = _id;
            Date = _date;
            EmployId = _employId;
            GuessId = _guessId;
            TotalPrice = _totalPrice;

            EmployName = Connector.getEmployName(_employId);
            GuessName = Connector.getGuessName(_guessId);
            Connector.readBillOutDetailList(Id, myBillOutDetailList);
            int id = int.Parse(Id.Substring(LABEL.Length, Id.Length - LABEL.Length));
            CUR_ID = CUR_ID > id ? CUR_ID : (id + 1);
        }

        public BillOut(DateTime _date, string _employId, string _guessId, int _totalPrice, List<Model.BillOutDetail> _list) {
            myBillOutDetailList = new List<BillOutDetail>();
            Id = LABEL + string.Format("{0:000}", CUR_ID);
            Date = _date;
            EmployId = _employId;
            GuessId = _guessId;
            TotalPrice = _totalPrice;

            EmployName = Connector.getEmployName(_employId);
            GuessName = Connector.getGuessName(_guessId);
            MyList = _list;
            int id = int.Parse(Id.Substring(LABEL.Length, Id.Length - LABEL.Length));
            CUR_ID++;
        }

        // Property
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

        public string GuessId {
            get {
                return guessId;
            }

            set {
                guessId = value;
            }
        }

        public List<BillOutDetail> MyList {
            
            get {
                return myBillOutDetailList;
            }

            set {
                myBillOutDetailList = value;
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

        public string EmployName {
            get {
                return employName;
            }

            set {
                employName = value;
            }
        }

        public string GuessName {
            get {
                return guessName;
            }

            set {
                guessName = value;
            }
        }


        // Method
    }
}
