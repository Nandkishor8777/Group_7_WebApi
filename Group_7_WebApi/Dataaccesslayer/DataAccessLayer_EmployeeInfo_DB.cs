using Group_7_WebApi.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Group_7_WebApi.Dataaccesslayer
{
    public class DataAccessLayer_EmployeeInfo_DB : DbContext
    {
        public DataAccessLayer_EmployeeInfo_DB(DbContextOptions<DataAccessLayer_EmployeeInfo_DB>options) : base(options)
        {


        }
        public DbSet<EmployeeInfo_DB> employeeInfo_DBs { get; set; }
    }
}
