using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeSistemaDeRefrescos
{
    class Program
    {
        static void Main(string[] args)
        {
            Componente root = new Almacen("ALMACEN PRINCIPAL");

            Componente cocacola = new Refresco("Coca-Cola", 100);
            Componente fanta = new Refresco("Fanta", 50);
            Componente sprite = new Refresco("Sprite", 200);
            Componente vital = new Refresco("Vital", 800);
            Componente powerrade = new Refresco("Power Rade", 50);
            Componente simba = new Refresco("Simba", 30);
            Componente aquarius = new Refresco("Aquarius", 300);


            Componente almacenCBBA = new Almacen("Almacen Cochabamba");
            Componente almacenSCZ = new Almacen("Almacen Santa Cruz");
            Componente almacenLPZ = new Almacen("Almacen La Paz");

            almacenCBBA.AgregarHijo(cocacola);
            almacenSCZ.AgregarHijo(fanta);
            almacenLPZ.AgregarHijo(sprite);
            almacenLPZ.AgregarHijo(vital);
            almacenCBBA.AgregarHijo(almacenLPZ);

            root.AgregarHijo(almacenCBBA);
            root.AgregarHijo(almacenSCZ);
            root.AgregarHijo(powerrade);
            root.AgregarHijo(simba);
            root.AgregarHijo(aquarius);

            Console.WriteLine($"La Cantidad Total de Refrescos Del {root.Nombre} es {root.ObtenerCantidad}");
            Console.WriteLine ("\n");
            Console.WriteLine($"En el {almacenCBBA.Nombre} hay {almacenCBBA.ObtenerCantidad} refrescos disponibles");
            Console.WriteLine($"En el {almacenSCZ.Nombre} hay {almacenSCZ.ObtenerCantidad} refrescos disponibles");
            Console.WriteLine($"En el {almacenLPZ.Nombre} hay {almacenLPZ.ObtenerCantidad} refrescos disponibles");
            Console.ReadKey();

        }
    }
}