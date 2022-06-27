using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
   
   
    public class PaymentPlansController : ControllerBase
    {
        PaymentPlanManager pm = new PaymentPlanManager(new EfPaymentPlanRepository());

        //[HttpGet("{getall}")]
        //public List<PaymentPlan> Get()
        //{
        //    return pm.GetList();
        //}

        //[HttpPost]
        //public List<PaymentPlan> Post(PaymentPlan loanType)
        //{
        //    pm.TAdd(loanType);
        //    return pm.GetList();
        //}
        
        [HttpGet("{id}")]
        public PaymentPlan Get(int id)
        {
            return pm.TGetById(id);
        }
        
        [HttpPost]
        public async Task<IActionResult> Post(PaymentPlan paymentPlan)
        {
            paymentPlan.InterestRate /= 100;
            //Odeme Plani Listesi Olusturuldu.
            var planList =pm.OdemePlaniHesapla(paymentPlan.LoanTerm, paymentPlan.InstallmentAmount, paymentPlan.InterestRate);

            //Odeme Plani Tabloya Kaydetme
            //pm.OdemePlaniEkle(planList);
            return new ObjectResult(planList);
        }

    }
}
