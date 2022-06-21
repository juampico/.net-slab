using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slab.Net.EF.Entities.Model.DTOS
{
    public class ShipperDTO
    {

        
        public int ShipperID { get; set; }

        [Required]
        [StringLength(40)]
        public string CompanyName { get; set; }

        [StringLength(24)]
        public string Phone { get; set; }

    }
}
