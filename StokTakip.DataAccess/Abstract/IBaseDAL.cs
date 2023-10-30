using StokTakip.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip.DataAccess.Abstract
{
    public interface IBaseDAL<TEntity> where TEntity : BaseEntity
    {
        int Add(TEntity entity);
        int Update(TEntity entity);
        int Delete(TEntity entity);
        List<TEntity> GetAll();
        List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter);
        TEntity Get(Expression<Func<TEntity, bool>> filter);
        TEntity GetById(int id);
    }
}
