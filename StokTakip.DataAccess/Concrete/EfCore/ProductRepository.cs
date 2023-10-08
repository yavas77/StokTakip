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
    public class ProductRepository : IProductDAL
    {
        private readonly StokTakipDbContext _context;
        public ProductRepository(StokTakipDbContext context)
        {
            _context = context;
        }
        public int Add(Product product)
        {
            _context.Products.Add(product);
            return _context.SaveChanges();
        }

        public int Update(Product product)
        {
            _context.Products.Update(product);
            return _context.SaveChanges();
        }

        public int Delete(Product product)
        {
            _context.Products.Remove(product);
            return _context.SaveChanges();
        }

        public List<Product> GetAll()
        {
            return _context.Products.ToList();
        }
    }
}
