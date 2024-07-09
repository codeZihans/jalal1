using Autofac;
using DevSkill.Inventory.Application;
using DevSkill.Inventory.Application.Services;
using DevSkill.Inventory.Domain.RepositoryContracts;
using DevSkill.Inventory.Infrastructure;
using DevSkill.Inventory.Infrastructure.Repositories;
using DevSkill.Inventory.Infrastructure.UnitOfWorks;
using DevSkill.Inventory.Web.Data;
using Microsoft.DotNet.Scaffolding.Shared.Messaging;

namespace DevSkill.Inventory.Web
{
    public class WebModule(string connectionString, string migrationAssembly) : Module
    {
       
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ProductDbContext>().AsSelf().WithParameter("connectionString", connectionString).WithParameter("migrationAssembly", migrationAssembly).InstancePerLifetimeScope();

            builder.RegisterType<ApplicationDbContext>().AsSelf().WithParameter("connectionString", connectionString).WithParameter("migrationAssembly", migrationAssembly).InstancePerLifetimeScope();

            builder.RegisterType<ProductRepository>()
                .As<IProductRepository>().InstancePerLifetimeScope();


            //builder.RegisterType<MessageSender>().As<IMessageSender>().InstancePerLifetimeScope();

            builder.RegisterType<ProductUnitOfWork>()
                .As<IProductUnitOfWork>()
                .InstancePerLifetimeScope();

            builder.RegisterType<ProductManagementService>()
                .As<IProductManagementService>()
                .InstancePerLifetimeScope();
        }
    }
}