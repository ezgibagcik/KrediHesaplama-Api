//using BusinessLayer.Concrete;
//using DataAccessLayer.Concrete;
//using DataAccessLayer.EntityFramework;
//using EntityLayer.Concrete;
//using Microsoft.AspNetCore.Authorization;
//using Microsoft.AspNetCore.Mvc;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//namespace CreditCalculation
//{
//    public class HomeController : Controller
//    {
//        BankManager bm = new BankManager(new EfBankRepository());
//        PaymentPlanManager pm = new PaymentPlanManager(new EfPaymentPlanRepository());
//        [AllowAnonymous]
//        public IActionResult Index()
//        {
//            var values = bm.GetList();
//            return View(values);

//        }
//        [HttpGet]
//        public IActionResult Calculate() 
//        {
//            return View();
//        }
//        [HttpPost]
//        public IActionResult Calculate(PaymentPlan p)
//        {
//            p.TransactionDate = DateTime.Parse(DateTime.Now.ToShortTimeString());
//            pm.TAdd(p);
//           //return View();
//            return RedirectToAction("CalculateResult", "Home");
//        }
//        [HttpGet]
//        public IActionResult CalculateResult()
//        {
//            return View();
//        }
//        [HttpPost]
//        public IActionResult CalculateResult(int paymentId, double paymentAmount, int loanTerm)
//        {
//            //Context c = new Context();
//            //paymentId = 18;
//            //var KrediTutarı = c.PaymentPlan.Where(x => x.Id == paymentId).Select(y => y.InstallmentAmount).FirstOrDefault();
//            //var KrediVade = c.PaymentPlan.Where(x => x.Id == paymentId).Select(y => y.LoanTerm).FirstOrDefault();
//            //paymentAmount = KrediTutarı;
//            //loanTerm = KrediVade;
//            //var HesaplananDeger =pm.OdemePlaniHesapla(paymentId, paymentAmount,loanTerm);
//            //double result = HesaplananDeger;
//            //ViewBag.r = paymentAmount;
//            return View();
//        }



//    }
//}
