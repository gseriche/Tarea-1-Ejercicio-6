using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Tarea 1 - Ejercicio 6
// Diseñar un algoritmo y construir un programa que lea un número
// en caso de que ese número sea 0 o menor que 0,
// terminará el algoritmo imprimiendo antes un mensaje de error,
// si es mayor que 0, se deberá calcular su cuadrado,
// visualizando el número que ha tecleado el usuario y su resultado
// (“Del numero X, su potencia es X y su raíz X”).

// Algoritmo
// 1 - Solicita un numero al usuario
// 2 - Verifica que el numero sea mayor a 0
// 3 - Calcula la potencia del numero
// 4 - Calcula la raiz cuadrada del numero
// 5 - Imprime el numero, su potencia y la raiz cuadrada

namespace Ejercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {

            // Solicita al usuario ingresar un numero
            string advertencia = "";

            float numero;
            do
            {
                Console.WriteLine(advertencia);
                Console.WriteLine("Ingresa el numero");
                advertencia = "Por favor intenta denuevo, esta vez ingresando un numero mayor a 0";
            } while (!float.TryParse(Console.ReadLine(), out numero));

            // Si es que el numero es menor o igual a 0 sale del programa
            if (numero <= 0)
            {
                Console.WriteLine("Error, debe ingresar un numero mayor a 0");
                Console.ReadLine();
            }

            // Calcula e imprime la potencia y la raiz cuadrada del numero
            else
            {
                float numerocuadrado;
                double numeroraiz;
                numerocuadrado = numero * numero;
                numeroraiz = Math.Sqrt(numero);
                Console.WriteLine("Del numero {0}, su potencia es {1} y su raíz {2}", numero, numerocuadrado, numeroraiz);
                Console.WriteLine("");
                Console.WriteLine("Presione cualquier tecla para salir del programa");
                Console.ReadLine();
            }
        }
    }
}
