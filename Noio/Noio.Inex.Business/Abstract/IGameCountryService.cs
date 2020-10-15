using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Noio.Inex.Entities.Concrete;

namespace Noio.Inex.Business.Abstract
{
    public interface IGameCountryService
    {
        List<GameCountry> GetAllGameCountry();
        GameCountry AddGameCountry(GameCountry gameCountry);
        GameCountry UpdateGameCountry(GameCountry gameCountry);
        void DeleteGameCountry(GameCountry gameCountry);
        GameCountry GetGameCountryByCountryId(int countryId);
        GameCountry GetGameCountryByCountryLocaleAndByCountryCountry(string locale,string country);
    }
}
