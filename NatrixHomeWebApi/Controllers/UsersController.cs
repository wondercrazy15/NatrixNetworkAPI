using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using NatrixHomeWebApi.Migrations;
using NatrixHomeWebApi.Models;
using NatrixHomeWebApi.Repositories.Interfaces;
using NatrixHomeWebApi.Repositories.Services;

namespace NatrixHomeWebApi.Controllers
{
    public class UsersController : Controller
    {
        private readonly ICreateAccount _createAccount;
        public UsersController(ICreateAccount createAccount)
        {
            _createAccount = createAccount;
        }

        [HttpPost]
        [Route("api/Users/CreateAccount")]
        public IActionResult CreateAccount([FromBody]UserDetails model)
        {
            try
            {
                model.CreatedDate = DateTime.Now;
                model.ModifiedDate = DateTime.Now;

                _createAccount.Add(model);
                return Ok(model);
            }
            catch (Exception ex)
            {
                return Ok(ex);
            }
        }
        
    }
}