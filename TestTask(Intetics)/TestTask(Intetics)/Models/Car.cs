using System.Collections.Generic;

namespace TestTask_Intetics_.Models
{
    /// <summary>
    /// Car.
    /// </summary>
    public class Car
    {
        /// <summary>
        /// Car's ID.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Car's year.
        /// </summary>
        public int Year { get; set; }
        /// <summary>
        /// Car's VIN.
        /// </summary>
        public string VIN { get; set; }
        /// <summary>
        /// Car model's ID.
        /// </summary>
        public int ModelId { get; set; }
        /// <summary>
        /// Car model.
        /// </summary>
        public Model Model { get; set; }
        /// <summary>
        /// Client's ID.
        /// </summary>
        public int ClientId { get; set; }
        /// <summary>
        /// Client.
        /// </summary>
        public Client Client { get; set; }
        /// <summary>
        /// Orders collection of car.
        /// </summary>
        public virtual ICollection<Order> Orders { get; set; }
        /// <summary>
        /// Default constructor.
        /// </summary>
        public Car()
        {
            Orders = new List<Order>();
        }
    }
}