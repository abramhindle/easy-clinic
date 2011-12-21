using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Clinic.Model.CRM;

namespace Clinic.Model.EHR
{
    /// <summary>
    /// Di ung
    /// </summary>
    public class Allergies
    {
        public int Allergies { set; get; }
        public Partner Partner { set; get; }
        public string Name { set; get; }
    }
}
