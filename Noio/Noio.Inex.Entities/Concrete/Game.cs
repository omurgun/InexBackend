using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Noio.Inex.Entities.Abstract;

namespace Noio.Inex.Entities.Concrete
{
    public class Game :IEntity
    {
        public int Id { get; set; }
        public string GameName { get; set; }
        public string GameSlug { get; set; }
        public string GameThumbnailUrl { get; set; }
        public string GameReleaseDate { get; set; }
    }
}
