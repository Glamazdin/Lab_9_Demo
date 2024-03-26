using Lab_9_Demo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_9_Demo.Weapon;

internal class Poleaxe : IWeapon
{
    public void Attak()
    {
        Console.WriteLine("I swing my axe");
    }
}
