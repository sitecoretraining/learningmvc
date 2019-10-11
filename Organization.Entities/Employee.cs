using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organization.Entities
{
    /// <summary>
    /// Class to define Employee infomration.
    /// </summary>
    public class Employee
    {
        /// <summary>
        /// Property to define id of employee in organization
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Property to define Name of employee in organization
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Property to define Role of employee in organization
        /// </summary>
        public string Role { get; set; }
        /// <summary>
        /// Property to define skills of employee 
        /// </summary>
        public List<string> Skills { get; set; }
        /// <summary>
        /// Property to define Date of Joining of employee with organization
        /// </summary>
        public DateTime JoiningDate { get; set; }

        /// <summary>
        /// Property to define status of employee with organization
        /// </summary>
        public bool IsActive { get; set; }
    }
}
