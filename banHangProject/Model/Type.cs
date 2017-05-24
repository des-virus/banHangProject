using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banHangProject.Model {
    class Type {
        // Static
        public static int CUR_ID = 0;
        public const string LABEL = "LLK";

        // Attribute
        private int id;
        private string idString;
        private string name;
        // Constructor
        public Type() {
            this.id = CUR_ID;
            this.IdString = LABEL + id;
            this.name = "";
            CUR_ID++;
        }

        public Type(string name) {
            this.id = CUR_ID;
            this.IdString = LABEL + id;
            this.name = name;
            CUR_ID++;
        }
        public Type(int id, string name) {
            this.id = id;
            this.IdString = LABEL + id;
            this.name = name;
            CUR_ID = CUR_ID > (id + 1) ? CUR_ID : (id + 1);
        }

        public Type(string idString, string name) {
            this.IdString = idString;
            this.name = name;
            this.id = int.Parse(idString.Substring(LABEL.Length, idString.Length - LABEL.Length));
            CUR_ID = CUR_ID > id ? CUR_ID : (id + 1);
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

        public string IdString {
            get {
                return idString;
            }

            set {
                idString = value;
            }
        }

        // Method
    }
}
