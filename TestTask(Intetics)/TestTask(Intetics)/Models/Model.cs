using System.Collections.Generic;

namespace TestTask_Intetics_.Models
{
    /// <summary>
    /// Car model.
    /// </summary>
    public class Model
    {
        /// <summary>
        /// Car model's ID.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Name of car model.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Make's ID.
        /// </summary>
        public int MakeId { get; set; }
        /// <summary>
        /// Make.
        /// </summary>
        public Make Make { get; set; }
        /// <summary>
        /// Car collection of car.
        /// </summary>
        public ICollection<Car> Car { get; set; }
        /// <summary>
        /// Default constructor.
        /// </summary>
        public Model()
        {
            Car = new List<Car>();
        }
    }
}