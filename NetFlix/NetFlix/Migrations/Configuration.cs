namespace NetFlix.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using NetFlix.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<NetFlix.Models.NetFlixDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(NetFlix.Models.NetFlixDbContext context)
        {
            context.Series.AddOrUpdate(s => s.Title,
                new Serie
                {
                    Title = "Breaking Bad",
                    Genre = "Drama",
                    RealeseData = DateTime.Parse("2012-1-4"),
                    Seasons = 4
                },

                new Serie
                {
                    Title = "Lpst In Space",
                    Genre = "Adventure",
                    RealeseData = DateTime.Parse("2010-1-4"),
                    Seasons = 5
                },
                new Serie
                {
                    Title = "Frinds",
                    Genre = "Drama",
                    RealeseData = DateTime.Parse("2010-1-4"),
                    Seasons = 8
                }
                );
        }
    }
}
