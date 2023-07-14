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
    public class EfContactDal : GenericRepository<Contact>, IContactDal
    {
        public List<Contact> GetContactBySubjectWithTesekkur()
        {
            using var context = new Context();
            var values = context.Contacts.Where(x => x.Subject == "Teşekkür").ToList();
            return values;
        }
    }
}
