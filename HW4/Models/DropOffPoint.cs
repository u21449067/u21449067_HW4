using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HW4.Models
{
    public class DropOffPoint
    {
        public string City;
        public string Address;
        public string Name;

        public DropOffPoint()
        {
        
        }

        public DropOffPoint(string city, string address, string name)
        {
            City = city;
            Address = address;
            Name = name;
        }
    }
}