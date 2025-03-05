﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_Task5
{
    public class EnemyBuilder : ICharacterBuilder
    {
        private Character _character = new Character();

        public ICharacterBuilder SetName(string name) { _character.Name = name; return this; }
        public ICharacterBuilder SetHeight(int height) { _character.Height = height; return this; }
        public ICharacterBuilder SetBuild(string build) { _character.Build = build; return this; }
        public ICharacterBuilder SetHairColor(string color) { _character.HairColor = color; return this; }
        public ICharacterBuilder SetEyeColor(string color) { _character.EyeColor = color; return this; }
        public ICharacterBuilder SetOutfit(string outfit) { _character.Outfit = outfit; return this; }
        public ICharacterBuilder AddToInventory(string item) { _character.Inventory.Add(item); return this; }
        public ICharacterBuilder AddAction(string action) { _character.Actions.Add(action); return this; }
        public Character Build() { return _character; }
    }
}
