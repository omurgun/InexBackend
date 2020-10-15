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
    public class GameDeveloperManager :IGameDeveloperService
    {
        private readonly IGameDeveloperDal _gameDeveloperDal;

        public GameDeveloperManager(IGameDeveloperDal gameDeveloperDal)
        {
            _gameDeveloperDal = gameDeveloperDal;
        }

        public List<GameDeveloper> GetAllGameDeveloper()
        {
            return _gameDeveloperDal.GetAll();
        }

        public GameDeveloper AddGameDeveloper(GameDeveloper gameDeveloper)
        {
           return _gameDeveloperDal.Add(gameDeveloper);
        }

        public GameDeveloper UpdateGameDeveloper(GameDeveloper gameDeveloper)
        {
            return _gameDeveloperDal.Update(gameDeveloper);
        }

        public void DeleteGameDeveloper(GameDeveloper gameDeveloper)
        {
            _gameDeveloperDal.Delete(gameDeveloper);
        }

        public GameDeveloper GetGameDeveloperByDeveloperId(int developerId)
        {
            return _gameDeveloperDal.Get(x => x.Id == developerId);
        }

        public GameDeveloper GetGameDeveloperByDeveloperName(string developerName)
        {
           return _gameDeveloperDal.Get(x => x.DeveloperName.ToLower().Contains(developerName.ToLower()));
        }
    }
}
