using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class PaymentPlanManager : IPaymentPlanService
    {
        IPaymentPlanDal _paymentPlanDal;
        public PaymentPlanManager(IPaymentPlanDal paymentDal)
        {
            _paymentPlanDal = paymentDal;
        }

        public List<PaymentPlan> OdemePlaniHesapla(int krediVadesi, double krediTutar, double faizOrani)
        {
            List<PaymentPlan> lstPaymentPlan = new List<PaymentPlan>();


            double ilkDeger = krediTutar;
            for (int vade = 1; vade <= krediVadesi; vade++)
            {
                PaymentPlan paymentPlan = new PaymentPlan();
                paymentPlan.LoanTerm = vade;
                paymentPlan.InstallmentAmount = hesaplaTaksitTutari(ilkDeger, krediVadesi, faizOrani);
                paymentPlan.AmountOfInterestPaid = Math.Round(krediTutar * faizOrani, 2);
                paymentPlan.AmountOfPrincipalPaid = Math.Round(paymentPlan.InstallmentAmount - paymentPlan.AmountOfInterestPaid, 2);
                paymentPlan.RemainingPrincipalDebt = Math.Round(krediTutar - paymentPlan.AmountOfPrincipalPaid, 2);
                lstPaymentPlan.Add(paymentPlan);
                krediTutar -= paymentPlan.AmountOfPrincipalPaid;
            }
            return lstPaymentPlan;
        }

        public void OdemePlaniEkle(List<PaymentPlan> lstPaymentPlan)
        {
            foreach (var odemePlan in lstPaymentPlan)
            {
                TAdd(odemePlan);
            }
        }

        public double hesaplaTaksitTutari(double krediTutari, int vade, double faiz)
        {
            double taksitTutari = 0;
            taksitTutari = krediTutari * (faiz * Math.Pow(1 + faiz, vade)) / (Math.Pow(1 + faiz, vade) - 1);
            return Math.Round(taksitTutari, 2);
        }

        #region CRUD Islemleri

        public void TAdd(PaymentPlan t)
        {
            _paymentPlanDal.Insert(t);
        }

        public void TDelete(PaymentPlan t)
        {
            _paymentPlanDal.Delete(t);
        }
        public List<PaymentPlan> GetList()
        {
            return _paymentPlanDal.GetListAll();
        }

        public PaymentPlan TGetById(int id)
        {
            return _paymentPlanDal.GetById(id);
        }

        public void TUpdate(PaymentPlan t)
        {
            _paymentPlanDal.Update(t);
        }

        #endregion CRUD Islemleri
    }
}
