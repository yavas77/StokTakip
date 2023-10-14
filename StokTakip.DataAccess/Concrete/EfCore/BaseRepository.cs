using StokTakip.DataAccess.Abstract;
using StokTakip.DataAccess.Concrete.Contexts;
using StokTakip.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip.DataAccess.Concrete.EfCore
{
    public class BaseRepository<TEntity> : IBaseDAL<TEntity> where TEntity : class
    {
        private readonly StokTakipDbContext _context;

        public BaseRepository(StokTakipDbContext context)
        {
            _context = context;
        }

        public int Add(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
            return _context.SaveChanges();
        }

        public int Update(TEntity entity)
        {
            _context.Set<TEntity>().Update(entity);
            return _context.SaveChanges();
        }

        public int Delete(TEntity entity)
        {
            _context.Set<TEntity>().Remove(entity);
            return _context.SaveChanges();
        }

        public List<TEntity> GetAll()
        {
            return _context.Set<TEntity>().ToList();
        }
    }
}
