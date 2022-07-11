using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using LivresWebApplication.data;
using System;
using System.Linq;

namespace LivresWebApplication.Models
{
    public static class donnee
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new LivreContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<LivreContext>>()))
            {
                // Look for any movies.
                if (context.livre.Any())
                {
                    return;   // DB has been seeded
                }

                context.livre.AddRange(
                    new Livre
                    {
                        Titre = "Tel père tel fils",
                        AnneePub = 2000,
                        Auteur = "Charles Creneau",
                        
                    },

                    new Livre
                    {
                        Titre = "Challenger",
                        AnneePub = 1995,
                        Auteur = "Elliot Carry",
                    },

                    new Livre
                    {
                         Titre = "Passion et Volonté",
                         AnneePub = 1990,
                         Auteur = "Marc Garvey",
                    },

                    new Livre
                    {
                         Titre = "Utile et Espoir",
                         AnneePub = 2007,
                         Auteur = "Teddy Durham",
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
