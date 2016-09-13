using System.Collections.Generic;

namespace TestTask_Intetics_.Models
{
    /// <summary>
    /// Car make.
    /// </summary>
    public class Make
    {
        /// <summary>
        /// Make's ID.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Name of car make.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Car models collection of make.
        /// </summary>
        public ICollection<Model> Models { get; set; }
        /// <summary>
        /// Default constructor.
        /// </summary>
        public Make()
        {
            Models=new List<Model>();
        }
    }
}