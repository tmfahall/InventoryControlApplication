using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventory_control.Data.Models
{
    public class ItemLocationXref
    {
        [Key]
        public int ItemLocationXrefId { get; set; }

        [Required]
        public int ItemId { get; set; }

        [ForeignKey("ItemId"), InverseProperty("ItemLocationXrefs")]
        public virtual Item Item { get; set; }

        [Required]
        public int LocationId { get; set; }

        [ForeignKey("LocationId"), InverseProperty("ItemLocationXrefs")]
        public virtual Location Location { get; set; }

        [Required]
        public int QuantityOnPallet { get; set; }
    }
}
