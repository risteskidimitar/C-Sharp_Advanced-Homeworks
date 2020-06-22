using System;

namespace Dogs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercise");

            var Dzeki = new Dog() { Color = "White", ID =3, Name = "Dzeki" };
            var Sharko = new Dog() { Color = "Mixed", ID = 1, Name = "Sharko" };
            var Dzoni = new Dog() { Color = "Black", ID = 2, Name = "Dzoni" };

            Sharko.Bark();
            Dog.DogsValidatorAndAdder(Dzeki);
            Dog.DogsValidatorAndAdder(Sharko);
            Dog.DogsValidatorAndAdder(Dzoni);

            DogShelter.PrintAll();

            Console.ReadLine();
        }
    }
}
