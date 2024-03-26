using Lab_9_Demo.Entities;
using Lab_9_Demo.Enums;
using Lab_9_Demo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_9_Demo.Services
{
    internal abstract class AbstractBuilder
    {
        protected string name = String.Empty;
        protected Gender gender;
        protected IWeapon? weapon;
        public AbstractBuilder SetName(string name)
        { this.name = name; return this; }
        public AbstractBuilder SetGender(Gender gender)
        { this.gender = gender; return this; }
        public AbstractBuilder SetWeapon(IWeapon weapon)
        { this.weapon = weapon; return this; }
        /// <summary>
        /// Получение объекта
        /// </summary>
        /// <returns>объект класса CharacterBase</returns>
        public abstract CharacterBase Build();
    }
}
