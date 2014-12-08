using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventory_control.Data.Models
{
    public class SupplierPart
    {
        [Key]
        public int SupplierPartId { get; set; }

        [Required]
        public string SupplierPartName { get; set; }

        [Required]
        public int SupplierId { get; set; }

        [ForeignKey("SupplierId"), InverseProperty("SupplierParts")]
        public virtual Supplier Supplier { get; set; }

        public virtual ICollection<Item> Items { get; set; }
    }
}
