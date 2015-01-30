using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Bazar.Models
{
    public class Order
    {
        public Order()
        {
            CreatedDate = DateTime.Now;
            UpdatedDate = DateTime.Now;
        }

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        /// <summary>
        /// Gets or sets the date and time of product creation
        /// </summary>
        public DateTime CreatedDate { get; set; }
        /// <summary>
        /// Gets or sets the date and time of product update
        /// </summary>
        public DateTime? UpdatedDate { get; set; }
        public long ProductId { get; set; }
        [ForeignKey("ProductId")]
        public virtual Product Product { get; set; }
        public decimal Quantity { get; set; }

        public decimal TotalPrice { get; set; }

        public long ShoppingCartItemId { get; set; }

        public bool IsCancelled { get; set; }

        public bool IsDelivered { get; set; }

        public DateTime? DeliveredDate { get; set; }

        [MaxLength(200)]
        public string Comments { get; set; }
    }
}