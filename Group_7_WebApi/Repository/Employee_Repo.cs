using Group_7_WebApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Group_7_WebApi.Dataaccesslayer;

namespace Group_7_WebApi.Repository
{
    public class Employee_Repo : IEmployee_Repo
    {
        private readonly DataAccessLayer_EmployeeInfo_DB dataAccessLayer_EmployeeInfo_DB;

        public Employee_Repo(DataAccessLayer_EmployeeInfo_DB dataAccessLayer_EmployeeInfo_DB)
        {
            this.dataAccessLayer_EmployeeInfo_DB = dataAccessLayer_EmployeeInfo_DB;
        }
        public List<EmployeeInfo_DB> ShowAll()
        {
            var ar = dataAccessLayer_EmployeeInfo_DB.employeeInfo_DBs.ToList();
            return ar;
          
        }
        public int Delete(int? id)
        {
            var a = dataAccessLayer_EmployeeInfo_DB.employeeInfo_DBs .FirstOrDefault(x => x.Id == id);
            if (a != null)
            {
                dataAccessLayer_EmployeeInfo_DB.employeeInfo_DBs.Remove(a);
                dataAccessLayer_EmployeeInfo_DB.SaveChanges();
            }
            return 1;
        }

        public int Insert(EmployeeInfo_DB employeeInfo)
        {
            dataAccessLayer_EmployeeInfo_DB.Add(employeeInfo);
            dataAccessLayer_EmployeeInfo_DB.SaveChanges();
            return 1;
        }
        public int Update(int? id,  EmployeeInfo empModel)
        {
            var a = dataAccessLayer_EmployeeInfo_DB.employeeInfo_DBs.FirstOrDefault(x => x.Id == id);
            if (a != null)
            {
                a.EmpName = empModel.EmpName;
                a.Age = empModel.Age;
                a.Salary = empModel.Salary;
                dataAccessLayer_EmployeeInfo_DB.SaveChanges();

            }
            return 1;
        }
    }
}
