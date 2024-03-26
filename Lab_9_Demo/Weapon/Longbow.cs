using Lab_9_Demo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_9_Demo.Weapon
{
    internal class Longbow : IWeapon
    {
        public void Attak()
        {
            Console.WriteLine("An arrow shot from a longbow");
        }
    }
}
