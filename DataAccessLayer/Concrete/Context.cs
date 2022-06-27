using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=EZGIBAGCIK; database=KrediHesaplama; integrated security=true;");
        }
        public DbSet<Bank> Bank { get; set; }
        public DbSet<InterestRate> InterestRate { get; set; }
        public DbSet<LoanType> LoanType { get; set; }
        public DbSet<PaymentPlan> PaymentPlan { get; set; }
        public DbSet<LoanApplication> LoanApplication { get; set; }

    }
}
