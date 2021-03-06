﻿using EC.Model;
using System;
using System.Collections.Generic;
using System.Collections
;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EC.Model
{
    public class Product
    {
        public Product()
        {
            CreatedDate = DateTime.Now;
            UpdatedDate = DateTime.Now;
        }
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [Required]
        public string Name { get; set; }
        /// <summary>
        /// Gets or sets the short description
        /// </summary>
        /// 

        public int CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }

        public string ShortDescription { get; set; }

        [Display(Name = "Full Description")]
        /// <summary>
        /// Gets or sets the full description
        /// </summary>
        public string FullDescription { get; set; }

        /// <summary>
        /// Gets or sets the admin comment
        /// </summary>
        public string AdminComment { get; set; }

        /// <summary>
        /// Gets or sets a vendor identifier
        /// </summary>
<<<<<<< HEAD
        [Display(Name = "Vendor Name")]
=======
        [Display(Name="Vendor Name")]
>>>>>>> c18da64b9c984434999b17336f05b0317cc40bb7
        public int? VendorId { get; set; }
        [ForeignKey("VendorId")]
        public Vendor Vendor { get; set; }


        /// <summary>
        /// Gets or sets a value indicating whether to show the product on home page
        /// </summary>
        public bool ShowOnHomePage { get; set; }

        /// <summary>
        /// Gets or sets the meta keywords
        /// </summary>
        [Display(Name = "Meta Keywords")]
        public string MetaKeywords { get; set; }
        /// <summary>
        /// Gets or sets the meta description
        /// </summary>
        public string MetaDescription { get; set; }
        /// <summary>
        /// Gets or sets the meta title
        /// </summary>
        [Display(Name = "Meta Title")]
        public string MetaTitle { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the product allows customer reviews
        /// </summary>
        public bool AllowCustomerReviews { get; set; }

        /// <summary>
        /// Gets or sets the SKU
        /// </summary>
        public string Sku { get; set; }
        /// <summary>
        /// Gets or sets the manufacturer part number
        /// </summary>
        public string ManufacturerPartNumber { get; set; }
        /// <summary>
        /// Gets or sets the Global Trade Item Number (GTIN). These identifiers include UPC (in North America), EAN (in Europe), JAN (in Japan), and ISBN (for books).
        /// </summary>
        public string Gtin { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the product is gift card
        /// </summary>
        public bool IsGiftCard { get; set; }
        public bool IsShipEnabled { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether the entity is free shipping
        /// </summary>
        public bool IsFreeShipping { get; set; }
        /// <summary>
        /// Gets or sets a value this product should be shipped separately (each item)
        /// </summary>
        public bool ShipSeparately { get; set; }
        /// <summary>
        /// Gets or sets the additional shipping charge
        /// </summary>
        public decimal? AdditionalShippingCharge { get; set; }
        /// <summary>
        /// Gets or sets a delivery date identifier
        /// </summary>
        public int? DeliveryDateId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the product is marked as tax exempt
        /// </summary>
        [Display(Name = "Stock Quantity")]
        public int StockQuantity { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether to display stock availability
        /// </summary>
        public bool DisplayStockAvailability { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether to display stock quantity
        /// </summary>
        public bool DisplayStockQuantity { get; set; }
        /// <summary>
        /// Gets or sets the minimum stock quantity
        /// </summary>
        public int? MinStockQuantity { get; set; }
        /// <summary>
        /// Gets or sets the low stock activity identifier
        /// </summary>
        [Display(Name = "Unit Price")]
        public decimal UnitPrice { get; set; }
        /// <summary>
        /// Gets or sets the old price
        /// </summary>
        public decimal? OldPrice { get; set; }
        /// <summary>
        /// Gets or sets the product special price

        [Range(1, 100)]
        [DataType(DataType.Currency)]/// </summary>
        public decimal? SpecialPrice { get; set; }
        /// <summary>
        /// Gets or sets the start date and time of the special price
        /// </summary>
        public DateTime? SpecialPriceStartDateTimeUtc { get; set; }
        /// <summary>
        /// Gets or sets the end date and time of the special price
        /// </summary>
        public DateTime? SpecialPriceEndDateTimeUtc { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether a customer enters price
        /// </summary>
        public bool HasDiscountsApplied { get; set; }

        //[Range(1, 100)]
        [DataType(DataType.Currency)]
        [RegularExpression(@"^[0-9]{0,15}$", ErrorMessage = "Book Quantity should contain only numbers")]
        [Display(Name = "Book Quantity")]
        public decimal? BookQty { get; set; }

        [DataType(DataType.Currency)]
        [RegularExpression(@"^[0-9]{0,15}$", ErrorMessage = "Lock Quantity should contain only numbers")]
        [Display(Name = "Lock Quantity")]
        public decimal? LockQty { get; set; }
        /// <summary>
        /// Gets or sets the weight
        /// </summary>
        public decimal? Weight { get; set; }
        /// <summary>
        /// Gets or sets the length
        /// </summary>
        public decimal? Length { get; set; }
        /// <summary>
        /// Gets or sets the width
        /// </summary>
        public decimal? Width { get; set; }
        /// <summary>
        /// Gets or sets the height
        /// </summary>
        public decimal? Height { get; set; }

        [Display(Name = "Active")]
        public bool IsActive { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the entity is published
        /// </summary>
        /// 
        [Display(Name = "Published")]
        public bool Published { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether the entity has been deleted
        /// </summary>
        public bool Deleted { get; set; }

        /// <summary>
        /// Gets or sets the date and time of product creation
        /// </summary>
        public DateTime CreatedDate { get; set; }
        /// <summary>
        /// Gets or sets the date and time of product update
        /// </summary>
        public DateTime? UpdatedDate { get; set; }

        public long? UserId { get; set; }

        public virtual ICollection<ProductImage> ProductImages { get; set; }

        public int StaticItemDetId { get; set; }

        public virtual List<StaticItemDet> StaticItemDets { get; set; }
        [NotMapped]
        public string ImagePaths { get; set; }

    }
}