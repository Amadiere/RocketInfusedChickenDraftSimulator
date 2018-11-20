using Microsoft.EntityFrameworkCore;
using RocketInfusedChicken.Database.Model;
using System;
using System.Linq;

namespace RocketInfusedChicken.Database
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var factory = new RocketInfusedChickenContextFactory();

            using (var context = factory.CreateDbContext(null))
            {
                var sets = context.Sets.Include("Printings.Card");
                foreach (var set in sets)
                {
                    Console.WriteLine($"{set.Id}={set.Name}");
                    foreach (var printing in set.Printings)
                    {
                        Console.WriteLine($" --> {printing.Card.Id}={printing.Card.Name}");
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
