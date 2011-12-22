using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clinic.Model.EHR
{
    public class HPI
    {
        //http://www.ehrmarket.com/blog/wp-content/uploads/NextGen_HPIform_large.jpg
        public int PHIId { set; get; }
        public string Concern { set; get; }
        public string OnSet { set; get; } //3 days ago
        public string Duration { set; get; } //time
        public string Freequency { set; get; }
        public string Severity { set; get; } //moderate/hard
        public string Status { set; get; }

    }
}
