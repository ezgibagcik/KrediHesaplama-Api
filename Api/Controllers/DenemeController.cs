using Microsoft.AspNetCore.Cors;
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
   
    public class DenemeController : ControllerBase
    {
     
        [HttpPost]
        public string Deneme() 
        {
            return "Hello";
        }
    }
}
