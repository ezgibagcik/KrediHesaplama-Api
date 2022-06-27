using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class LoanType
    {
        public int Id { get; set; }
        public int LoanCode{ get; set; }
        public string TypeName { get; set; }
        public string TypeAbout { get; set; }
        public List<InterestRate> InterestRate { get; set; }
    }
}
