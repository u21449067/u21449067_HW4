using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HW4.Models
{
    public abstract class Recyclables
    {
        //protected DropOffPoint dropOffPoint;
        public String RecycleType { get; set; }
        public DropOffPoint DropoffPoint { get; set; }

        //abstract protected void setRecycleType(string newRecycleType);
        //abstract protected String getRecycleType();
        //abstract protected DropOffPoint getDropOffPoint();
        //abstract protected void setDropOffPoint(DropOffPoint newDropOffPoint);

        public Recyclables()
        {

        }

        public abstract string GetDustbinColour();
    }
}