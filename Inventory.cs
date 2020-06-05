using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HinoGest
{
    class Inventory
    {
        private int invID;
        private String name;
        private int qtt;
        private String type;

        public Inventory(int invID, string name, int qtt, string type)
        {
            this.invID = invID;
            this.name = name;
            this.qtt = qtt;
            this.type = type;
       /*     var user = new User
            {
                Email = "cocas@gmail",
                Password = "1234"
            };*/
        }

        public int InvID { get => invID; set => invID = value; }
        public string Name { get => name; set => name = value; }
        public int Qtt { get => qtt; set => qtt = value; }
        public string Type { get => type; set => type = value; }
    }
}
