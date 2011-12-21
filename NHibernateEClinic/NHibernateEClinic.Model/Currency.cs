using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clinic.Model.Infrastructure
{
    public class Currency
    {
        public int CurrencyId { set; get; } //1 2 3 4
        public string Code { set; get; } //VND USD
        public string Name { set; get; }
    }
}
