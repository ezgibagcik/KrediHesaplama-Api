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
    public class InterestRatesController : ControllerBase
    {
        InterestRateManager im = new InterestRateManager(new EfInterestRateRepository());
        [HttpGet]
        public List<InterestRate> Get()
        {
            return im.GetList();
        }

        [HttpPost]
        public List<InterestRate> Post(InterestRate interestRate)
        {
            im.TAdd(interestRate);
            return im.GetList();
        }

        [HttpGet("{id}")]
        public InterestRate Get(int id)
        {
            return im.TGetById(id);
        }
    }
}
