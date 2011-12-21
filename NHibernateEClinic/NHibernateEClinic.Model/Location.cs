using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clinic.Model.Infrastructure
{
    public class Location
    {
        public string LocationId { set; get; }
        public string Name { set; get; }
        public string Country { set; get; }
        public string State { set; get; }
        public string City { set; get; }
        public string Phone { set; get; }
        public string Fax { set; get; }
        public string Email { set; get; }
        public string Note { set; get; }

    }
}
