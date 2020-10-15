using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Noio.Inex.Entities.ComplexType;

namespace Noio.Inex.Business.Abstract
{
    public interface IComplexGameCountryService
    {
        List<ComplexGameCountry> GetAllComplexGameCountry();
        ComplexGameCountry AddComplexGameCountry(ComplexGameCountry complexGameCountry);
        ComplexGameCountry UpdateComplexGameCountry(ComplexGameCountry complexGameCountry);
        //void DeleteComplexGameCountry(ComplexGameCountry complexGameCountry);
        ComplexGameCountry GetComplexGameCountryByGameId(int gameId);
    }
}
