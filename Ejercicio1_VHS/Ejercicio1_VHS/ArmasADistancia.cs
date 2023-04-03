using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_VHS
{
    class ArmasADistancia : Armas
    {

        public Proyectiles proyectiles;

        public ArmasADistancia(string nombre, int daño, int velocidadDeAtaque, int precio, Proyectiles proyectiles)
            : base(nombre, daño, velocidadDeAtaque, precio)
        {
            this.proyectiles = proyectiles;
        }


        public override float DañoPorSegundo()
        {
            return base.DañoPorSegundo() + proyectiles.Daño;
        }
    }
}
