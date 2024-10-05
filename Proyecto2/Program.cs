using Proyecto2;
class Program
{
    static void Main(string[] args)
    {
        //corregir
        Libro biblioteca = new();
        int opcion = 0;
        do
        {
            Console.WriteLine("\n\t\t\t\tBIBLIOTECA");
            Console.WriteLine("1. Agregar un nuevo libro a la biblioteca");
            Console.WriteLine("2. Mostrar todos los libros");
            Console.WriteLine("3. Buscar libro");
            Console.WriteLine("4. Prestar un libro");
            Console.WriteLine("5. Devolver libro");
            Console.WriteLine("6. Salir");
            Console.Write("Ingrese una opcion: ");

            try
            {
                opcion = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Error el tipo de dato ingresado no es valido. \n> " + ex.Message);
                Console.WriteLine("Presione calquier tecla para continuar...");
                Console.ReadLine();
                Console.Clear();
                continue;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Oh! parece que hubo un error desconocido... \n> " + ex.Message);
                Console.WriteLine("Contacte al Administrador...");
                continue;
            }

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("--- Agregar Libro ---");
                    biblioteca.AgregarLibro();
                    break;
                case 2:
                    Console.WriteLine("--- Mostrar Libros ---");
                    biblioteca.MostrarLibros();
                    break;
                case 3:
                    Console.WriteLine("--- Buscar un Libro ---");
                    Console.WriteLine("Ingrese el nombre del libro que desea buscar: ");
                    biblioteca.Buscar(biblioteca.EntradaLibro());
                    break;
                case 4:
                    Console.WriteLine("--- Prestar un libro ---");
                    Console.WriteLine("Ingrese el nombre del libro que desea prestar: ");
                    biblioteca.Buscar(biblioteca.EntradaLibro());
                    break;
                case 5:
                    Console.WriteLine("--- Devolver un libro ---");
                    Console.WriteLine("Ingrese el nombre del libro que desea actualizar: ");
                    biblioteca.Buscar(biblioteca.EntradaLibro());
                    break;
                default:
                    Console.WriteLine("Ha ingresado una opción no válida. Por favor intente de nuevo.");

                    break;
            }
        } while (opcion != 6);
        Console.WriteLine("Fin del Programa\n Geovanny Alcon ----- 1578324");
    }
}