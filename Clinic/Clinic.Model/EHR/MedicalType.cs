using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clinic.Model.EHR
{
    /// <summary>
    /// Surgical/Obstetric/Medication/Allergies/Family/Social/Habits/Immunization/Developmental/SignsAndSymptoms
    /// </summary>
    public class MedicalType
    {
        public int MedicalTypeId { set; get; }
        public string Name { set; get; }
    }
}
