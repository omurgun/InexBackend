using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Noio.Inex.Business.Abstract;
using Noio.Inex.DataAccess.Abstract;
using Noio.Inex.Entities.ComplexType;

namespace Noio.Inex.Business.Concrete
{
    public class ComplexGamePublisherManager: IComplexGamePublisherService
    {

        private readonly IComplexGamePublisherDal _complexGamePublisherDal;

        public ComplexGamePublisherManager(IComplexGamePublisherDal complexGamePublisherDal)
        {
            _complexGamePublisherDal = complexGamePublisherDal;
        }


        public List<ComplexGamePublisher> GetAllComplexGamePublisher()
        {
            return _complexGamePublisherDal.GetAll();
        }

        public ComplexGamePublisher AddComplexGamePublisher(ComplexGamePublisher complexGamePublisher)
        {
            return _complexGamePublisherDal.Add(complexGamePublisher);
        }

        public ComplexGamePublisher UpdateComplexGamePublisher(ComplexGamePublisher complexGamePublisher)
        {
            return _complexGamePublisherDal.Update(complexGamePublisher);
        }

        public ComplexGamePublisher GetComplexGamePublisherByGameId(int gameId)
        {
            return _complexGamePublisherDal.Get(x => x.GameId == gameId);
        }
    }
}
