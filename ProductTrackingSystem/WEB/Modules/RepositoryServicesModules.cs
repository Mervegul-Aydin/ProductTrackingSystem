using System.Reflection;
using FluentValidation;
using Module = Autofac.Module;
using MyJeweleryShop.Core.Repositories;
using MyJeweleryShop.Core.Services;
using MyJeweleryShop.Core.UnitOfWorks;
using MyJeweleryShop.Repository.Repositories;
using Autofac;
using MyJeweleryShop.Service.Mapping;
using MyJeweleryShop.Service.Services;
using MyJeweleryShop.Repository.UnitOfWorks;

namespace MyJeweleryShop.WEB.Modules
{
    public class RepositoryServicesModules : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterGeneric(typeof(GenericRepository<>)).As(typeof(IGenericRepository<>)).InstancePerLifetimeScope();
            builder.RegisterGeneric(typeof(GenericService<>)).As(typeof(IGenericService<>)).InstancePerLifetimeScope();
            builder.RegisterType<ProductRepository>().As<IProductRepository>();
            builder.RegisterType<ProductColorsRepository>().As<IProductColorsRepository>();
            builder.RegisterType<ProductBrandsRepository>().As<IProductBrandsRepository>();
            builder.RegisterType<ProductMeasurementRepository>().As<IProductMeasurementUnitsRepository>();
            builder.RegisterType<ProductVatRepository>().As<IProductVatUnitsRepository>();
            builder.RegisterType<ProductFeaturesRepository>().As<IProductFeaturesRepository>();
       



            builder.RegisterType<CategoryRepository > ().As<ICategoryRepository>();
            builder.RegisterType<CategoryService>().As<ICategoryService>();
            builder.RegisterType<ProductColorService>().As<IProductColorsService>();
            builder.RegisterType<ProductBrandService>().As<IProductBrandsService>();
            builder.RegisterType<ProductMeasurementService>().As<IProductMeasurementUnitsService>();
            builder.RegisterType<ProductVatService>().As<IProductVatUnitsService>();
            builder.RegisterType<ProductFeaturesService>().As<IProductFeaturesService>();
       


            builder.RegisterType<UnitOfWork>().As<IGenericUnitOfWork>();

            var repository =  Assembly.GetAssembly(typeof(AppContext));
            var service = Assembly.GetAssembly(typeof(MapProfiles));
            var api = Assembly.GetExecutingAssembly();


            builder.RegisterAssemblyTypes(repository, service, api).Where(x => x.Name.EndsWith("Repository")).AsImplementedInterfaces().InstancePerLifetimeScope();

            builder.RegisterAssemblyTypes(repository, service, api).Where(x => x.Name.EndsWith("Service")).AsImplementedInterfaces().InstancePerLifetimeScope();


        }
    }
}
