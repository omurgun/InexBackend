﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Noio.Inex.DataAccess.Abstract;
using Noio.Inex.Entities.Concrete;

namespace Noio.Inex.DataAccess.Concrete.EntityFramework
{
    public class EfGameCountryDal: EfEntityRepositoryBase<GameCountry, InexDbContext>, IGameCountryDal
    {

    }
}
