using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsExtension_Methods.Entities
{
    class Cat : Pet
    {
        public bool Lazy;
        public int LivesLeft { get; set; }
        public override string PrintInfo()
        {
           return  $"Cat with {LivesLeft} lives left";
        }
    }
}
