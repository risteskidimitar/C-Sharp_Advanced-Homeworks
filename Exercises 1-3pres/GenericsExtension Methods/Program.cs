using GenericsExtension_Methods.Entities;
using System;

namespace GenericsExtension_Methods
{
    class Program
    {
        static void Main(string[] args)
        {

            var dog1 = new Dog()
            {
                Name = "Dzeki",
                Age = 2,
                Type = "Rottweiler",
                GoodBoi = false,
                FavoriteFood = "Meat"
            };

            var dog2 = new Dog()
            {
                Name = "Laki",
                Age = 4,
                Type = "Labrador",
                GoodBoi = true,
                FavoriteFood = "Everithing"
            };

            var cat1 = new Cat()
            {
                Name = "Lucifer",
                Age = 3,
                Type = "Black",
                Lazy = true,
                LivesLeft = 8,
            };

            var cat2 = new Cat()
            {
                Name = "Maci",
                Age = 5,
                Type = "White",
                Lazy = true,
                LivesLeft = 6,
            };

            var fish1 = new Fish()
            {
                Name = "Ribche",
                Age = 1,
                Type = "Gold",
                Color = "Golden",
                Size = 3,
            };

            var fish2 = new Fish()
            {
                Name = "Sharky",
                Age = 2,
                Type = "Shark",
                Color = "Gray",
                Size = 5,
            };

            var DogStore = new PetStore<Dog>();
            var CatStore = new PetStore<Cat>();
            var FishStore = new PetStore<Fish>();

            DogStore.AddNewPet(dog1);
            DogStore.AddNewPet(dog2);

            CatStore.AddNewPet(cat1);
            CatStore.AddNewPet(cat2);

            FishStore.AddNewPet(fish1);
            FishStore.AddNewPet(fish2);

            DogStore.BuyPet("Deki");

            Console.WriteLine("--------------------------");
            DogStore.BuyPet("Dzeki");

            CatStore.BuyPet("Lucifer");
            
            Console.WriteLine("---------------Printing Dog\\s---------------");
            DogStore.PrintsPets();
            Console.WriteLine("---------------Printing Cat\\s---------------");

            CatStore.PrintsPets();
            Console.WriteLine("---------------Printing Fish\\s---------------");

            FishStore.PrintsPets();

            Console.ReadLine();
        }
    }
}
