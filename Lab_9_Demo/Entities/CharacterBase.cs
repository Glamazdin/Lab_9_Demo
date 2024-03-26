using Lab_9_Demo.Enums;
using Lab_9_Demo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab_9_Demo.Entities;
/// <summary>
/// Базовый персонаж
/// Абстрактный класс
/// </summary>
internal abstract class CharacterBase
{
    // Имя персонажа
    public string Name { get; private set; }
    // Пол персонажа
    public Gender Gender { get; private set; }
    // Оружие персонажа
    IWeapon _weapon;

    protected CharacterBase(string name, Gender gender)
    {
        Name = name;
        Gender = gender;
    }
    /// <summary>
    /// Получит информацию о персонаже
    /// </summary>
    public abstract void GetInfo();
    /// <summary>
    /// Вывод сообщения
    /// </summary>
    /// <param name="message">Текст сообщения</param>
    protected void Say(string message)
    {
        Console.WriteLine($"{Name} says:\"{message}\"");
    }
    /// <summary>
    /// Дать оружие
    /// </summary>
    /// <param name="weapon">Оружие</param>
    public void SetWeapon( IWeapon weapon )
    { _weapon = weapon; }
    /// <summary>
    /// Использовать оружие
    /// </summary>
    public void UseWeapon()
    {
        _weapon?.Attak();
    }

}
