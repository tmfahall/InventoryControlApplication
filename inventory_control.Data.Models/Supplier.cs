using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventory_control.Data.Models
{
    public class Supplier
    {
        [Key]
        public int SupplierId { get; set; }

        [Required]
        public string SupplierName { get; set; }

        public virtual ICollection<SupplierPart> SupplierParts { get; set; }

        public virtual ICollection<Item> Items { get; set; }

        public DateTime? CompleteTimestamp { get; set; }
    }
}
