using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class RangedWeapon: Weapon
    {
        public string name;
        public string weaponType;

        public RangedWeapon(string name, string weaponType): base (name)
        {
            this.name = name;
            this.weaponType = weaponType;
        }

       static string bulletType()
        {
            if (weaponType == "LASER RIFLE")
            {

            }
            else if (weaponType == "GAUSS RIFLE")
            {

            }
        }
       
        
       
            
    }
}
