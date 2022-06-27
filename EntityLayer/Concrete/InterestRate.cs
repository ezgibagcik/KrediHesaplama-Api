using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class InterestRate
    {
        
        public int Id { get; set; }
        public double InterestPercent { get; set; }
        public int MinTerm { get; set; }
        public int MaxTerm { get; set; }
        public int MinCreditCost{ get; set; }
        public int MaxCreditCost { get; set; }
        public int LoanTypeId { get; set; }
        public LoanType LoanType { get; set; }
        public int BankId { get; set; }
        public Bank Bank { get; set; }
    }
}
