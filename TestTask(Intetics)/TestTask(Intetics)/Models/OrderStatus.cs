using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestTask_Intetics_.Models
{
    /// <summary>
    /// Status of order.
    /// </summary>
    public class OrderStatus
    {
        /// <summary>
        /// Orders's ID.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Value of order.
        /// </summary>
        public string Value { get; set; }
        /// <summary>
        /// Orders collection of status.
        /// </summary>
        public ICollection<Order> Orders { get; set; }
        /// <summary>
        /// Default constructor.
        /// </summary>
        public OrderStatus()
        {
            Orders = new List<Order>();
        }
    }
}