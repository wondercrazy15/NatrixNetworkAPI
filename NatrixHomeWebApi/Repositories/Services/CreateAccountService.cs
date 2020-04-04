using NatrixHomeWebApi.Models;
using NatrixHomeWebApi.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NatrixHomeWebApi.Repositories.Services
{
    public class CreateAccountService : ICreateAccount
    {
        private ApplicationDbContext _dbContext { get; set; }

        public CreateAccountService(ApplicationDbContext dbcontext)
        {
            _dbContext = dbcontext;
        }
        
        public UserDetails Add(UserDetails model)
        {
            try
            {
                _dbContext.UserDetails.Add(model);
                _dbContext.SaveChanges();
                return model;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
            
        }
    }
}
