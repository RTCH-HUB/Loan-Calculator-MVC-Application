using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Loan_Calculator_MVC.Models
{
    public class loan
    {
        public string DisManufacturer { get; set; }
        public string DisUnitPrice { get; set; }
        public string DisAmortizaton { get; set; }
        public double DisDownpayment { get; set; }
        public string DisplayDownpayment { get; set; }
        public string DisLoanable { get; set; }
        public string Manufacturer { get; set; }
        public double UnitPrice { get; set; }
        public string DPRate { get; set; }
        public string Term { get; set; }
    }
}