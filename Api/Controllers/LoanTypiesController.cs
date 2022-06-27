using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoanTypiesController : ControllerBase
    {
        LoanTypeManager lm = new LoanTypeManager(new EfLoanTypeRepository());
        [HttpGet]
        public List<LoanType> Get()
        {
            return lm.GetList();
        }

        [HttpPost]
        public List<LoanType> Post(LoanType loanType)
        {
            lm.TAdd(loanType);
            return lm.GetList();
        }

        [HttpGet("{id}")]
        public LoanType Get(int id)
        {
            return lm.TGetById(id);
        }
    }
}
