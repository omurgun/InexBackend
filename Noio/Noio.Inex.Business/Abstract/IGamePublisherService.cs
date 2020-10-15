using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Noio.Inex.Entities.Concrete;

namespace Noio.Inex.Business.Abstract
{
    public interface IGamePublisherService
    {
        List<GamePublisher> GetAllGamePublisher();
        GamePublisher AddGamePublisher(GamePublisher gamePublisher);
        GamePublisher UpdateGamePublisher(GamePublisher gamePublisher);
        void DeleteGamePublisher(GamePublisher gamePublisher);
        GamePublisher GetGamePublisherByPublisherId(int publisherId);
        GamePublisher GetGamePublisherByPublisherName(string publisherName);
    }
}
