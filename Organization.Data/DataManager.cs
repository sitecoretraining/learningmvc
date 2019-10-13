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
    public class DataManager : IDataManager
    {
        //
        private OrganizationEntities dbContext = default(OrganizationEntities);
        /// <summary>
        /// 
        /// </summary>
        public DataManager()
        {
             dbContext = new OrganizationEntities();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="employeeId"></param>
        /// <returns></returns>
        public Employee GetEmployeeInformation(int employeeId)
        {
            return dbContext.Employees.SingleOrDefault(x => x.Id.Equals(employeeId));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Employee> GetListEmployeesInformation()
        {
            return dbContext.Employees.ToList();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="employeeId"></param>
        /// <returns></returns>
        public IEnumerable<Skill> GetListofEmployeeSkills(int employeeId)
        {
            return dbContext.Employees.Where(y => y.Id.Equals(employeeId)).SelectMany(x => x.Skills);
        }
    }
}
