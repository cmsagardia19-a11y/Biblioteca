//Clase lector
using System;
using System.Collections.Generic;

namespace Colecciones
{
    internal class Lector
    {
        private string nombre;
        private string dni;
        private List<Libro> librosEnPrestamo;

        public Lector(string nombre, string dni)
        {
            this.nombre = nombre;
            this.dni = dni;
            this.librosEnPrestamo = new List<Libro>();
        }

        public string GetDni()
        {
            return dni;
        }

        public string GetNombre()
        {
            return nombre;
        }

        public int GetCantidadPrestamos()
        {
            return librosEnPrestamo.Count; // Mide cuántos libros tiene asignados actualmente[cite: 1, 6]
        }

        public void AgregarLibro(Libro libro)
        {
            librosEnPrestamo.Add(libro); // Agrega el libro a la lista del lector[cite: 1, 6]
        }

        public override string ToString()
        {
            return $"Lector:{nombre} | DNI:{dni} | Libros Prestados{librosEnPrestamo.Count}";
        }

    }
}
