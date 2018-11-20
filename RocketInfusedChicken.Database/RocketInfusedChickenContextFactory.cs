using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace RocketInfusedChicken.Database
{
    public class RocketInfusedChickenContextFactory : IDesignTimeDbContextFactory<RocketInfusedChickenContext>
    {
        public RocketInfusedChickenContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<RocketInfusedChickenContext>();
            optionsBuilder.UseSqlServer("Server=GLaDoS;Database=RocketInfusedChicken;Trusted_Connection=True;");

            return new RocketInfusedChickenContext(optionsBuilder.Options);
        }
    }
}
