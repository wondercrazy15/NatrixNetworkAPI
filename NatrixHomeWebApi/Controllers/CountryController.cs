using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NatrixHomeWebApi.Models;

namespace NatrixHomeWebApi.Controllers
{
    public class CountryController : Controller
    {
        private ApplicationDbContext _dbContext { get; set; }

        public CountryController(ApplicationDbContext dbcontext)
        {
            _dbContext = dbcontext;
        }

        [HttpGet]
        [Route("api/Country/GetCountry")]
        public IEnumerable<Country> GetCountry()
        {
            var objCountry = _dbContext.Country.ToList();
            return objCountry;   
        }
    }
}