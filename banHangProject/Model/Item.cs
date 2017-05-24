using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banHangProject.Model {
    class Item {
        // Static   
        public static int CUR_ID = 0;
        public const string LABEL = "LK";

        // Attribute
        private string idString;
        private string name;
        private string labelId;
        private string labelName;
        private string procId;
        private string procName;
        private string provId;
        private string provName;
        private string unitId;
        private string unitName;
        private int inPrice;
        private int solve;
        private int outPrice;
        private int existNumber;
        private string description;
        private string img;

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

        public string LabelId {
            get {
                return labelId;
            }

            set {
                labelId = value;
            }
        }

        public string LabelName {
            get {
                return labelName;
            }

            set {
                labelName = value;
            }
        }

        public string ProcId {
            get {
                return procId;
            }

            set {
                procId = value;
            }
        }

        public string ProcName {
            get {
                return procName;
            }

            set {
                procName = value;
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

        public string UnitId {
            get {
                return unitId;
            }

            set {
                unitId = value;
            }
        }

        public string UnitName {
            get {
                return unitName;
            }

            set {
                unitName = value;
            }
        }

        public int InPrice {
            get {
                return inPrice;
            }

            set {
                inPrice = value;
            }
        }

        public int OutPrice {
            get {
                return outPrice;
            }

            set {
                outPrice = value;
            }
        }

        public int ExistNumber {
            get {
                return existNumber;
            }

            set {
                existNumber = value;
            }
        }

        public string Description {
            get {
                return description;
            }

            set {
                description = value;
            }
        }

        public string Img {
            get {
                return img;
            }

            set {
                img = value;
            }
        }

        public int Solve {
            get {
                return solve;
            }

            set {
                solve = value;
            }
        }


        // Contructor
        public Item(string _idString, string _name, string _labelId, string _procId, string _provId, string _unitId, int _inPrice, int _outPrice, int _existNumber, string _description, string _img) {
            IdString = _idString;
            Name = _name;
            LabelId = _labelId;
            ProcId = _procId;
            ProvId = _provId;
            UnitId = _unitId;
            InPrice = _inPrice;
            OutPrice = _outPrice;
            ExistNumber = _existNumber;
            Description = _description;
            Img = _img;
            LabelName = Controller.Connector.getNameLabel(_labelId);
            ProvName = Controller.Connector.getNameProv(_provId);
            ProcName = Controller.Connector.getNameProc(_procId);
            UnitName = Controller.Connector.getNameUnit(_unitId);
            Solve = Controller.Connector.getTotalSolve(IdString);
        }
    }
}
