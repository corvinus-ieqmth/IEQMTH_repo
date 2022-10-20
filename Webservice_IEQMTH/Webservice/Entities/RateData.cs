using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webservice.Entities
{
    class RateData
    {
        public DateTime Date { get; set; }
        public string Currency { get; set; }
        public decimal Value { get; set; }

        public RateData(DateTime date, string currency, decimal value)
        {
            Date = date;
            Currency = currency;
            Value = value;
        }
    }
}
