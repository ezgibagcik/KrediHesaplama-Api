using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Bank
    {
        public int Id { get; set; }
        public int BankCode { get; set; }
        public string BankName { get; set; }
        public string BankAdress { get; set; }
        public string BankAbout { get; set; }
        public string EftHavale { get; set; }
        public int AtmSayisi { get; set; }
        public int SubeSayisi { get; set; }
        public string BankaUrl { get; set; }
        public string BankaImage { get; set; }
        public List<InterestRate> InterestRate { get; set; }
    }
}
