using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class PaymentPlan
    {
        public int Id { get; set; }
        public int LoanTerm { get; set; } //taksit no (vade)
        public double InstallmentAmount { get; set; } //taksit tutarı
        public double InterestRate { get; set; } //faiz oranı
        public double AmountOfInterestPaid { get; set; } //Ödenen Faiz Tutarı
        public double AmountOfPrincipalPaid { get; set; } //Ödenen Anapara Tutarı
        public double RemainingPrincipalDebt { get; set; } //Kalan Anapara Borcu
        public bool PaymentState { get; set; } // odeme durumu
        public string User { get; set; } //kullanıcı
        public DateTime TransactionDate { get; set; } //işlem Tarihi
    }
}
