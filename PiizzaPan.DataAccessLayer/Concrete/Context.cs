using Microsoft.EntityFrameworkCore;
using Piizzapan.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiizzaPan.DataAccessLayer.Concrete
{
    public class Context:DbContext

    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source =DESKTOP-4UM3KTM;initial catalog=CasgemDbPizzaPan;integrated security=true");
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }    
        public DbSet<Discount> Discounts { get; set; }

    }
}
