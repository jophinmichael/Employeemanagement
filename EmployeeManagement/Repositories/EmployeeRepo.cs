using EmployeeManagement.Contracts;
using EmployeeManagement.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Repositories
{
    public class EmployeeRepo : IEmployee
    {
        DBContext _db;
        public EmployeeRepo(DBContext db)
        {
            _db = db;
        }
        public bool Create(Employee entity)
        {
            _db.Employees.Add(entity);
            return Save();
        }

        public bool Delete(Employee entity)
        {
            _db.Employees.Remove(entity);
            return Save();
        }

        public Employee FindById(int Id)
        {
            var Trip = _db.Employees.FirstOrDefault(x => x.Id == Id);
            return Trip;
        }

        public ICollection<Employee> Get()
        {
            return _db.Employees.ToList();
        }

        public bool Save()
        {
            int result = _db.SaveChanges();
            return result > 0;
        }

        public bool Update(Employee entity)
        {
            _db.Employees.Update(entity);
            return Save();
        }
    }
}
