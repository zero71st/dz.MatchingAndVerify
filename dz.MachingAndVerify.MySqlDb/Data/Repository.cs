using dz.MatchingAndVerify.Core.Entities;
using dz.MatchingAndVerify.Core.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz.MachingAndVerify.MySqlDb.Data
{
    public class Repository<T>:IRepository<T> where T: BaseEntity
    {
        private readonly MatchingAndVerifyDb _db;
        
        public Repository(MatchingAndVerifyDb db)
        {
            _db = db;
        }

        public T GetById(int id)
        {
            return _db.Set<T>().Where(t => t.Id == id).FirstOrDefault();
        }

        public IEnumerable<T> GetAll()
        {
            return _db.Set<T>().AsEnumerable();
        }

        public T Add(T entity)
        {
            _db.Set<T>().Add(entity);

            _db.SaveChanges();

            return entity;
        }

        public void Update(T entity)
        {
             _db.Entry(entity).State = System.Data.Entity.EntityState.Modified;

             _db.SaveChanges();
        }

        public void Delete(T entity)
        {
            _db.Set<T>().Remove(entity);

            _db.SaveChanges();
        }
    }
}
