//using Api.Models;
//using Api.Services.EmailService;
//using MailKit.Net.Smtp;
//using MailKit.Security;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using MimeKit;
//using MimeKit.Text;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//namespace Api.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class EmailController : ControllerBase
//    {
//        private readonly IEmailService _emailService;

//        public EmailController(IEmailService emailService )
//        {
//            _emailService = emailService;
//        }
//        [HttpPost]
//        public IActionResult SendEmail(EmailDto request)
//        {
//            _emailService.SendEmail(request);
//            return Ok();
//        }

//    }
//}
