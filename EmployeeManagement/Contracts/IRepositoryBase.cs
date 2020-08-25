using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Contracts
{
    public interface IRepositoryBase<T> where T : class
    {
        T FindById(int Id);
        ICollection<T> Get();
        bool Create(T entity);
        bool Update(T entity);
        bool Delete(T entity);
        bool Save();
    }
}
