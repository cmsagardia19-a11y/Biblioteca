//Clase biblioteca

namespace Colecciones
{
    internal class Biblioteca
    {
        private List<Libro> libros;
        private List<Lector> lectores;

        public Biblioteca()
        {
            this.libros = new List<Libro>();
            this.lectores = new List<Lector>();
        }

        // Se agrega método el cual muestra los lectores existentes
        public void ListarLectores()
        {
            foreach (var lector in lectores)
            {
                Console.WriteLine(lector);
            }
        }

        // Se agrega método el cual carga lectores por defecto al iniciar el programa
        public void CargarLectores()
        {
            bool pudo;
            pudo = AltaLector("Juan Perez", "12345678");
            if (pudo)
                Console.WriteLine("Lector Juan Perez agregado correctamente");
            else
                Console.WriteLine("El lector Juan Perez ya existe");

            pudo = AltaLector("Maria Gomez", "23456789");
            if (pudo)
                Console.WriteLine("Lector Maria Gomez agregado correctamente");
            else
                Console.WriteLine("La lectora Maria Gomez ya existe");

            pudo = AltaLector("Pedro Rodriguez", "34567890");
            if (pudo)
                Console.WriteLine("Lector Pedro Rodriguez agregado correctamente");
            else
                Console.WriteLine("El lector Pedro Rodriguez ya existe");
            Console.WriteLine("\n");
        }

        // Se mueve este método desde el Main() a la clase Biblioteca
        public List<Libro> CargarLibros(int cantidad)
        {
            bool pude;

            Console.WriteLine("*********************************************** \n");
            Console.WriteLine("...Agregando libros a la biblioteca \n");

            for (int i = 1; i <= cantidad; i++)
            {
                pude = AgregarLibro(
                    "Libro" + i,
                    "Autor" + i,
                    "Editorial" + i
                );

                if (pude)
                    Console.WriteLine("Libro " + i + " agregado correctamente");
                else
                    Console.WriteLine("Libro " + i + " ya existe en biblioteca");
            }
            Console.WriteLine("\n***********************************************\n");
            return libros;
        }

        //Encapsulamiento
        private Libro BuscarLibro(string titulo)
        {
            Libro libroBuscado = null;
            int i = 0;
            while (i < libros.Count && !libros[i].GetTitulo().Equals(titulo, StringComparison.OrdinalIgnoreCase))
            {
                i++;
            }
            if (i != libros.Count)
            {
                libroBuscado = libros[i];
            }
            return libroBuscado;
        }

        private Lector BuscarLector(string dni)
        {
            Lector lectorBuscado = null;
            int i = 0;
            while (i < lectores.Count && !lectores[i].GetDni().Equals(dni))
            {
                i++;
            }
            if (i != lectores.Count)
            {
                lectorBuscado = lectores[i];
            }
            return lectorBuscado;
        }

        //Administración de libros
        public bool AgregarLibro(string titulo, string autor, string editorial)
        {
            bool resultado = false;
            Libro libro = BuscarLibro(titulo);
            if (libro == null)
            {
                libro = new Libro(titulo, autor, editorial);
                libros.Add(libro);
                resultado = true;
            }
            return resultado;
        }

        public bool EliminarLibro(string titulo)
        {
            bool resultado = false;
            Libro libro = BuscarLibro(titulo);
            if (libro != null)
            {
                libros.Remove(libro);
                resultado = true;
            }
            return resultado;
        }

        public void ListarLibros()
        {
            Console.WriteLine("...Mostrando libros de la biblioteca \n");
            foreach (var libro in libros)

            {
                Console.WriteLine(libro);
            }
            Console.WriteLine("\n***********************************************\n");
        }

        //Requerimiento 1: Alta de lector
        public bool AltaLector(string nombre, string dni)
        {
            Console.WriteLine("\n...Agregando lector a la biblioteca\n");
            bool resultado = false;
            Lector lector = BuscarLector(dni);
            if (lector == null)
            {
                lector = new Lector(nombre, dni);
                lectores.Add(lector);
                resultado = true;
            }
            return resultado;
        }

        //Requerimiento 2 :Prestamo de un libro
        public string PrestarLibro(string titulo, string dni)
        {
            Console.WriteLine("\n***********************************************\n");
            Console.WriteLine("\n...Prestando libro de la biblioteca\n");
            Lector lector = BuscarLector(dni);
            if (lector == null)
            {
                return "LECTOR INEXISTENTE \n";
            }

            if (lector.GetCantidadPrestamos() >= 3)
            {
                return "TOPE DE PRESTAMO ALCANZADO \n";
            }

            Libro libro = BuscarLibro(titulo);
            if (libro == null)
            {
                return "LIBRO INEXISTENTE \n";
            }

            libros.Remove(libro);
            lector.AgregarLibro(libro); // Transfieres el libro de la biblioteca al lector[cite: 1, 2, 3]

            return "PRESTAMO EXITOSO \n";
        }
    }

}
