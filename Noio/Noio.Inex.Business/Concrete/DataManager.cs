using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Noio.Inex.Business.Abstract;
using Noio.Inex.Business.DependencyResolvers.Ninject;
using Noio.Inex.Entities.ComplexType;
using Noio.Inex.Entities.FullData;

namespace Noio.Inex.Business.Concrete
{
    public class DataManager: IDataService
    {
        private readonly IGameService _gameService = InstanceFactory.GetInstance<IGameService>();
       
        public void AddData(Data data)
        {
            var games = data.Game;

            foreach (var game in games)
            {
                var isThereAnyGame = _gameService.GetGameBySlug(game.GameSlug);

                if (isThereAnyGame == null)
                {
                    var savedGame = _gameService.AddGame(game);

                }
            }
            
        }
    }
}
