using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Piizzapan.EntityLayer.Concrete;
using PiizzaPan.Bussiness.Layer.Abstract;
using PiizzaPan.Bussiness.Layer.Concrete;
using PiizzaPan.DataAccessLayer.Abstract;
using PiizzaPan.DataAccessLayer.Concrete;
using PiizzaPan.DataAccessLayer.EntityFramework;
using PiizzaPan.Presentation.Layer.Models;
using Pizzapan.DataAccessLayer.Abstract;
using Pizzapan.DataAccessLayer.EntityFramework;
using PizzaPan.BusinessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PiizzaPan.Presentation.Layer
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<Context>();
            services.AddScoped<ICategoryService, CategoryManager>();
            services.AddScoped<ICategoryDal, EfCategoryDal>();

            services.AddScoped<IProductService, ProductManager>();
            services.AddScoped<IProductDal, EfProductDal>();

            services.AddScoped<IContactService, ContactManager>();
            services.AddScoped<IContactDal, EfContactDal>();

            services.AddScoped<IDiscountService, DiscountManager>();
            services.AddScoped<IDiscountDal, EfDiscountDal>();

            
            services.AddScoped<IProductImageService, ProductImageManager>();
            services.AddScoped<IProductImageDal, EfProductImageDal>();

            services.AddScoped<ITestimonialService, TestimonialManager>();
            services.AddScoped<ITestimonialDal, EfTestimonialDal>();

            services.AddScoped<IOurTeamService, OurTeamManager>();
            services.AddScoped<IOurTeamDal, EfOurTeamDal>();

		

            services.AddScoped<IContactUsService, ContactUsManager>();
            services.AddScoped<IContactUsDal, EfContactUsDal>();

            services.AddScoped<ISocialMadiaService, SocialMediaManager>();
            services.AddScoped<ISocialMediaDal, EfSocialMediaDal>();

            services.AddScoped<IGalleryService, GalleryManager>();
            services.AddScoped<IGalleryDal, EfGalleryDal>();


            services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<Context>().AddErrorDescriber<CustomIdentityValidator>();
            services.AddControllersWithViews();

            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            app.UseAuthentication();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
