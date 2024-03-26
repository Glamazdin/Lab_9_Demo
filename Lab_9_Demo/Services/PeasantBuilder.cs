using Lab_9_Demo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_9_Demo.Services;

internal class PeasantBuilder : AbstractBuilder
{
    public override CharacterBase Build()
    {
        var peasant = new Peasant(name, gender);
        if(weapon != null)
            peasant.SetWeapon(weapon);
        return peasant;
    }
}
