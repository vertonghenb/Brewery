using Brewery.Data;
using Brewery.Domain;
using System;
using System.Linq;

namespace Brewery.App
{
    class Program
    {
        static void Main(string[] args)
        {
            // Deleting DB
            // Creating DB
            // Adding a Brewer
            using(BreweryDbContext context = new BreweryDbContext())
            {
                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();

                Brewer newBrewer = new Brewer("Moortgat", "Brouwerij Duvel Moortgat biedt je een heerlijke brouwerij-ervaring. Ben je een volledige leek of reikt je kennis toch al iets verder? Je ontdekt ongetwijfeld wat je zoekt.");

                context.Brewers.Add(newBrewer);

                context.SaveChanges();
            }

            // Query The Brewer

            using (BreweryDbContext context = new BreweryDbContext())
            {
                Brewer moortgat = context.Brewers.FirstOrDefault();
                Console.WriteLine(moortgat.Name);
            }
        }
    }
}
