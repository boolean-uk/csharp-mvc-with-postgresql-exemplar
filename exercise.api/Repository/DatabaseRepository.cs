using exercise.api.DataContext;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace exercise.api.Repository
{

    public class DatabaseRepository<T> : IDatabaseRepository<T> where T : class
    {
      

        private EmployeeContext _db;
        private DbSet<T> _table = null;
        public DatabaseRepository()
        {
            _db = new EmployeeContext();
            _table = _db.Set<T>();
        }
        public DatabaseRepository(EmployeeContext db)
        {
            _db = db;
            _table = _db.Set<T>();
        }

        public IEnumerable<T> Include(params Expression<Func<T, object>>[] includes)
        {
            DbSet<T> dbSet = _db.Set<T>();

            IEnumerable<T> query = null;
            foreach (var include in includes)
            {
                query = dbSet.Include(include);
            }

            return query ?? dbSet;
        }



        public IEnumerable<T> GetAll()
        {
            return _table.ToList();
        }        
        public T GetById(object id)
        {
            return _table.Find(id);
        }        
        public void Insert(T obj)
        {            
            _table.Add(obj);
        }        
        public void Update(T obj)
        {        
            _table.Attach(obj);        
            _db.Entry(obj).State = EntityState.Modified;
        }
        
        public void Delete(object id)
        {            
            T existing = _table.Find(id);            
            _table.Remove(existing);
        }        
        public void Save()
        {
            _db.SaveChanges();
        }


    }
}
