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
                        Cost = 1499.00M,
                        Rating = 7,
                        Colour = "Red"
                    },

                    new bike
                    {
                        Model = "VeloTech VT-2000",
                        BuildTime = new DateTime(2023, 1, 1),
                        Company = "VeloTech",
                        Power = "500W electric motor",
                        Place = "Germany",
                        Cost = 2799.00M,
                        Rating = 8,
                        Colour = "Black"
                    },

                    new bike
                    {
                        Model = "SpeedMaster S450",
                        BuildTime = new DateTime(2023, 1, 1),
                        Company = "SpeedMaster",
                        Power = "650W electric motor",
                        Place = "Japan",
                        Cost = 3999.00M,
                        Rating = 9,
                        Colour = "Yellow"
                    },

                    new bike
                    {
                        Model = "MountainKing MK-700",
                        BuildTime = new DateTime(2023, 1, 1),
                        Company = "MountainKing",
                        Power = "350W electric motor",
                        Place = "Canada",
                        Cost = 2199.00M,
                        Rating = 6,
                        Colour = "Brown"
                    },

                    new bike
                    {
                        Model = "CityCruiser C300",
                        BuildTime = new DateTime(2023, 1, 1),
                        Company = "CityCruiser",
                        Power = "250W electric motor",
                        Place = "Netherlands",
                        Cost = 1899.00M,
                        Rating = 8,
                        Colour = "White"
                    },

                    new bike
                    {
                        Model = "TouringPro TP-500",
                        BuildTime = new DateTime(2023, 1, 1),
                        Company = "TouringPro",
                        Power = "750W electric motor",
                        Place = "Italy",
                        Cost = 4599.00M,
                        Rating = 5,
                        Colour = "Orange"
                    },

                    new bike
                    {
                        Model = "UrbanGlide U450",
                        BuildTime = new DateTime(2023, 1, 1),
                        Company = "UrbanGlide",
                        Power = "500W electric motor",
                        Place = "France",
                        Cost = 2299.00M,
                        Rating = 9,
                        Colour = "Black"
                    },

                    new bike
                    {
                        Model = "OffRoadXtreme OX-800",
                        BuildTime = new DateTime(2023, 1, 1),
                        Company = "OffRoadXtreme",
                        Power = "1000W electric motor",
                        Place = "Australia",
                        Cost = 5299.00M,
                        Rating = 10,
                        Colour = "Red"
                    }
                );

                context.SaveChanges();
            }
        }
    }
}
