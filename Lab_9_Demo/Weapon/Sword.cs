using Lab_9_Demo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_9_Demo.Weapon;

internal class Sword : IWeapon
{
    public void Attak()
    {
        Console.WriteLine("I use my sword");
    }
}
