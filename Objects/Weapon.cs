using System;
using System.Collections.Generic;
using System.Text;

namespace weaponstore.Objects
{
    class Weapon
    {
        public string Name { get; set; }
        public int Damage { get; set; }
        public bool IsElemental { get; set; }
        public Enums.WeaponType WeaponType { get; set; }
        public Enums.AmmoType AmmoTypeRequired { get; set; }
        public Enums.ElementType ElementType { get; set; }
    }
}
