using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Address
    {
        private string city;
        private string street;
        private int house;
        public string City
        {
            get
            {
                return this.city;
            }
            set
            {
                this.city = value;
            }
        }
        public string Street
        {
            get
            {
                return this.street;
            }
            set
            {
                this.street = value;
            }
        }
        public int House
        {
            get
            {
                return this.house;
            }
            set
            {
                this.house = value;
            }
        }
    }
}
