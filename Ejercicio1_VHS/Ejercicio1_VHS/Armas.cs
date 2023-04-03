using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_VHS
{
    class Armas
    {
        public String Nombre;
        public int Daño;
        public int VelocidadDeAtaque;
        public int Precio;

        public Armas(string nombre, int daño, int velocidadDeAtaque, int precio)
        {
            Nombre = nombre;
            Daño = daño;
            VelocidadDeAtaque = velocidadDeAtaque;
            Precio = precio;
        }

        public virtual float DañoPorSegundo()
        {
            return Daño * VelocidadDeAtaque;
        }
      
        
    }

}

