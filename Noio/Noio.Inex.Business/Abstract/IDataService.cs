using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Noio.Inex.Entities.FullData;

namespace Noio.Inex.Business.Abstract
{
    public interface IDataService
    {
        void AddData(Data data);
    }
}
