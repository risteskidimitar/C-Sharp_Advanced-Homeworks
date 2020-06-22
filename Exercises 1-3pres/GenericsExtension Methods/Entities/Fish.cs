using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsExtension_Methods.Entities
{
    class Fish : Pet
    {
        public string Color { get; set; }
        public int Size { get; set; }

        public override string PrintInfo()
        {
            return $"fish with {Color} color and size {Size}";
        }
    }
}
