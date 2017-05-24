using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banHangProject.Model {
    public class Unit {
        // Static
        public static int CUR_ID = 0;
        public const string LABEL = "DV";

        // Attribute
        private int id;
        private string idString;
        private string name;

        // Constructor
        public Unit() {
            this.id = CUR_ID;
            this.idString = LABEL + id;
            this.name = "";
            CUR_ID++;
        }

        public Unit(string name) {
            this.id = CUR_ID;
            this.idString = LABEL + id;
            this.name = name;
            CUR_ID++;
        }
        public Unit(int id, string name) {
            this.id = id;
            this.idString = LABEL + id;
            this.name = name;
            CUR_ID = CUR_ID > (id + 1) ? CUR_ID : (id + 1);
        }

        public Unit(string idString, string name) {
            this.idString = idString;
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
        public string toString() {
            return "id = " + id + ", name = " + name;
        }
    }
}
