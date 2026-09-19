using System;
using System.Runtime.CompilerServices;

namespace Colecciones
{
    internal class test
    {
        static void Main(string[] args)
        {
            Biblioteca biblioteca = new Biblioteca();

            // 1. Carga de datos iniciales
            biblioteca.AltaLector("Juan Perez", "12345678");
            biblioteca.AgregarLibro("Libro 1", "Autor 1", "Editorial 1");
            biblioteca.AgregarLibro("Libro 2", "Autor 2", "Editorial 2");
            biblioteca.AgregarLibro("Libro 3", "Autor 3", "Editorial 3");
            biblioteca.AgregarLibro("Libro 4", "Autor 4", "Editorial 4");

            // 2. Realizar 3 préstamos válidos
            Console.WriteLine(biblioteca.PrestarLibro("Libro 1", "12345678")); // PRESTAMO EXITOSO
            Console.WriteLine(biblioteca.PrestarLibro("Libro 2", "12345678")); // PRESTAMO EXITOSO
            Console.WriteLine(biblioteca.PrestarLibro("Libro 3", "12345678")); // PRESTAMO EXITOSO

            // 3. Intentar un 4to préstamo (supera el límite)
            Console.WriteLine(biblioteca.PrestarLibro("Libro 4", "12345678")); // TOPE DE PRESTAMO ALCANZADO
            Console.WriteLine(biblioteca.PrestarLibro("Libro 5", "12345678")); // TOPE DE PRESTAMO ALCANZADO
           
        }
    }
}
