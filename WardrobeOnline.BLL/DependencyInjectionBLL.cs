using Microsoft.Extensions.DependencyInjection;
using WardrobeOnline.BLL.Models;
using WardrobeOnline.BLL.Services.Implementations;
using WardrobeOnline.BLL.Services.Interfaces;
using WardrobeOnline.DAL.Entities;

namespace WardrobeOnline.BLL
{
    public static class DependencyInjectionBLL
    {
        public static void AddBusinessLayer(this IServiceCollection services, string imageServerType = "local", string imagePath="/")
        {
            services.AddTransient<ICRUDProvider<ClothDTO>, ClothProvider>();
            services.AddTransient<ICRUDProvider<PhysiqueDTO>, PhysiqueProvider>();
            services.AddTransient<ICRUDProvider<SetDTO>, SetProvider>();
            services.AddTransient<ICRUDProvider<PersonDTO>, PersonProvider>();

            services.AddTransient<IPageServiceProvider<Person>, PageProvider<Person>>();
            services.AddTransient<IPageServiceProvider<Set>, PageProvider<Set>>();
            services.AddTransient<IPageServiceProvider<Physique>, PageProvider<Physique>>();
            services.AddTransient<IPageServiceProvider<Cloth>, PageProvider<Cloth>>();

            if(imageServerType == "web")
            {
                services.AddSingleton<IImageProvider, WebImageProvider>();
            }
            else
            {
                services.AddSingleton<IImageProvider, LocalImageProvider>();
            }

            services.AddTransient<ICastHelper, CastHelper>();
            //services.AddTransient<IGeneralInfoProvider, GeneralInfoProvider>();
        }
    }
}
