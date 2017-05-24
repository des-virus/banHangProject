using banHangProject.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banHangProject.Model {
    // check later
    // Mới sửa hàm tạo đủ đối
    class Label {
        // Static
        public static int CUR_ID = 0;
        public const string LABEL = "NH";

        // Attribute
        private int id;
        private string idString;
        private string name;
        private string idType;
        private string nameType;

        // Constructor
        public Label() {
            this.id = CUR_ID;
            this.IdString = LABEL + id;
            CUR_ID++;
        }

        public Label(string name) {
            this.id = CUR_ID;
            this.IdString = LABEL + id;
            this.name = name;
            CUR_ID++;
        }
        public Label(int id, string name) {
            this.id = id;
            this.IdString = LABEL + id;
            this.name = name;
            CUR_ID = CUR_ID > (id + 1) ? CUR_ID : (id + 1);
        }

        public Label(string idString, string name, string idType) {
            this.IdString = idString;
            this.name = name;
            this.idType = idType;
            this.nameType = Connector.getNameType(idType);
            this.id = int.Parse(idString.Substring(LABEL.Length, idString.Length - LABEL.Length));
            CUR_ID = CUR_ID > id ? CUR_ID : (id + 1);
        }

        public Label(string idString, string name, string idType, string _nameType) {
            this.IdString = idString;
            this.name = name;
            this.idType = idType;
            this.nameType = _nameType;
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

       

        public string IdType {
            get {
                return idType;
            }

            set {
                idType = value;
            }
        }

        public string NameType {
            get {
                return nameType;
            }

            set {
                nameType = value;
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
