using dz.MatchingAndVerify.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz.MatchingAndVerify.Core.Interfaces.Repositories
{
    public interface IRepository<T> where T:BaseEntity
    {
        T GetById(int id);
        IEnumerable<T> GetAll();

        T Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
