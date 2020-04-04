using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NatrixHomeWebApi.Models
{
    public class State
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public bool IsActive { get; set; }
        
        //FK
        public int CountryId { get; set; }
        public Country Country { get; set; }

        public ICollection<City> City { get; set; }

    }
}
