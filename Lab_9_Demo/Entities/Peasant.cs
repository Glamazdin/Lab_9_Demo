using Lab_9_Demo.Enums;
using Lab_9_Demo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_9_Demo.Entities;

internal class Peasant : CharacterBase, IWorker, IMovable
{
    public Peasant(string name, Gender gender):base(name,gender)
    {        
    }
    public void DoWork()
    {
        Say($"Hi! I work on my garden");
    }

    public override void GetInfo()
    {
        Say($"I am a peasant. My gender is {Gender}");
    }

    public void Run()
    {
        Say($"I am running");
    }

    public void Walk()
    {
        Say($"I walk somewhere");
    }
}
