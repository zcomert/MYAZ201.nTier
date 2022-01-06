using Autofac;
using Autofac.Extras.DynamicProxy;
using Castle.DynamicProxy;
using MYAZ201.nTier.Business.Interfaces;
using MYAZ201.nTier.Business.Services;
using MYAZ201.nTier.Business.Utilities.Interceptors;
using MYAZ201.nTier.DAL.Abstract;
using MYAZ201.nTier.DAL.Concrete.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MYAZ201.nTier.Business
{
    public class DefaultBusinessModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {

            var assembly = Assembly.GetExecutingAssembly();

            var proxyOptions = new ProxyGenerationOptions
            {
                Selector = new AspectInterceptorSelector()
            };

            builder.RegisterType<BookService>()
                .As<IBookService>()
                .SingleInstance();

            builder.RegisterType<EfBookDal>()
                .As<IBookDal>()
                .SingleInstance();

            builder.RegisterAssemblyTypes(assembly)
                .AsImplementedInterfaces()
               .EnableInterfaceInterceptors(proxyOptions)
               .SingleInstance()
               .InstancePerDependency();
        }
    }
}
