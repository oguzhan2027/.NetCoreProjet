using Piizzapan.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiizzaPan.Bussiness.Layer.Abstract
{
    public interface IProductService : IGenericService<Product>
    {
        void TDelete(object value);
        object TGetByID(int id);
        object TGetProductsWithCategory();

        public interface IProductService : IGenericService<Product>
        {
            public List<Product> TGetProductsWithCategory();
        }

    }
}
