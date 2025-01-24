using Loan_Calculator_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Loan_Calculator_MVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View(new loan());
        }

        [HttpPost]
        public ActionResult Index(loan model, string compute)
        {
            model.DisManufacturer = model.Manufacturer;
            string unit = model.UnitPrice.ToString("C");
            model.DisUnitPrice = unit;
            if (model.Manufacturer != "")
            {

                if (model.DPRate == "10%")
                {
                    model.DisDownpayment = model.UnitPrice * .10;
                    double dp = model.UnitPrice * .10;
                    model.DisplayDownpayment = dp.ToString("C");
                }
                else if (model.DPRate == "15%")
                {
                    model.DisDownpayment = model.UnitPrice * .15;
                    double dp = model.UnitPrice * .15;
                    model.DisplayDownpayment = dp.ToString("C");
                }
                else if (model.DPRate == "20%")
                {
                    model.DisDownpayment = model.UnitPrice * .20;
                    double dp = model.UnitPrice * .20;
                    model.DisplayDownpayment = dp.ToString("C");
                }
                else if (model.DPRate == "25%")
                {
                    model.DisDownpayment = model.UnitPrice * .25;
                    double dp = model.UnitPrice * .25;
                    model.DisplayDownpayment = dp.ToString("C");
                }
                else if (model.DPRate == "30%")
                {
                    model.DisDownpayment = model.UnitPrice * .30;
                    double dp = model.UnitPrice * .30;
                    model.DisplayDownpayment = dp.ToString("C");
                }



                if (model.Term == "12 months")
                {
                    double loanable = model.UnitPrice - model.DisDownpayment;
                    model.DisLoanable = loanable.ToString("C");
                    double amortizationNoInt = loanable / 12;
                    double profit = amortizationNoInt * .10;
                    double amortizationWithInt = amortizationNoInt + profit;
                    model.DisAmortizaton = Math.Ceiling(amortizationWithInt).ToString("C");
                }
                else if (model.Term == "24 months")
                {
                    double loanable = model.UnitPrice - model.DisDownpayment;
                    model.DisLoanable = loanable.ToString("C");
                    double amortizationNoInt = loanable / 24;
                    double profit = amortizationNoInt * .1047;
                    double amortizationWithInt = amortizationNoInt + profit;
                    model.DisAmortizaton = Math.Ceiling(amortizationWithInt).ToString("C");
                }
                else if (model.Term == "36 months")
                {
                    double loanable = model.UnitPrice - model.DisDownpayment;
                    model.DisLoanable = loanable.ToString("C");
                    double amortizationNoInt = loanable / 36;
                    double profit = amortizationNoInt * .1648;
                    double amortizationWithInt = amortizationNoInt + profit;
                    model.DisAmortizaton = Math.Ceiling(amortizationWithInt).ToString("C");
                }
                else if (model.Term == "48 months")
                {
                    double loanable = model.UnitPrice - model.DisDownpayment;
                    model.DisLoanable = loanable.ToString("C");
                    double amortizationNoInt = loanable / 48;
                    double profit = amortizationNoInt * .18;
                    double amortizationWithInt = amortizationNoInt + profit;
                    model.DisAmortizaton = Math.Ceiling(amortizationWithInt).ToString("C");
                }

            }
            return View(model);
        }
    }
}