using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Model
{
    public class Party
    {
        private int id;
        private string name;        

        public Party(int id, string name)
        {
            this.ID = id;
            this.Name = name;
            this.Votes = 0;
        }

        public int ID
        {
            get
            {
                return this.id;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("ID must be greater than 0!");
                }

                this.id = value;               
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name should not be null or empty!");
                }
                this.name = value;
            }
        }      
        public int Votes { get; set; }
    }
}