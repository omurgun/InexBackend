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
    public class ComplexGameCountryManager: IComplexGameCountryService
    {

        private readonly IComplexGameCountryDal _complexGameCountryDal;

        public ComplexGameCountryManager(IComplexGameCountryDal complexGameCountryDal)
        {
            _complexGameCountryDal = complexGameCountryDal;
        }
        public List<ComplexGameCountry> GetAllComplexGameCountry()
        {
            return _complexGameCountryDal.GetAll();
        }

        public ComplexGameCountry AddComplexGameCountry(ComplexGameCountry complexGameCountry)
        {
            return _complexGameCountryDal.Add(complexGameCountry);
        }

        public ComplexGameCountry UpdateComplexGameCountry(ComplexGameCountry complexGameCountry)
        {
            return _complexGameCountryDal.Update(complexGameCountry);
        }

        public ComplexGameCountry GetComplexGameCountryByGameId(int gameId)
        {
            return _complexGameCountryDal.Get(x => x.GameId == gameId);
        }
    }
}
