using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventory_control.Data.Models
{
    public class Location
    {
        [Key]
        public int LocationId { get; set; }

        [Required]
        public string LocationName { get; set; }

        public int PalletCapacity { get; set; }

        public virtual ICollection<ItemLocationXref> ItemLocationXrefs { get; set; }
    }
}
