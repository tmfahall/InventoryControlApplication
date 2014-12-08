using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventory_control.Data.Models
{
    public class Item
    {
        [Key]
        public int ItemId { get; set; }

        [Required]
        public string ItemName { get; set; }

        [Required]
        public int SupplierId { get; set; }

        [ForeignKey("SupplierId"), InverseProperty("Items")]
        public virtual Supplier Supplier { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public int MinQuantity { get; set; }

        [Required]
        public int MaxQuantity { get; set; }

        [Required]
        public int QuantityPerPallet { get; set; }

        [Required]
        public int QuantityInStock { get; set; }

        [Required]
        public int SupplierPartId { get; set; }

        [ForeignKey("SupplierPartId"), InverseProperty("Items")]
        public virtual SupplierPart SupplierPart { get; set; }
        
        [Required]
        public string BarCode { get; set; }

        public bool IsDeleted { get; set; }

        public virtual ICollection<Order> Orders { get; set; }

        public virtual ICollection<ItemLocationXref> ItemLocationXrefs { get; set; }
        public bool ThreshHoldEmailSent { get; set; }

    }
}
