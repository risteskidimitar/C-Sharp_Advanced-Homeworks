using Exercise_AbstractInterFaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_AbstractInterFaces
{
    public abstract class User : IUser
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public void PrintUser()
        {
            Console.WriteLine($" Hi {Username} with ID {ID}");
        }
    }
}
