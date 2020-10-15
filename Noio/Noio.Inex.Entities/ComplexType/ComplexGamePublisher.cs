using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Noio.Inex.Entities.Abstract;

namespace Noio.Inex.Entities.ComplexType
{
    public class ComplexGamePublisher:IEntity
    {
        public int Id { get; set; }
        public int GameId { get; set; }
        public int PublisherId { get; set; }
    }
}
