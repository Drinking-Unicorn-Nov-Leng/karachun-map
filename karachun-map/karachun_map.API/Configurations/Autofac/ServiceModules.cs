using Autofac;
using AutoMapper;
using Divergic.Configuration.Autofac;
using karachun_map.API.Configurations.AutoMapper;
using karachun_map.BI.Options;
using System;
using karachun_map.BI.Interfaces;
using karachun_map.BI.Services;

namespace karachun_map.API.Configurations.Autofac
{
    public class ServiceModules : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);

            builder.RegisterType<Places>()
                .As<IAdmin>();

            builder.RegisterType<Places>()
                .As<IPlaces>();

            builder.RegisterType<Places>()
                .As<IPlaceGeocoding>();

            builder.RegisterType<Tours>()
                .As<ITours>();

            builder.RegisterType<DataSend>()
                .As<IDataSend>();

            builder.RegisterType<Attachments>()
                .As<IAttachments>();

            builder.RegisterType<Geocoding>()
                .As<IGeocoding>();

            builder.RegisterType<FormatterFileToAttachment>();

            builder.Register(context => new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<AutoMapperProfile>();
            }
            )).AsSelf().SingleInstance();

            builder.Register(c =>
            {
                var context = c.Resolve<IComponentContext>();
                var config = context.Resolve<MapperConfiguration>();
                return config.CreateMapper(context.Resolve);
            })
            .As<IMapper>()
            .InstancePerLifetimeScope();

            var env = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");

            var resolver = new EnvironmentJsonResolver<Config>("appsettings.json", $"appsettings.{env}.json");
            var module = new ConfigurationModule(resolver);

            builder.RegisterModule(module);
        }
    }
}
