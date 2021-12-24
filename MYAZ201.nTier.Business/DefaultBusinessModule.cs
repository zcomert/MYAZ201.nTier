using Autofac;
using MYAZ201.nTier.Business.Interfaces;
using MYAZ201.nTier.Business.Services;
using MYAZ201.nTier.DAL.Abstract;
using MYAZ201.nTier.DAL.Concrete.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYAZ201.nTier.Business
{
    public class DefaultBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<BookService>()
                .As<IBookService>()
                .SingleInstance();

            builder.RegisterType<EfBookDal>()
                .As<IBookDal>()
                .SingleInstance();
        }
    }
}
