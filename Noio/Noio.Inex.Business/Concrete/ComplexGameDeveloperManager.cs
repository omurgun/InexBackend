using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Noio.Inex.Business.Abstract;
using Noio.Inex.DataAccess.Abstract;
using Noio.Inex.Entities.ComplexType;

namespace Noio.Inex.Business.Concrete
{
    public class ComplexGameDeveloperManager: IComplexGameDeveloperService
    {
        private readonly IComplexGameDeveloperDal _complexGameDeveloperDal;

        public ComplexGameDeveloperManager(IComplexGameDeveloperDal complexGameDeveloperDal)
        {
            _complexGameDeveloperDal = complexGameDeveloperDal;
        }


        public List<ComplexGameDeveloper> GetAllComplexGameDeveloper()
        {
            return _complexGameDeveloperDal.GetAll();
        }

        public ComplexGameDeveloper AddComplexGameDeveloper(ComplexGameDeveloper complexGameDeveloper)
        {
            return _complexGameDeveloperDal.Add(complexGameDeveloper);
        }

        public ComplexGameDeveloper UpdateComplexGameDeveloper(ComplexGameDeveloper complexGameDeveloper)
        {
            return _complexGameDeveloperDal.Update(complexGameDeveloper);
        }

        public ComplexGameDeveloper GetComplexGameDeveloperByGameId(int gameId)
        {
            return _complexGameDeveloperDal.Get(x => x.GameId == gameId);
        }
    }
}
