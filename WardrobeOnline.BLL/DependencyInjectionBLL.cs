using Microsoft.Extensions.DependencyInjection;
using WardrobeOnline.BLL.Models;
using WardrobeOnline.BLL.Models.Interfaces;
using WardrobeOnline.BLL.Services.Implementations;
using WardrobeOnline.BLL.Services.Implementations.CRUD;
using WardrobeOnline.BLL.Services.Implementations.Pagination;
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

            services.ConfigureValidationLayer<ClothDTO>();
            services.ConfigureValidationLayer<PhysiqueDTO>();
            services.ConfigureValidationLayer<SetDTO>();
            services.ConfigureValidationLayer<PersonDTO>();

            services.AddTransient<IPaginationService<Person>, GeneralPageService<Person>>();
            services.AddTransient<IPaginationService<Set>, GeneralPageService<Set>>();
            services.AddTransient<IPaginationService<Physique>, GeneralPageService<Physique>>();
            services.AddTransient<IPaginationService<Cloth>, GeneralPageService<Cloth>>();

            if(imageServerType == "web")
            {
                services.AddSingleton<IImageProvider, WebImageProvider>();
            }
            else
            {
                services.AddSingleton<IImageProvider, LocalImageProvider>();
            }

            services.AddTransient<ICastHelper, CastHelper>();

            services.AddStackExchangeRedisCache(opt =>
            {
                opt.Configuration = "localhost";
                opt.InstanceName = "local";
            });

            services.AddScoped<IGeneralInfoProvider, GeneralInfoProvider>();
            
        }

        private static void ConfigureValidationLayer<TEntityDTO>(this IServiceCollection services) where TEntityDTO : class, IEntityDTO
        {
            services.AddTransient<IValidationLayer<TEntityDTO>, ValidationLayer<TEntityDTO>>();
        }
    }

}
