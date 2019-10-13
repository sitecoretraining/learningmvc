using Organization.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organization.Business
{
    /// <summary>
    /// 
    /// </summary>
    public class BusinessManager :IBusinessManager
    {
        private IDataManager _dataManager = default;

        public BusinessManager()
        {
            _dataManager = new DataManager(); 
        }



    }
}
