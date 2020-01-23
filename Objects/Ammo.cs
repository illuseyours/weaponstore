using System;
using System.Collections.Generic;
using System.Text;

namespace weaponstore.Objects
{
    class Ammo
    {
        public string Name { get; set; }
        public int Weight { get; set; }
        public Enums.WeaponType WeaponTypeRequired { get; set; }
        public Enums.AmmoType AmmoType { get; set; }
        public Enums.ElementType ElementType { get; set; }
    }
}
