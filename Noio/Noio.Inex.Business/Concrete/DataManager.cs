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
        private readonly IGameDeveloperService _gameDeveloperService = InstanceFactory.GetInstance<IGameDeveloperService>();
        private readonly IGamePublisherService _gamePublisherService = InstanceFactory.GetInstance<IGamePublisherService>();
        private readonly IGameCountryService _gameCountryService = InstanceFactory.GetInstance<IGameCountryService>();

        /////complex
        private readonly IComplexGamePublisherService _complexGamePublisherService = InstanceFactory.GetInstance<IComplexGamePublisherService>();
        private readonly IComplexGameDeveloperService _complexGameDeveloperService = InstanceFactory.GetInstance<IComplexGameDeveloperService>();
        private readonly IComplexGameCountryService _complexGameCountryService = InstanceFactory.GetInstance<IComplexGameCountryService>();

        public void AddData(Data data)
        {
            var game = data.Game;
            var gameDeveloper = data.GameDeveloper;
            var gamePublisher = data.GamePublisher;
            var gameCountry = data.GameCountry;
            

            var isThereAnyGame = 
                _gameService.GetGameBySlug(game.GameSlug);


            if (isThereAnyGame == null)
            {
                var savedGame = _gameService.AddGame(game);

                if (savedGame != null)
                {

                    //ComplexCountryAdd
                    var isThereAnyGameCountry =
                        _gameCountryService.GetGameCountryByCountryLocaleAndByCountryCountry(gameCountry.Locale,
                            gameCountry.Country);

                    if (isThereAnyGameCountry == null)
                    {
                        var savedGameCountry = _gameCountryService.AddGameCountry(gameCountry);

                        if (savedGameCountry != null)
                        {
                            _complexGameCountryService.AddComplexGameCountry(new ComplexGameCountry
                            {
                                GameId = savedGame.Id,
                                CountryId = savedGameCountry.Id

                            });
                        }
                    }
                    else
                    {
                        _complexGameCountryService.AddComplexGameCountry(new ComplexGameCountry
                        {
                            GameId = savedGame.Id,
                            CountryId = isThereAnyGameCountry.Id

                        });
                    }


                    //ComplexPublisherAdd
                    var isThereAnyGamePublisher =
                        _gamePublisherService.GetGamePublisherByPublisherName(gamePublisher.PublisherName);


                    if (isThereAnyGamePublisher ==null)
                    {
                        var savedGamePublisher = _gamePublisherService.AddGamePublisher(gamePublisher);

                        if (savedGamePublisher != null)
                        {
                            _complexGamePublisherService.AddComplexGamePublisher(new ComplexGamePublisher
                            {
                                GameId = savedGame.Id,
                                PublisherId = savedGamePublisher.Id
                            });
                        }
                    }
                    else
                    {
                        _complexGamePublisherService.AddComplexGamePublisher(new ComplexGamePublisher
                        {
                            GameId = savedGame.Id,
                            PublisherId = isThereAnyGamePublisher.Id
                        });
                    }


                    //ComplexDeveloperAdd
                    var isThereAnyGameDeveloper =
                        _gameDeveloperService.GetGameDeveloperByDeveloperName(gameDeveloper.DeveloperName);

                    if (isThereAnyGameDeveloper == null)
                    {
                        var savedGameDeveloper = _gameDeveloperService.AddGameDeveloper(gameDeveloper);

                        if (savedGameDeveloper != null)
                        {
                            _complexGameDeveloperService.AddComplexGameDeveloper(new ComplexGameDeveloper
                            {
                                GameId = savedGame.Id,
                                DeveloperId = savedGameDeveloper.Id
                            });
                        }
                    }
                    else
                    {
                        _complexGameDeveloperService.AddComplexGameDeveloper(new ComplexGameDeveloper
                        {
                            GameId = savedGame.Id,
                            DeveloperId = isThereAnyGameDeveloper.Id
                        });
                    }
                    
                }
            }
        }
    }
}
