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
            return librosEnPrestamo.Count;
        }

        public void AgregarLibro(Libro libro)
        {
            librosEnPrestamo.Add(libro);
        }

        public override string ToString()
        {
            return $"Lector:{nombre} | DNI:{dni} | Libros Prestados{librosEnPrestamo.Count}";
        }

    }
}


