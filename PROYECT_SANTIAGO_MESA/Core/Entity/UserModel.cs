using PROYECT_SANTIAGO_MESA.Core.Entity.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PROYECT_SANTIAGO_MESA.Core.Entity
{
    public class UserModel : BaseModel
    {
        [EmailAddress]
        [Required]
        public string Email { get; set; }
        [Required]
        [StringLength(5)]
        public string Password { get; set; }
        [Compare("Password")]
        [Required]
        public string ConfirmPassword { get; set; }



    }

}
