using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsExtension_Methods.Entities
{
    class Dog : Pet
    {
        public bool GoodBoi;

        public string FavoriteFood;

        public override string PrintInfo()
        {
            return $"Dog with favorite food {FavoriteFood}";
        }
    }
}
