using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyRoom.Web.ApiControllers
{
    public class AccountController : ControllerBase
    {
        [HttpGet]
        public string Index()
        {
            return "ACCOUNT";
        }
    }
}