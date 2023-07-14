using Piizzapan.EntityLayer.Concrete;
using PiizzaPan.DataAccessLayer.Repositories;
using Pizzapan.DataAccessLayer.Abstract;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzapan.DataAccessLayer.EntityFramework
{
    public class EfDiscountDal : GenericRepository<Discount>, IDiscountDal
    {
    }
}