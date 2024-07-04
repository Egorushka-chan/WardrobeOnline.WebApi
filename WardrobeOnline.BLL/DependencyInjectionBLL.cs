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
            services.AddTransient<IEntityProvider<PhysiqueDTO>, PhysiqueProvider>();
            services.AddTransient<IEntityProvider<SetDTO>, SetProvider>();
            services.AddTransient<IEntityProvider<PersonDTO>, PersonProvider>();

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
            services.AddTransient<IGeneralInfoProvider, GeneralInfoProvider>();
        }
    }
}
