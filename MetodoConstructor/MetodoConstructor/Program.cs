using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoConstructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Ventana calculador = new Ventana();
            calculador.Mostrar();

            Console.ReadKey();
        }
    }

    class Ventana
    {
        //Atributos
        private int ancho, altura;
        private String color;

        public Ventana()
        {
            ancho = 20;
            altura = 10;
            color = "verde";
        }

        public void Mostrar()
        {
            Console.WriteLine("La diemension de la ventana es: " + ancho +"x"+ altura + "y su color es: " + color);
        }
    }
}
