using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clinic.Model.ERP
{
    public class UnitOfMeansure
    {
        public int UnitOfMeansureId { set; get; }
        public string Name { set; get; }
        public string EDICode { set; get; } //L,Kg
        public string Note { set; get; }
        public bool IsDefault { set; get; }
    }
}
