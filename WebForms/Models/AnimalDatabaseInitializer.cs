using System.Collections.Generic;
using System.Data.Entity;

namespace WebForms.Models
{
    public class AnimalDatabaseInitializer : DropCreateDatabaseIfModelChanges<AnimalContext>
    {
        protected override void Seed(AnimalContext context)
        {
            GetCategories().ForEach(c => context.Categories.Add(c));
            GetAnimals().ForEach(p => context.Animals.Add(p));
        }

        private static List<Category> GetCategories()
        {
            var categories = new List<Category> {
                new Category
                {
                    CategoryID = 1,
                    CategoryName = "Mammals"
                },
                new Category
                {
                    CategoryID = 2,
                    CategoryName = "Lizards"
                }
    
            };

            return categories;
        }

        private static List<Animal> GetAnimals()
        {
            var Animals = new List<Animal> {
                new Animal
                {
                    AnimalID = 1,
                    AnimalName = "Elephant",
                    Description = "The Elephant is the largest land mammal on the Earth.",
                    ImagePath="elephant.jpg",
                    TicketPrice = 22.50,
                    CategoryID = 1
               },
                new Animal
                {
                    AnimalID = 2,
                    AnimalName = "Ape",
                    Description = "The Ape is a familial beast.",
                    ImagePath="ape.jpg",
                    TicketPrice = 15.95,
                     CategoryID = 1
               },
                new Animal
                {
                    AnimalID = 3,
                    AnimalName = "Lion",
                    Description = "The Lion is the King of the Jungle.",
                    ImagePath="lion.jpg",
                    TicketPrice = 32.99,
                    CategoryID = 1
                },
                new Animal
                {
                    AnimalID = 4,
                    AnimalName = "Bear",
                    Description = "The Bear is a powerful hunter.",
                    ImagePath="bear.jpg",
                    TicketPrice = 8.95,
                    CategoryID = 1
                },
                new Animal
                {
                    AnimalID = 5,
                    AnimalName = "Snake",
                    Description = "The Snake is one of the world's most feared animals.",
                                  
                    ImagePath="snake.png",
                    TicketPrice = 34.95,
                    CategoryID = 2
                },
                new Animal
                {
                    AnimalID = 6,
                    AnimalName = "Tiger",
                    Description = "The Tiger is a study in graceful power.",
                    ImagePath="tiger.jpg",
                    TicketPrice = 95.00,
                    CategoryID = 1
                },
                new Animal
                {
                    AnimalID = 7,
                    AnimalName = "Zebra",
                    Description = "The Zebra is a food source for many predators in the wild.",
                    ImagePath="zebra.jpg",
                    TicketPrice = 4.95,
                    CategoryID = 1
                },
                                new Animal
                {
                    AnimalID =8,
                    AnimalName = "Salamander",
                    Description = "The Salamander is known to be found in the deserts of the USA.",
                    ImagePath="salamander.jpg",
                    TicketPrice = 4.95,
                    CategoryID = 2
                },
                                                new Animal
                {
                    AnimalID = 9,
                    AnimalName = "Gecko",
                    Description = "The Gecko is friendly lizard that is fun for kids.",
                    ImagePath="gecko.jpg",
                    TicketPrice = 4.95,
                    CategoryID = 2
                },

            };

            return Animals;
        }
    }
}