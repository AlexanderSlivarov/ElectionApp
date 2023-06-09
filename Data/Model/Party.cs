﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Model
{
    /// <summary>
    /// Model for the Party class. Database uses this model.
    /// </summary>
    public class Party
    {
        private int id;
        private int listNumber;
        private string name;
        private int preferenceNumber;

        /// <summary>
        /// Empty constructor for the class. 
        /// </summary>
        public Party()
        {

        }
        /// <summary>
        /// Constructor for Party class. This constructor fills every field in the class. By default the Votes are 0.
        /// </summary>
        /// <param name="listNumber"></param>
        /// <param name="name"></param>       
        public Party(int listNumber, string name)
        {
            this.ListNumber = listNumber;
            this.Name = name;
            this.Votes = 0;
        }

        /// <summary>
        /// Constructor for Order class. This constructor fills every field in the class. By default the Votes are 0;
        /// </summary>
        /// <param name="listNumber"></param>
        /// <param name="name"></param>
        /// <param name="preferenceNumber"></param>
        public Party(int listNumber, string name, int preferenceNumber)
        {
            this.ListNumber = listNumber;
            this.Name = name;
            this.PreferenceNumber = preferenceNumber;
            this.Votes = 0;
        }

        /// <summary>
        /// Public fields that the class and database contain. 
        /// </summary>
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

        public int ListNumber
        {
            get
            {
                return this.listNumber;
            }
            set
            {
                this.listNumber = value;
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

        public int PreferenceNumber
        {
            get
            {
                return this.preferenceNumber;
            }
            set
            {
                this.preferenceNumber = value;
            }
        }
    }
}