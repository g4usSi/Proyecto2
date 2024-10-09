using Proyecto2;
class Program
{
    static void Main(string[] args)
    {
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

            opcion = Convert.ToInt32(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    Console.WriteLine("--- Agregar Libro ---");

                    break;
                case 2:
                    Console.WriteLine("--- Mostrar Libros ---");

                    break;
                case 3:
                    Console.WriteLine("--- Buscar un Libro ---");
                    Console.WriteLine("Ingrese el nombre del libro que desea buscar: ");

                    break;
                case 4:
                    Console.WriteLine("--- Prestar un libro ---");
                    Console.WriteLine("Ingrese el nombre del libro que desea prestar: ");

                    break;
                case 5:
                    Console.WriteLine("--- Devolver un libro ---");
                    Console.WriteLine("Ingrese el nombre del libro que desea actualizar: ");
 
                    break;
                default:
                    Console.WriteLine("Ha ingresado una opción no válida. Por favor intente de nuevo.");

                    break;
            }
        } while (opcion != 6);
        Console.WriteLine("Fin del Programa\n Geovanny Alcon ----- 1578324");
    }
}