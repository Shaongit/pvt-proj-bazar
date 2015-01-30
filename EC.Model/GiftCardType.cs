using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ECommerce.Models
{

    /// <summary>
    /// Represents a gift card type
    /// </summary>
    public enum GiftCardType
    {
        /// <summary>
        /// Virtual
        /// </summary>
        Virtual = 0,
        /// <summary>
        /// Physical
        /// </summary>
        Physical = 1,
    }
}