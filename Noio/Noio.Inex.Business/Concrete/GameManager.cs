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
    public class GameManager :IGameService
    {
        private readonly IGameDal _gameDal;

        public GameManager(IGameDal gameDal)
        {
            _gameDal = gameDal;
        }

        public List<Game> GetAllGames()
        {
            return _gameDal.GetAll();
        }

        public Game AddGame(Game game)
        {
            return _gameDal.Add(game);
        }

        public Game UpdateGame(Game game)
        {
            return _gameDal.Update(game);
        }

        public void DeleteGame(Game game)
        {
            _gameDal.Delete(game);
        }

        public Game GetGameBySlug(string slug)
        {
            return _gameDal.Get(x => x.GameSlug.ToLower().Contains(slug.ToLower()));
        }
    }
}
