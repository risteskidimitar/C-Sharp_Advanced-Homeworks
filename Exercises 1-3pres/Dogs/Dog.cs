using System;
using System.Collections.Generic;
using System.Text;

namespace Dogs
{
    public class Dog
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }

        public void Bark()
        {
            Console.WriteLine($"The {Color} Dog with name {Name} -- bark, bark bark!");
        }

        public static bool DogsValidatorAndAdder(Dog dog)
        {
            if (dog.Name.Length < 2 || dog.ID <= 0 || string.IsNullOrWhiteSpace(dog.Color))
            {
                Console.WriteLine("Something wrong, such dog does not exist dog!");
                return false;
            }
            else
            {
                DogShelter.ListOfDogs.Add(dog);
                return true;
            }
        }
    }
}
