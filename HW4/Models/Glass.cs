using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HW4.Models
{
    public class Glass : Recyclables
    {
        //protected override DropOffPoint getDropOffPoint()
        //{
        //    return dropOffPoint;
        //}

        //protected override void setDropOffPoint(DropOffPoint newDropOffPoints)
        //{
        //    dropOffPoint = newDropOffPoints;
        //}

        public Glass(DropOffPoint dropOffPoint, string recycleType)
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
            return "Green";
        }

        //protected override string getRecycleType()
        //{
        //    return RecycleType;
        //}

        //protected override void setRecycleType(string newRecycleType)
        //{
        //    RecycleType = newRecycleType;
        //}
    }
}