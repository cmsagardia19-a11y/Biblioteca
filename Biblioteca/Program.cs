using System;
using System.Runtime.CompilerServices;

namespace Colecciones
{
    internal class test
    {
        static void Main(string[] args)
        {
            // instancia Biblioteca
            Biblioteca biblioteca = new Biblioteca();

            // Carga libros por defecto y los muestra
            biblioteca.CargarLibros(10);
            biblioteca.ListarLibros();

            // Carga lectores por defecto
            biblioteca.CargarLectores();

            // intenta carga 2 libros existente 
            biblioteca.CargarLibros(2);
            
            // Elimina el 'Libro5' y muestra la lista de libros existentes
            biblioteca.EliminarLibro("Libro5");
            biblioteca.ListarLibros();

            // Agrego lector
            biblioteca.AltaLector("Juan Perez", "12345678");
            biblioteca.ListarLectores();

            // Caso 1: Lector Inexistente
            Console.WriteLine(biblioteca.PrestarLibro("Libro 1", "99999999")); // Retorna: LECTOR INEXISTENTE

            // Caso 2: Libro Inexistente
            Console.WriteLine(biblioteca.PrestarLibro("Libro Desconocido", "12345678")); // Retorna: LIBRO INEXISTENTE

            // Caso 3: Préstamos Exitosos (hasta 3)
            Console.WriteLine(biblioteca.PrestarLibro("Libro1", "12345678")); // Retorna: PRESTAMO EXITOSO
            Console.WriteLine(biblioteca.PrestarLibro("Libro2", "12345678")); // Retorna: PRESTAMO EXITOSO
            Console.WriteLine(biblioteca.PrestarLibro("Libro3", "12345678")); // Retorna: PRESTAMO EXITOSO

            // Caso 4: Tope Alcanzado
            Console.WriteLine(biblioteca.PrestarLibro("Libro 4", "12345678")); // Retorna: TOPE DE PRESTAMO ALCANZADO
        }
    }
}