// See https://aka.ms/new-console-template for more information
using Lab_9_Demo.Entities;
using Lab_9_Demo.Enums;
using Lab_9_Demo.Services;
using Lab_9_Demo.Weapon;

List<CharacterBase> characters = new List<CharacterBase>();

SetupData(characters);

foreach (CharacterBase character in characters)
{
    Console.WriteLine("===========================");
    character.GetInfo();    
    if (character is Peasant peasant)
    {        
        peasant.Walk();
        peasant.DoWork();       
    }
    else if(character is Necromancer necromancer)
    {
        necromancer.Spell();
    }
    character.UseWeapon();

    
}

void SetupData(List<CharacterBase> characters)
{
    var peasantBuilder = new PeasantBuilder();
    var necromancerBuilder = new NecromancerBuilder();

    characters.Add(Director.GetSwordsMan("Bob", peasantBuilder));
    characters.Add(Director.GetArcherFemale("Mary", peasantBuilder));
    characters.Add(Director.GetMale("Merlin", necromancerBuilder));
    characters.Add(Director.GetAxWarriorMale("Thor", peasantBuilder));
}