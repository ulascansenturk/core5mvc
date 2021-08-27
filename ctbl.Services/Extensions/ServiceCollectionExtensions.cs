using System.Reflection.Metadata.Ecma335;
using ctbl.Data.Abstract;
using ctbl.Data.Concrete;
using ctbl.Data.Concrete.EntityFramework.Contexts;
using ctbl.Entities.Concrete;
using ctbl.Services.Abstract;
using ctbl.Services.Concrete;
using Microsoft.Extensions.DependencyInjection;

namespace ctbl.Services.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection LoadMyServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddDbContext<ctblMvcContext>();
            serviceCollection.AddScoped<IUnitOfWork,UnitOfWork>();
            serviceCollection.AddScoped<ICategoryService, CategoryManager>();
            serviceCollection.AddScoped<IArticleService, ArticleManager>();

            return serviceCollection;

        }
        

    }
}