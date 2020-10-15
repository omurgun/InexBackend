using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Noio.Inex.Entities.ComplexType;
using Noio.Inex.Entities.Concrete;

namespace Noio.Inex.Entities.FullData
{
    public class Data
    {
        public Game Game { get; set; }
        public GameDeveloper GameDeveloper { get; set; }
        public GameCountry GameCountry { get; set; }
        public GamePublisher GamePublisher { get; set; }
        

    }
}
