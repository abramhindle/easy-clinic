using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clinic.Model.ERP
{
    public class Service
    {
        public int ServiceId { set; get; }
        public string Name { set; get; }
        public ServiceType ServiceType { set; get; }       
        public UnitOfMeansure Unit { set; get; }
        public decimal Price { set; get; }
        public string Note { set; get; }
    }
}
