using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IPaymentPlanService : IGenericService<PaymentPlan>
    {
        List<PaymentPlan> OdemePlaniHesapla(int bankId, double paymentAmount, double loanTerm);
        double hesaplaTaksitTutari(double krediTutari, int vade, double faiz);
        void OdemePlaniEkle(List<PaymentPlan> lstPaymentPlan);
    }
}
