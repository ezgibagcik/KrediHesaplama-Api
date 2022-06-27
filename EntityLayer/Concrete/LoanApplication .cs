using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class LoanApplication
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string NameSurname { get; set; }
        public string BankName { get; set; }
        public string LoanType { get; set; }
        public double InstallmentAmount { get; set; }
        public int LoanTerm { get; set; }
    }
}
