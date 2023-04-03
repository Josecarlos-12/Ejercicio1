using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_VHS
{
    class ArmaCuerpoACuerpo : Armas
    {
        public ArmaCuerpoACuerpo(string nombre, int daño, int velocidadDeAtaque, int precio)
                : base(nombre, daño, velocidadDeAtaque, precio)
        {
        }


        public override float DañoPorSegundo()
        {
            return base.DañoPorSegundo();
        }
    }
}
