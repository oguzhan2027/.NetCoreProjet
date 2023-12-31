﻿using Piizzapan.EntityLayer.Concrete;
using PiizzaPan.Bussiness.Layer.Abstract;
using PiizzaPan.DataAccessLayer.Abstract;
using PiizzaPan.DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiizzaPan.Bussiness.Layer.Concrete
{
    public class ProductManager : IProductService
    {
        private readonly IProductDal _productDal;
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void TDelete(Product t)
        {
            _productDal.Delete(t);
        }

        public void TDelete(object value)
        {
            throw new NotImplementedException();
        }

        public Product TGetById(int id)
        {
            return _productDal.GetById(id);
        }

        public object TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> TGetList()
        {
            return _productDal.GetList();
        }

        public object TGetProductsWithCategory()
        {
            return _productDal.GetProductsWithCategory();
        }

        public void TInsert(Product t)
        {
            _productDal.Insert(t);
        }

        public void TUpdate(Product t)
        {
            _productDal.Update(t);
        }

        
    }
}
