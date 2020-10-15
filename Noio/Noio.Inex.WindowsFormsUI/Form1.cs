using Noio.Inex.Business.Abstract;
using Noio.Inex.Business.DependencyResolvers.Ninject;
using Noio.Inex.Entities.Concrete;
using System;
using System.Windows.Forms;
using Noio.Inex.Entities.ComplexType;

namespace Noio.Inex.WindowsFormsUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private readonly IGameService _gameService = InstanceFactory.GetInstance<IGameService>();
        private readonly IGameDeveloperService _gameDeveloperService = InstanceFactory.GetInstance<IGameDeveloperService>();
        private readonly IGamePublisherService _gamePublisherService = InstanceFactory.GetInstance<IGamePublisherService>();
        private readonly IGameCountryService _gameCountryService = InstanceFactory.GetInstance<IGameCountryService>();

        /////complex
        private readonly IComplexGamePublisherService _complexGamePublisherService = InstanceFactory.GetInstance<IComplexGamePublisherService>();
        private readonly IComplexGameDeveloperService _complexGameDeveloperService = InstanceFactory.GetInstance<IComplexGameDeveloperService>();
        private readonly IComplexGameCountryService _complexGameCountryService = InstanceFactory.GetInstance<IComplexGameCountryService>();


        private void Form1_Load(object sender, EventArgs e)
        {
            LoadGames();
            LoadCountries();
            LoadPublishers();
            LoadDevelopers();
            LoadDevelopersByAddGame();
            LoadPublishersByAddGame();
            LoadCountriesByAddGame();

        }

        private void UpdateEverything()
        {
            LoadGames();
            LoadCountries();
            LoadPublishers();
            LoadDevelopers();
            LoadDevelopersByAddGame();
            LoadPublishersByAddGame();
            LoadCountriesByAddGame();
        }
        private void LoadDevelopersByAddGame()
        {
            cbxDevelopersAdd.DataSource = _gameDeveloperService.GetAllGameDeveloper();
            cbxDevelopersAdd.DisplayMember = "DeveloperName";
            cbxDevelopersAdd.ValueMember = "Id";
        }
        private void LoadPublishersByAddGame()
        {
            cbxPublishersAdd.DataSource = _gamePublisherService.GetAllGamePublisher();
            cbxPublishersAdd.DisplayMember = "PublisherName";
            cbxPublishersAdd.ValueMember = "Id";
        }
        private void LoadCountriesByAddGame()
        {
            cbxCountriesAdd.DataSource = _gameCountryService.GetAllGameCountry();
            cbxCountriesAdd.DisplayMember = "Locale";
            cbxCountriesAdd.ValueMember = "Id";
        }

        private void btnNewGameAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var gameName = tbxGameName.Text;
                var gameSlug = tbxGameSlug.Text;
                var gameThumbnailUrl = tbxGameThumbnailUrl.Text;
                var gameReleaseDate = tbxGameReleaseDate.Text;
                var developerSelectedId = Convert.ToInt32(cbxDevelopersAdd.SelectedValue);
                var publisherSelectedId = Convert.ToInt32(cbxPublishersAdd.SelectedValue);
                var localeSelectedId = Convert.ToInt32(cbxCountriesAdd.SelectedValue);



                if (gameName == string.Empty || gameSlug == string.Empty || gameThumbnailUrl == string.Empty || gameReleaseDate == string.Empty)
                {
                    MessageBox.Show("can't be blank");
                }
                else
                {
                    var game = _gameService.GetGameBySlug(gameSlug);
                    if (game == null)
                    {
                        var savedGame = _gameService.AddGame(new Game
                        {
                            GameName = gameName,
                            GameSlug = gameSlug,
                            GameThumbnailUrl = gameThumbnailUrl,
                            GameReleaseDate = gameReleaseDate
                        });

                        if (savedGame != null)
                        {
                            _complexGameCountryService.AddComplexGameCountry(new ComplexGameCountry
                            {
                                GameId = savedGame.Id,
                                CountryId = localeSelectedId

                            });

                            _complexGameDeveloperService.AddComplexGameDeveloper(new ComplexGameDeveloper
                            {
                                GameId = savedGame.Id,
                                DeveloperId = developerSelectedId
                            });

                            _complexGamePublisherService.AddComplexGamePublisher(new ComplexGamePublisher
                            {
                                GameId = savedGame.Id,
                                PublisherId = publisherSelectedId
                            });
                        }

                        UpdateEverything();
                        MessageBox.Show("new game added.");
                    }
                    else
                    {
                        MessageBox.Show("this game has already been added");
                    }
                }



            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        private void btnNewDeveloperAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var developerName = tbxDeveloperName.Text;


                if (developerName == string.Empty)
                {
                    MessageBox.Show("can't be blank");
                }
                else
                {
                    var gameDeveloper = _gameDeveloperService.GetGameDeveloperByDeveloperName(developerName);
                    if (gameDeveloper == null)
                    {
                        _gameDeveloperService.AddGameDeveloper(new GameDeveloper
                        {
                            DeveloperName = developerName

                        });

                        LoadDevelopers();
                        MessageBox.Show("new developer added.");
                    }
                    else
                    {
                        MessageBox.Show("this developer has already been added");
                    }
                }



            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        private void btnNewPublisherAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var publisherName = tbxPublisherName.Text;

                if (publisherName == string.Empty)
                {
                    MessageBox.Show("can't be blank");
                }
                else
                {
                    var gamePublisher = _gamePublisherService.GetGamePublisherByPublisherName(publisherName);
                    if (gamePublisher == null)
                    {
                        _gamePublisherService.AddGamePublisher(new GamePublisher
                        {
                            PublisherName = publisherName

                        });

                        LoadPublishers();
                        MessageBox.Show("new publisher added.");
                    }
                    else
                    {
                        MessageBox.Show("this publisher has already been added");
                    }
                }


            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        private void btnNewCountryAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var country = tbxCountry.Text;
                var locale = tbxLocale.Text;
                if (country == string.Empty || locale == string.Empty)
                {
                    MessageBox.Show("can't be blank");
                }
                else
                {
                    var gameCountry = _gameCountryService.GetGameCountryByCountryLocaleAndByCountryCountry(locale, country);
                    if (gameCountry == null)
                    {
                        _gameCountryService.AddGameCountry(new GameCountry
                        {
                            Locale = locale,
                            Country = country

                        });

                        LoadCountries();
                        MessageBox.Show("new country added.");
                    }
                    else
                    {
                        MessageBox.Show("this country has already been added");
                    }
                }


            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void LoadGames()
        {
            dgwGames.DataSource = _gameService.GetAllGames();

        }
        private void LoadDevelopers()
        {
            dgwDevelopers.DataSource = _gameDeveloperService.GetAllGameDeveloper();

        }
        private void LoadPublishers()
        {
            dgwPublishers.DataSource = _gamePublisherService.GetAllGamePublisher();

        }
        private void LoadCountries()
        {
            dgwCountries.DataSource = _gameCountryService.GetAllGameCountry();

        }


    }
}
