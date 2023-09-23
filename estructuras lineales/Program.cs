using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estructuras_lineales
{
    internal class Program
    {
        static void Main()
        {
            // Creamos una lista de números
            List<int> numeros = new List<int> { 10, 5, 7, 2, 8, 15, 1, 3 };

            // Llamamos a la función para encontrar el número máximo
            int maximo = EncontrarMaximo(numeros);

            // Mostramos el resultado
            Console.WriteLine("El número máximo en la lista es: " + maximo);
        }

        static int EncontrarMaximo(List<int> lista)
        {
            if (lista.Count == 0)
            {
                throw new InvalidOperationException("La lista está vacía.");
            }

            int maximo = lista[0]; // Suponemos que el primer elemento es el máximo

            foreach (int numero in lista)
            {
                if (numero > maximo)
                {
                    maximo = numero; // Actualizamos el máximo si encontramos un número mayor
                }
            }

            return maximo;
        }

    }
}

