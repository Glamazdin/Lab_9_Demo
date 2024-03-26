using Lab_9_Demo.Entities;
using Lab_9_Demo.Enums;
using Lab_9_Demo.Weapon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_9_Demo.Services;

internal static class Director
{
    /// <summary>
    /// Создать невооруженного мужчину
    /// </summary>
    /// <param name="name">Имя персонажа</param>
    /// <param name="builder">объект построителя</param>
    /// <returns></returns>
    public static CharacterBase GetMale(string name, AbstractBuilder builder)
    {
        return builder.SetName(name)
                    .SetGender(Gender.Male)
                    .Build();
    }

    /// <summary>
    /// Создать невооруженную женщину
    /// </summary>
    /// <param name="name">Имя персонажа</param>
    /// <param name="builder">объект построителя</param>
    /// <returns></returns>
    public static CharacterBase GetFemale(string name, AbstractBuilder builder)
    {
        return builder.SetName(name)
                    .SetGender(Gender.Female)                    
                    .Build();
    }

    /// <summary>
    /// Создать женщину-лучника
    /// </summary>
    /// <param name="name">Имя персонажа</param>
    /// <param name="builder">объект построителя</param>
    /// <returns></returns>
    public static CharacterBase GetArcherFemale(string name, AbstractBuilder builder)
    {
        return builder.SetName(name)
                    .SetGender(Gender.Female)
                    .SetWeapon(new Longbow())
                    .Build();
    }

    /// <summary>
    /// Создать мечника
    /// </summary>
    /// <param name="name">Имя персонажа</param>
    /// <param name="builder">объект построителя</param>
    /// <returns></returns>
    public static CharacterBase GetSwordsMan(string name, AbstractBuilder builder)
    {
        return builder.SetName(name)
                    .SetGender(Gender.Male)
                    .SetWeapon(new Sword())
                    .Build();
    }

    /// <summary>
    /// Создать мужчину, вооруженного топором
    /// </summary>
    /// <param name="name">Имя персонажа</param>
    /// <param name="builder">объект построителя</param>
    /// <returns></returns>
    public static CharacterBase GetAxWarriorMale(string name, AbstractBuilder builder)
    {
        return builder.SetName(name)
                    .SetGender(Gender.Male)
                    .SetWeapon(new Poleaxe())
                    .Build();
    }
}


