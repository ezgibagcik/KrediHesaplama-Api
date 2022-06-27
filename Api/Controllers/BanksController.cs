using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
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

    public class BanksController : ControllerBase
    {
        BankManager bm = new BankManager(new EfBankRepository());

        [HttpGet]
        public List<Bank> Get()
        {
            return bm.GetList();
        }

        [HttpPost]
        public List<Bank> Post(Bank bank)
        {
            bm.TAdd(bank);
            return bm.GetList();
        }

        [HttpGet("{id}")]
        public Bank Get(int id)
        {
            return bm.TGetById(id);
        }
    }
}
