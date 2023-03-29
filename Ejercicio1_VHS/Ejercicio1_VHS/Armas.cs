using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_VHS
{
    class Armas
    {
        string name;
        float damage;
        float attackSpeed;

        public void DamagePerSecond()
        {
            float damageForSecond = (damage / 2) * attackSpeed; 
        }
    }
}
