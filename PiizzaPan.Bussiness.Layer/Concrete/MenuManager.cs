using Piizzapan.EntityLayer.Concrete;
using PiizzaPan.Bussiness.Layer.Abstract;
using PiizzaPan.DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiizzaPan.Bussiness.Layer.Concrete
{
    public class MenuManager : IMenuService
    {
        private readonly IMenuDal _menuDal;

        public MenuManager(IMenuDal menuDal)
        {
            _menuDal = menuDal;
        }

        public void TDelete(Menu t)
        {
            _menuDal.Delete(t);
        }

        public Menu TGetById(int id)
        {
           return _menuDal.GetById(id);
        }

        public Menu TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Menu> TGetList()
        {
            return _menuDal.GetList();
        }

        public void TInsert(Menu t)
        {
            _menuDal.Insert(t);
        }

        public void TUpdate(Menu t)
        {
            _menuDal.Update(t);
        }
    }
}
