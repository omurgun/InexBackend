using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Noio.Inex.Entities.ComplexType;

namespace Noio.Inex.Business.Abstract
{
    public interface IComplexGameDeveloperService
    {
        List<ComplexGameDeveloper> GetAllComplexGameDeveloper();
        ComplexGameDeveloper AddComplexGameDeveloper(ComplexGameDeveloper complexGameDeveloper);
        ComplexGameDeveloper UpdateComplexGameDeveloper(ComplexGameDeveloper complexGameDeveloper);
        //void DeleteComplexGameDeveloper(ComplexGameDeveloper complexGameDeveloper);
        ComplexGameDeveloper GetComplexGameDeveloperByGameId(int gameId);
    }
}
