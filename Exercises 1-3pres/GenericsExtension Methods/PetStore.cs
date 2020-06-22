using GenericsExtension_Methods.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericsExtension_Methods
{
    public class PetStore<T> where T : Pet
    {
        public List<T> ListOfPets = new List<T>();

        public void AddNewPet(T item)
        {
            ListOfPets.Add(item);
        }

        public void PrintsPets()
        {
            foreach (T item in ListOfPets)
            {
                Console.WriteLine(item.PrintInfo());
            }
        }

        public void BuyPet(string name)
        {
            T result = ListOfPets.FirstOrDefault(pet => pet.Name == name);
            if(result == null)
            {
                Console.WriteLine("Nema takvo milenice vo listata");
                return;
            }
            ListOfPets.Remove(result);

            Console.WriteLine($"Go kupi uspeshno {result.Name}");
        }

    }
}
