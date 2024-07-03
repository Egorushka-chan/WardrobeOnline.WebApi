using Microsoft.Extensions.DependencyInjection;
using WardrobeOnline.BLL.Models;
using WardrobeOnline.BLL.Models.Interfaces;
using WardrobeOnline.BLL.Repository.Implementations;
using WardrobeOnline.BLL.Repository.Interfaces;
using WardrobeOnline.DAL.Entities;

namespace WardrobeOnline.BLL
{
    public static class DependencyInjectionBLL
    {
        public static void AddBusinessLayer(this IServiceCollection services, string imageServerType = "local", string imagePath="/")
        {
            services.AddTransient<IEntityProvider<ClothDTO>, ClothProvider>();
            services.AddTransient<IEntityProvider<ComplectionDTO>, ComplectionProvider>();
            services.AddTransient<IEntityProvider<SetDTO>, SetProvider>();
            services.AddTransient<IEntityProvider<PersonDTO>, PersonProvider>();

            services.AddTransient<IPageServiceProvider<Person>, PageProvider<Person>>();
            services.AddTransient<IPageServiceProvider<Set>, PageProvider<Set>>();
            services.AddTransient<IPageServiceProvider<Complection>, PageProvider<Complection>>();
            services.AddTransient<IPageServiceProvider<Cloth>, PageProvider<Cloth>>();

            if(imageServerType == "web")
            {
                services.AddSingleton<IImageProvider, WebImageProvider>();
            }
            else
            {
                services.AddSingleton<IImageProvider, LocalImageProvider>();
            }

            services.AddTransient<ITranslator, Translator>();
            services.AddTransient<IGeneralInfoProvider, GeneralInfoProvider>();
        }
    }
}
