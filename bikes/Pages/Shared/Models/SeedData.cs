using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using bikes.Models;

namespace bikes.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new bikesContext(
                serviceProvider.GetRequiredService<DbContextOptions<bikesContext>>()))
            {
                // Look for any bikes.
                if (context.bike.Any())
                {
                    return;   // DB has been seeded
                }

                context.bike.AddRange(
                    new bike
                    {
                        Model = "EcoRider E1",
                        BuildTime = new DateTime(2023, 1, 1),
                        Company = "EcoRider",
                        Power = "250W electric motor",
                        Place = "United States",
                        Cost = 1499.00M
                    },

                    new bike
                    {
                        Model = "VeloTech VT-2000",
                        BuildTime = new DateTime(2023, 1, 1),
                        Company = "VeloTech",
                        Power = "500W electric motor",
                        Place = "Germany",
                        Cost = 2799.00M
                    },

                    new bike
                    {
                        Model = "SpeedMaster S450",
                        BuildTime = new DateTime(2023, 1, 1),
                        Company = "SpeedMaster",
                        Power = "650W electric motor",
                        Place = "Japan",
                        Cost = 3999.00M
                    },

                    new bike
                    {
                        Model = "MountainKing MK-700",
                        BuildTime = new DateTime(2023, 1, 1),
                        Company = "MountainKing",
                        Power = "350W electric motor",
                        Place = "Canada",
                        Cost = 2199.00M
                    },

                    new bike
                    {
                        Model = "CityCruiser C300",
                        BuildTime = new DateTime(2023, 1, 1),
                        Company = "CityCruiser",
                        Power = "250W electric motor",
                        Place = "Netherlands",
                        Cost = 1899.00M
                    },

                    new bike
                    {
                        Model = "TouringPro TP-500",
                        BuildTime = new DateTime(2023, 1, 1),
                        Company = "TouringPro",
                        Power = "750W electric motor",
                        Place = "Italy",
                        Cost = 4599.00M
                    },

                    new bike
                    {
                        Model = "UrbanGlide U450",
                        BuildTime = new DateTime(2023, 1, 1),
                        Company = "UrbanGlide",
                        Power = "500W electric motor",
                        Place = "France",
                        Cost = 2299.00M
                    },

                    new bike
                    {
                        Model = "OffRoadXtreme OX-800",
                        BuildTime = new DateTime(2023, 1, 1),
                        Company = "OffRoadXtreme",
                        Power = "1000W electric motor",
                        Place = "Australia",
                        Cost = 5299.00M
                    }
                );

                context.SaveChanges();
            }
        }
    }
}
