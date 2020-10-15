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
    public class GamePublisherManager :IGamePublisherService
    {
        private readonly IGamePublisherDal _gamePublisherDal;

        public GamePublisherManager(IGamePublisherDal gamePublisherDal)
        {
            _gamePublisherDal = gamePublisherDal;
        }

        public List<GamePublisher> GetAllGamePublisher()
        {
            return _gamePublisherDal.GetAll();
        }

        public GamePublisher AddGamePublisher(GamePublisher gamePublisher)
        {
            return _gamePublisherDal.Add(gamePublisher);
        }

        public GamePublisher UpdateGamePublisher(GamePublisher gamePublisher)
        {
            return _gamePublisherDal.Update(gamePublisher);
        }

        public void DeleteGamePublisher(GamePublisher gamePublisher)
        {
            _gamePublisherDal.Delete(gamePublisher);
        }

        public GamePublisher GetGamePublisherByPublisherId(int publisherId)
        {
            return  _gamePublisherDal.Get(x => x.Id == publisherId);
        }

        public GamePublisher GetGamePublisherByPublisherName(string publisherName)
        {
            return _gamePublisherDal.Get((x => x.PublisherName.ToLower().Contains(publisherName.ToLower())));
        }
    }
}
