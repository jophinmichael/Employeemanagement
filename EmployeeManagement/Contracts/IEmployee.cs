using EmployeeManagement.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Contracts
{
    public interface IEmployee : IRepositoryBase<Employee>
    {
    }
}
