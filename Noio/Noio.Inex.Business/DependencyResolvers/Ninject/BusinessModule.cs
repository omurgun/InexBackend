using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject.Modules;
using Noio.Inex.Business.Abstract;
using Noio.Inex.Business.Concrete;
using Noio.Inex.DataAccess.Abstract;
using Noio.Inex.DataAccess.Concrete.EntityFramework;

namespace Noio.Inex.Business.DependencyResolvers.Ninject
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IGameService>().To<GameManager>();
            Bind<IGameDal>().To<EfGameDal>();

            Bind<IGameCountryService>().To<GameCountryManager>();
            Bind<IGameCountryDal>().To<EfGameCountryDal>();

            Bind<IGamePublisherService>().To<GamePublisherManager>();
            Bind<IGamePublisherDal>().To<EfGamePublisherDal>();

            Bind<IGameDeveloperService>().To<GameDeveloperManager>();
            Bind<IGameDeveloperDal>().To<EfGameDeveloperDal>();



            /////////// complex
            
            Bind<IComplexGamePublisherService>().To<ComplexGamePublisherManager>();
            Bind<IComplexGamePublisherDal>().To<EfComplexGamePublisherDal>();

            Bind<IComplexGameDeveloperService>().To<ComplexGameDeveloperManager>();
            Bind<IComplexGameDeveloperDal>().To<EfComplexGameDeveloperDal>();

            Bind<IComplexGameCountryService>().To<ComplexGameCountryManager>();
            Bind<IComplexGameCountryDal>().To<EfComplexGameCountryDal>();

            Bind<IDataService>().To<DataManager>();

        }
    }
}
