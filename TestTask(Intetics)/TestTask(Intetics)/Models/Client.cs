using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TestTask_Intetics_.Models
{
    /// <summary>
    /// Client's card.
    /// </summary>
    public class Client
    {
        /// <summary>
        /// Client's ID.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Name of client.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Surname of client.
        /// </summary>
        public string Surname { get; set; }
        /// <summary>
        /// Date of birth of client.
        /// </summary>
        public DateTime DateOfBirth { get; set; }
        /// <summary>
        /// Address of client.
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// Phone number of client.
        /// </summary>
        public string Phone { get; set; }
        /// <summary>
        /// E-mail address of client.
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// Cars collection of client.
        /// </summary>
        public ICollection<Car> Cars { get; set; }
        /// <summary>
        /// Default constructor.
        /// </summary>
        public Client()
        {
            Cars = new List<Car>();
        }
    }
}