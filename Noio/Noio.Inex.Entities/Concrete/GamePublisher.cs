﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Noio.Inex.Entities.Abstract;

namespace Noio.Inex.Entities.Concrete
{
    public class GamePublisher : IEntity
    {
        public int Id { get; set; }
        public string PublisherName { get; set; }
    }
}
