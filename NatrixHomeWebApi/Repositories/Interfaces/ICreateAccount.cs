using NatrixHomeWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NatrixHomeWebApi.Repositories.Interfaces
{
    public interface ICreateAccount
    {
        public UserDetails Add(UserDetails register);
    }
}
