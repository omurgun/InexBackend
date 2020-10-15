using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Noio.Inex.Entities.Concrete;
using Noio.Inex.Entities.ComplexType;

namespace Noio.Inex.DataAccess.Concrete.EntityFramework
{
    public class InexDbContext :DbContext
    {
        public DbSet<Game> Games { get; set; }
        public DbSet<GameCountry> GameCountries { get; set; }
        public DbSet<GameDeveloper> GameDevelopers { get; set; }
        public DbSet<GamePublisher> GamePublishers { get; set; }

        //////complex
        public DbSet<ComplexGamePublisher> ComplexGamePublisher { get; set; }
        public DbSet<ComplexGameDeveloper> ComplexGameDeveloper { get; set; }
        public DbSet<ComplexGameCountry> ComplexGameCountry { get; set; }

    }
}
