using PROYECT_SANTIAGO_MESA.Core.Entity.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PROYECT_SANTIAGO_MESA.Core.Entity
{
    [Table("Provider")]
    public class ProviderModel : BaseModel
    {
        [Required]
        public string Name { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Phone { get; set; }

        public string Adrress { get; set; }

        public string Notes { get; set; }


    }

}
