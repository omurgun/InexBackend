using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Noio.Inex.Entities.ComplexType;

namespace Noio.Inex.Business.Abstract
{
    public interface IComplexGamePublisherService
    {
        List<ComplexGamePublisher> GetAllComplexGamePublisher();
        ComplexGamePublisher AddComplexGamePublisher(ComplexGamePublisher complexGamePublisher);
        ComplexGamePublisher UpdateComplexGamePublisher(ComplexGamePublisher complexGamePublisher);
        //void DeleteComplexGamePublisher(ComplexGamePublisher complexGamePublisher);
        ComplexGamePublisher GetComplexGamePublisherByGameId(int gameId);
    }
}
