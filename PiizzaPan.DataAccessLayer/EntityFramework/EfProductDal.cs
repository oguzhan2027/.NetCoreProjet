using Microsoft.EntityFrameworkCore;
using Piizzapan.EntityLayer.Concrete;
using PiizzaPan.DataAccessLayer.Abstract;
using PiizzaPan.DataAccessLayer.Concrete;
using PiizzaPan.DataAccessLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiizzaPan.DataAccessLayer.EntityFramework
{
    public class EfProductDal:GenericRepository<Product>,IProductDal
    {
        public List<Product> GetProductsWithCategory()
        {
            using var context = new Context();
            return context.Products.Include(x => x.Category).ToList();
        }
    }
}
