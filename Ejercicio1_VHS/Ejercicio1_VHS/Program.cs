using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_VHS
{
    class Program
    {
        static List<Armas> inventario = new List<Armas>();
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1. Agregar un arma");
                Console.WriteLine("2. Ver inventario");
                Console.WriteLine("3. Eliminar un arma");
                Console.WriteLine("4. Salir");

                int opciones = int.Parse(Console.ReadLine());

                switch (opciones)
                {
                    case 1:
                        AgregarArma();
                        break;
                    case 2:
                        VerInventario();
                        break;
                    case 3:
                        EliminarArma();
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Opción inválida");
                        break;
                }
            }
        }

        static void AgregarArma()
        {
            Console.WriteLine("Ingrese el nombre del arma:");
            string nombre = Console.ReadLine();

            Console.WriteLine("Ingrese el daño del arma:");
            int daño = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la velocidad de ataque del arma:");
            int velocidadDeAtaque = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el precio del arma:");
            int precio = int.Parse(Console.ReadLine());

            Console.WriteLine("¿El arma es de distancia? (s/n):");
            string esDeDistancia = Console.ReadLine();

            Armas armas;

            if (esDeDistancia.ToLower() == "s")
            {
                Console.WriteLine("Ingrese el tipo de proyectil:");
                string nombreProyectil = Console.ReadLine();

                Console.WriteLine("Ingrese el daño del proyectil:");
                string dañoProyectil = Console.ReadLine();

                Proyectiles proyectiles = new Proyectiles(nombre, daño, precio);
                armas = new ArmasADistancia(nombre, daño, velocidadDeAtaque, precio, proyectiles);
            }
            else
            {
                armas = new ArmaCuerpoACuerpo(nombre, daño, velocidadDeAtaque, precio);
            }

            inventario.Add(armas);
            Console.WriteLine("Arma agregada al inventario");
        }

        static void VerInventario()
        {
            if (inventario.Count == 0)
            {
                Console.WriteLine("El inventario esta vacío");
            }
            else
            {
                Console.WriteLine("Inventario:");

                for(int i = 0; i < inventario.Count; i++)
                {
                    Console.WriteLine($"{i}. {inventario[i].Nombre} - Daño: {inventario[i].Daño}, Precio: {inventario[i].Precio}");
                }
            }
        }

        static void EliminarArma()
        {
            if(inventario.Count == 0)
            {
                Console.WriteLine("El inventario está vacío");
                return;
            }

            Console.WriteLine("Seleccion el index del arma que desea eliminar: ");
            int index = int.Parse(Console.ReadLine());

            if(index <0 || index >= inventario.Count)
            {
                Console.WriteLine("Index inválido");
                return;
            }

            Armas armaEliminada = inventario[index];
            inventario.RemoveAt(index);

            Console.WriteLine($"Arma eliminada del inventario: {armaEliminada.Nombre}");
        }

        public static Armas SeleccionarArma(List<Armas> inventario)
        {
            Console.Write("Seleccione el número del arma que desea usar:");

            for(int i =0; i <inventario.Count; i++)
            {
                Console.WriteLine($"[{i}] {inventario[i].Nombre} - Daño: {inventario[i].Daño} - Velocidad de ataque: {inventario[i].VelocidadDeAtaque}");
            }

            int seleccion = int.Parse(Console.ReadLine());

            return inventario[seleccion];
        }
    }
}
