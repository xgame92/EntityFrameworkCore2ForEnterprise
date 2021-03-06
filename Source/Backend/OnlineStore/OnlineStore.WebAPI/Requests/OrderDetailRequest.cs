﻿namespace OnlineStore.WebAPI.Requests
{
    /// <summary>
    /// Represents one line for Order
    /// </summary>
    public class OrderDetailRequest
    {
        /// <summary>
        /// Product ID
        /// </summary>
        public int? ProductID { get; set; }

        /// <summary>
        /// Unit price
        /// </summary>
        public decimal? UnitPrice { get; set; }

        /// <summary>
        /// Quantity
        /// </summary>
        public int? Quantity { get; set; }
    }
}
