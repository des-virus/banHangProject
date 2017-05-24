using banHangProject.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banHangProject.Model {
    public class Employee {
        // Static
        public static int CUR_ID = 0;
        public const string LABEL = "NV";

        // Attribute
        private int id;
        private string idString;
        private string password;
        private string name;
        private string add;
        private string divId;
        private string divName;
        private string phone;
        private bool status;
        private int permission;
        // Constructor
        public Employee(string _idString, string _name, string _add, string _divId, string _phone, string _pass, bool _status, int _permission) {
            IdString = _idString;
            Name = _name;
            Add = _add;
            Phone = _phone;
            DivId = _divId;
            Password = _pass;
            Status = _status;
            permission = _permission;
            this.id = int.Parse(idString.Substring(LABEL.Length, idString.Length - LABEL.Length));

            DivName = Connector.getDivName(_divId);

        }
        public Employee(string _idString, string _name, string _add, string _divId, string _phone, bool _status, int _permission) {
            IdString = _idString;
            Name = _name;
            Add = _add;
            Phone = _phone;
            DivId = _divId;
            Status = _status;
            permission = _permission;
            this.id = int.Parse(idString.Substring(LABEL.Length, idString.Length - LABEL.Length));

            DivName = Connector.getDivName(_divId);

        }
        public Employee(Employee e1) {
            idString = e1.idString;
            Name = e1.Name;
            Add = e1.Add;
            Phone = e1.Phone;
            DivId = e1.DivId;
            Password = e1.Password;
            Status = e1.Status;
            DivName = e1.DivName;
            permission = e1.permission;

        }
        // Property

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

        public string DivId {
            get {
                return divId;
            }

            set {
                divId = value;
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

        public bool Status {
            get {
                return status;
            }

            set {
                status = value;
            }
        }

        public string Password {
            get {
                return password;
            }

            set {
                password = value;
            }
        }



        public string DivName {
            get {
                return divName;
            }

            set {
                divName = value;
            }
        }

        public string IdString {
            get {
                return idString;
            }

            set {
                this.idString = value;
            }
        }

        public int Permission {
            get {
                return permission;
            }

            set {
                permission = value;
            }
        }

        public int Id {
            get {
                return id;
            }

            set {
                id = value;
            }
        }
    }
}
