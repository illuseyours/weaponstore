using System;
using System.Collections.Generic;
using System.Text;

namespace weaponstore.Objects
{
    class User
    {
        public Guid UserGuid { get; set; }
        public string Name { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public Enums.UserType UserType { get; set; }
        public Weapon CurrentWeapon { get; set; }
        public Ammo CurrentAmmo { get; set; }
        public int Health { get; set; }
        public int Stamina { get; set; }
        public int Magic { get; set; }
    }
}
