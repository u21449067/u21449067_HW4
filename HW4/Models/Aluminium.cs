using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HW4.Models
{
    public class Aluminium : Recyclables
    {
        public Aluminium()
        {

        }

        public Aluminium(DropOffPoint dropOffPoint, string recycleType)
        {
            DropoffPoint = new DropOffPoint();
            DropoffPoint.City = dropOffPoint.City;
            DropoffPoint.Address = dropOffPoint.Address;
            DropoffPoint.Name = dropOffPoint.Name;
            RecycleType = recycleType;
        }

        override
        public string GetDustbinColour()
        {
            return "Yellow";
        }
    }
}