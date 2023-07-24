using Piizzapan.EntityLayer.Concrete;
using PiizzaPan.DataAccessLayer.Abstract;
using PiizzaPan.DataAccessLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiizzaPan.DataAccessLayer.EntityFramework
{
    public  class EfContactUsDal : GenericRepository<ContactUs>, IContactUsDal
    {
    }
}
