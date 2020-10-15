using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Noio.Inex.Entities.Abstract;

namespace Noio.Inex.Entities.Concrete
{
    public class GameCountry : IEntity
    {
        public int Id { get; set; }
        public string Locale { get; set; }
        public string Country { get; set; }
    }
}
