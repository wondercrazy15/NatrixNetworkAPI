using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace NatrixHomeWebApi.Models
{
    public class UserDetails
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string ProfilePicture { get; set; }
        public bool IsAllowTermsAndConditions { get; set; }
        public bool IsVerifyEmail { get; set; }
        public string VerifyEmailToken { get; set; }
        public bool IsActive { get; set; }
        public bool IsDelete { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedDate { get; set; }

        //FK
        public int CountryId { get; set; }
        public Country Country { get; set; }
        public int HireTypeId { get; set; }
        public HireType HireType { get; set; }
    }
}
