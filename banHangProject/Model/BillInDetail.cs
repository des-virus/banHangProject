using banHangProject.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banHangProject.Model {
    class BillInDetail {
        // Attribute
        private string idBillIn;
        private string idItem;
        private string nameItem;
        private int cost;
        private int count;

        // Attribute
        public BillInDetail(string _idBillIn, string _idItem, int _cost, int _count) {
            IdBillIn = _idBillIn;
            IdItem = _idItem;
            Cost = _cost;
            Count = _count;

            NameItem = Connector.getItemName(_idItem);
        }


        // Property
        public string IdBillIn {
            get {
                return idBillIn;
            }

            set {
                idBillIn = value;
            }
        }

        public string IdItem {
            get {
                return idItem;
            }

            set {
                idItem = value;
            }
        }

        public string NameItem {
            get {
                return nameItem;
            }

            set {
                nameItem = value;
            }
        }

        public int Count {
            get {
                return count;
            }

            set {
                count = value;
            }
        }

        public int Cost {
            get {
                return cost;
            }

            set {
                cost = value;
            }
        }
    }
}
