using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace Lab07_1910134.DTO
{
    public class Table
    {

        private int capacity;
        public int Capacity
        {
            get { return capacity; }
            set { capacity = value; }
        }


        private int status;
        public int Status
        {
            get { return status; }
            set { status = value; }
        }

        private string name;
        public string Name 
        {
            get { return name; }
            set { name = value; }
        
        }

        private int iD;
        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }

        public Table(int id, string name, int status, int capacity)
        {
            this.ID = id;
            this.Name = name;
            this.Status = status;
            this.Capacity = capacity;
        }

        public Table(DataRow row)
        {
            this.ID = (int)row["id"];
            this.Name = row["name"].ToString();
            this.Status = (int)row["status"];
            this.Capacity = (int)row["capacity"];
        }

    }
}
