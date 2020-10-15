using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Noio.Inex.Business.Abstract;
using Noio.Inex.DataAccess.Abstract;
using Noio.Inex.Entities.Concrete;

namespace Noio.Inex.Business.Concrete
{
    public class GameCountryManager :IGameCountryService
    {
        private readonly IGameCountryDal _gameCountryDal;

        public GameCountryManager(IGameCountryDal gameCountryDal)
        {
            _gameCountryDal = gameCountryDal;
        }

        public List<GameCountry> GetAllGameCountry()
        {
            return _gameCountryDal.GetAll();
        }

        public GameCountry AddGameCountry(GameCountry gameCountry)
        {
            return _gameCountryDal.Add(gameCountry);
        }

        public GameCountry UpdateGameCountry(GameCountry gameCountry)
        {
            return _gameCountryDal.Update(gameCountry);
        }

        public void DeleteGameCountry(GameCountry gameCountry)
        {
            _gameCountryDal.Delete(gameCountry);
        }

        public GameCountry GetGameCountryByCountryId(int countryId)
        {
            return _gameCountryDal.Get(x => x.Id == countryId);
        }

        public GameCountry GetGameCountryByCountryLocaleAndByCountryCountry(string locale, string country)
        {
            return _gameCountryDal.Get(x => x.Locale.ToLower().Contains(locale.ToLower()) & x.Country.ToLower().Contains(country.ToLower()));
        }
    }
}
