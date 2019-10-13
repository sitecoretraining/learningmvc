using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organization.Data
{
    /// <summary>
    /// 
    /// </summary>
    public interface IDataManager
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="employeeId"></param>
        /// <returns></returns>
        Employee GetEmployeeInformation(int employeeId);
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        IEnumerable<Employee> GetListEmployeesInformation();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="employeeId"></param>
        /// <returns></returns>
        IEnumerable<Skill> GetListofEmployeeSkills(int employeeId);
    }
}
