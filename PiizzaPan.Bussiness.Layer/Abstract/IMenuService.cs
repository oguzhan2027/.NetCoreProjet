using Piizzapan.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiizzaPan.Bussiness.Layer.Abstract
{
    public interface IMenuService : IGenericService<Menu>
    {
        Menu TGetByID(int id);
    }
}
