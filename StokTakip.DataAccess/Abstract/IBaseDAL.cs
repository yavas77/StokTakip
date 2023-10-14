using StokTakip.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip.DataAccess.Abstract
{
    public interface IBaseDAL<TEntity> where TEntity : class
    {
        int Add(TEntity entity);
        int Update(TEntity entity);
        int Delete(TEntity entity);
        List<TEntity> GetAll();
    }
}
