using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Noio.Inex.Entities.Concrete;

namespace Noio.Inex.Business.Abstract
{
    public interface IGameDeveloperService
    {
        List<GameDeveloper> GetAllGameDeveloper();
        GameDeveloper AddGameDeveloper(GameDeveloper gameDeveloper);
        GameDeveloper UpdateGameDeveloper(GameDeveloper gameDeveloper);
        void DeleteGameDeveloper(GameDeveloper gameDeveloper);
        GameDeveloper GetGameDeveloperByDeveloperId(int developerId);
        GameDeveloper GetGameDeveloperByDeveloperName(string developerName);

    }
}
