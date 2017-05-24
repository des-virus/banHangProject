using banHangProject.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banHangProject.Model {
   public class Guess {
        // Static
        public static int CUR_ID = 0;
        public const string LABEL = "KH";

        // Attribute
        private int id;
        private string idString;
        private string name;
        private string add;
        private string memId;
        private string memName;
        private string discountPercent;
        private string phone;

        // Constructor
        public Guess() {
            this.Id = CUR_ID;
            this.IdString = LABEL + Id;
            CUR_ID++;
        }

        public Guess(string name) {
            this.Id = CUR_ID;
            this.IdString = LABEL + Id;
            this.Name = name;
            CUR_ID++;
        }

        public Guess(string idString, string name, string add, string phone) {
            this.IdString = idString;
            this.Name = name;
            this.Add = add;
            this.Phone = phone;
            this.memId = "TV001";
            this.MemName = Connector.getMemName(MemId);
            this.Id = int.Parse(idString.Substring(LABEL.Length, idString.Length - LABEL.Length));
            CUR_ID = CUR_ID > Id ? CUR_ID : (Id + 1);
        }

        public Guess(string idString, string name, string add, string memId, string phone) {
            this.IdString = idString;
            this.Name = name;
            this.Add = add;
            this.Phone = phone;
            this.MemId = memId;
            this.DiscountPercent = Connector.getDiscountPercent(memId);
            this.MemName = Connector.getMemName(MemId);
            this.Id = int.Parse(idString.Substring(LABEL.Length, idString.Length - LABEL.Length));
            CUR_ID = CUR_ID > Id ? CUR_ID : (Id + 1);
        }

        public Guess(Guess g1) {
            this.IdString = g1.IdString;
            this.Name = g1.Name;
            this.Add = g1.Add;
            this.Phone = g1.Phone;
            this.DiscountPercent = g1.DiscountPercent;
            this.MemId = g1.MemId;
            this.MemName = g1.MemName;
            this.Id = g1.Id;
            CUR_ID = CUR_ID > Id ? CUR_ID : (Id + 1);
        }
        // Property
        public int Id {
            get {
                return id;
            }

            set {
                id = value;
            }
        }

        public string IdString {
            get {
                return idString;
            }

            set {
                idString = value;
            }
        }

        public string Name {
            get {
                return name;
            }

            set {
                name = value;
            }
        }

        public string Add {
            get {
                return add;
            }

            set {
                add = value;
            }
        }

        public string MemId {
            get {
                return memId;
            }

            set {
                memId = value;
            }
        }

        public string DiscountPercent {
            get {
                return discountPercent;
            }

            set {
                discountPercent = value;
            }
        }

        public string Phone {
            get {
                return phone;
            }

            set {
                phone = value;
            }
        }

        public string MemName {
            get {
                return memName;
            }

            set {
                memName = value;
            }
        }
    }
}
