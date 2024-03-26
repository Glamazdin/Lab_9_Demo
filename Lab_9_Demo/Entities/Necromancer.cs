using Lab_9_Demo.Enums;
using Lab_9_Demo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_9_Demo.Entities
{
    internal class Necromancer : CharacterBase, IWizard
    {
        public Necromancer(string name, Gender gender) : base(name, gender)
        {
        }
        public override void GetInfo()
        {
            Say($"I am a necromancer. My gender is {Gender}");
        }
        

        public void Spell()
        {
            Say($"Beware! I put a spell on you"); ;
        }
    }
}
