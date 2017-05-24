using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banHangProject.Model {
    public class Provider {
        // Static
        public static int CUR_ID = 0;
        public const string LABEL = "NCC";

        // Attribute
        private int id;
        private string idString;
        private string name = "";
        private string add = "";
        private string phone = "";


        // Constructor
        public Provider() {
            this.id = CUR_ID;
            this.IdString = LABEL + id;
            CUR_ID++;
        }

        public Provider(string name) {
            this.id = CUR_ID;
            this.IdString = LABEL + id;
            this.name = name;
            CUR_ID++;
        }
        public Provider(int id, string name) {
            this.id = id;
            this.IdString = LABEL + id;
            this.name = name;
            CUR_ID = CUR_ID > (id + 1) ? CUR_ID : (id + 1);
        }

        public Provider(string idString, string name, string add, string phone) {
            this.IdString = idString;
            this.name = name;
            this.id = int.Parse(idString.Substring(LABEL.Length, idString.Length - LABEL.Length));
            this.phone = phone;
            this.add = add;
            CUR_ID = CUR_ID > id ? CUR_ID : (id + 1);
        }

        public Provider(Provider u1) {
            this.id = u1.Id;
            this.IdString = u1.IdString;
            this.name = u1.name;
            this.phone = u1.phone;
            this.add = u1.add;
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

        public string Phone {
            get {
                return phone;
            }

            set {
                phone = value;
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
    }
}
