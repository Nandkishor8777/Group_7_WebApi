using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Group_7_WebApi.Model;
namespace Group_7_WebApi.Repository
{
   public interface IEmployee_Repo
    {
        List<EmployeeInfo_DB> ShowAll();

        int Insert(EmployeeInfo_DB employeeInfo_DB);
        int Delete(int? id);
        int Update(int? id,EmployeeInfo employeeInfo);

    }
}
