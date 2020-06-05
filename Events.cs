using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HinoGest
{
    class Events
    {
        private int evID;
        private String name;
        private DateTime date;
        private String type;
        private SqlMoney cachet;
        private String obs;

        public Events(int evID, string name, DateTime date, string type, SqlMoney cachet, string obs)
        {
            this.evID = evID;
            this.name = name;
            this.date = date;
            this.type = type;
            this.cachet = cachet;
            this.obs = obs;
        }

        public int EvID { get => evID; set => evID = value; }
        public string Name { get => name; set => name = value; }
        public DateTime Date { get => date; set => date = value; }
        public string Type { get => type; set => type = value; }
        public SqlMoney Cachet { get => cachet; set => cachet = value; }
        public string Obs { get => obs; set => obs = value; }

    }
}
