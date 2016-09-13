using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestTask_Intetics_.Models
{
    /// <summary>
    /// Order of service station.
    /// </summary>
    public class Order
    {
        /// <summary>
        /// Orders's ID.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Date of order.
        /// </summary>
        public DateTime Date { get; set; }
        /// <summary>
        /// Amount of order.
        /// </summary>
        public double Amount { get; set; }
        /// <summary>
        /// Car's ID.
        /// </summary>
        public int CarId { get; set; }
        /// <summary>
        /// Car.
        /// </summary>
        public Car Car { get; set; }
        /// <summary>
        /// Order status's ID.
        /// </summary>
        public int OrderStatusId { get; set; }
        /// <summary>
        /// Order status.
        /// </summary>
        public OrderStatus OrderStatus { get; set; }
    }
}