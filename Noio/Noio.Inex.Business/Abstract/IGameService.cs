using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Noio.Inex.Entities.Concrete;

namespace Noio.Inex.Business.Abstract
{
    public interface IGameService
    {
        List<Game> GetAllGames();
        //List<Game> GetGamesByDeveloperId(int developerId);
        Game AddGame(Game game);
        Game UpdateGame(Game game);
        void DeleteGame(Game game);
        Game GetGameBySlug(string slug);
    }
}
