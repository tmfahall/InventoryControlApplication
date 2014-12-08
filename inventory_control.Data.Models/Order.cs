using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventory_control.Data.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }

        [Required]
        public int ItemId { get; set; }

        [ForeignKey("ItemId"), InverseProperty("Orders")]
        public virtual Item Item { get; set; }

        [Required]
        public int OrderQuantity { get; set; }

        [Required]
        public string UserId { get; set; }

        [ForeignKey("UserId"), InverseProperty("Orders")]
        public virtual ApplicationUser ApplicationUser { get; set; }

        [Required]
        public int DepartmentId { get; set; }

        [ForeignKey("DepartmentId"), InverseProperty("Orders")]
        public virtual Department Department { get; set; }

        [Required]
        public bool IsComplete { get; set; }

        [Required]
        public DateTime BeginTimestamp { get; set; }

        public DateTime? CompleteTimestamp { get; set; }

        public bool UserDeleted { get; set; }
        public bool AdminConfirmDeleted { get; set; }
        public bool IsDenied { get; set; }
        public string DeniedReason { get; set; }
        public bool IsApproved { get; set; }
        public bool IsQtyModified { get; set; }
        public int OriginalQty { get; set; }
    }
}
