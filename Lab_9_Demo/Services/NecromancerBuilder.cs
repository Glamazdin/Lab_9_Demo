using Lab_9_Demo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_9_Demo.Services;

internal class NecromancerBuilder : AbstractBuilder
{
    public override CharacterBase Build()
    {
        var necromancer = new Necromancer(name, gender);
        if (weapon != null)
            necromancer.SetWeapon(weapon);
        return necromancer;
    }
}
