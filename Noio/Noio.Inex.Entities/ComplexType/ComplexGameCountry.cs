using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Noio.Inex.Entities.Abstract;

namespace Noio.Inex.Entities.ComplexType
{
    public class ComplexGameCountry :IEntity
    {
        public int Id { get; set; }
        public int GameId { get; set; }
        public int CountryId { get; set; }
    }
}
