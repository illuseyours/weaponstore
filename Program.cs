using System;

namespace weaponstore
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a new user
            Objects.User user = new Objects.User()
            {
                Name = "Guy",
                Email = "Guy@dude.bro",
                Login = "GuyLoginName",
                Password = "toast123!",
                UserGuid = Guid.NewGuid(),
                UserType = Enums.UserType.Magic
            };

            // display the name in console, the \n is to create a new line in console
            Console.WriteLine("User " + user.Name + " has been created successfully. \n");

            // create a new weapon
            Objects.Weapon weapon = new Objects.Weapon()
            {
                WeaponType = Enums.WeaponType.Magic,
                AmmoTypeRequired = Enums.AmmoType.Magic,
                ElementType = Enums.ElementType.Wind,
                Damage = 15,
                IsElemental = true,
                Name = "Staff of Wind"
            };

            // display the name in console
            Console.WriteLine("Weapon " + weapon.Name + " has been created successfully. \n");

            // create a new ammo
            Objects.Ammo ammo = new Objects.Ammo()
            {
                Name = "Wind Crystal",
                AmmoType = Enums.AmmoType.Magic,
                ElementType = Enums.ElementType.Wind,
                WeaponTypeRequired = Enums.WeaponType.Magic,
                Weight = 1
            };

            // display the name in console
            Console.WriteLine("Ammo " + ammo.Name + " has been created successfully. \n");

            // assign the objects to the user object
            user.CurrentWeapon = weapon;
            user.CurrentAmmo = ammo;

            // now we can use them like this =)
            Console.WriteLine(user.Name + " currently has the weapon " + user.CurrentWeapon.Name + " in his hand! \n"
                + "He is also using " + user.CurrentAmmo.Name + " ammo! it does " + user.CurrentWeapon.Damage + " damage... run! \n");

            // we can also check if his weapon and ammo match
            // these enums are converted to an int, which is their index in the enum. so magic is 4 in both weapon and ammo type
            // if they both weren't 4 it wouldn't match!
            bool matches = (int)user.CurrentWeapon.AmmoTypeRequired == (int)user.CurrentAmmo.WeaponTypeRequired ? true : false;

            // display the result in the console
            Console.WriteLine("His weapon and ammo type matches: " + matches);

            // this keeps the console from automatically closing after the code runs
            Console.ReadLine();
            
        }
    }
}
