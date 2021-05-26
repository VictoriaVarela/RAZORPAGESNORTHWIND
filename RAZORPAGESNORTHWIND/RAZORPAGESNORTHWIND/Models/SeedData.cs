using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RAZORPAGESNORTHWIND.Models
{
    public static class SeedData
    {

        public static void Initialize(IServiceProvider serviceProvider)
        {

            using var Context = new NORTHWINDContext(
                serviceProvider
                .GetRequiredService<DbContextOptions<NORTHWINDContext>>());

            if(!Context.Product.Any())
            {
                Context.Product.AddRange(
                    
                    new Product
                    {

                        Name = "Azucar",
                        RegisterDate = new DateTime(2009,2,12),
                        Category = "Azucares",
                        UnityPrice = 24.52m
                    },

                     new Product
                     {

                         Name = "Leche",
                         RegisterDate = new DateTime(2014, 3, 13),
                         Category = "Lacteos",
                         UnityPrice = 23.60m
                     },

                      new Product
                      {

                          Name = "Azucar Refinada",
                          RegisterDate = new DateTime(2016, 2, 23),
                          Category = "Azucares",
                          UnityPrice = 17m
                      },

                       new Product
                       {

                           Name = "Queso Panela",
                           RegisterDate = new DateTime(2019, 4, 15),
                           Category = "Lacteos",
                           UnityPrice = 35m
                       }

                    );

                Context.SaveChanges();
            }
        }
    }
}
