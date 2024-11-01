using Proyecto2;
class Program
{
    static void Main(string[] args)
    {
        Biblioteca biblioteca = new Biblioteca();
        //agregar logica de usuarios

        int opcion = 0;
        do
        {
            Menu();
            opcion = Convert.ToInt32(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    Console.WriteLine("--- Gestion Libros ---");
                    GestionLibros();
                    opcion = Convert.ToInt32(Console.ReadLine());
                    switch (opcion)
                    {
                        case 1:
                            biblioteca.AgregarLibro();
                            break;
                        case 2:
                            biblioteca.MostrarLibroBuscado();
                            break;
                        case 3:
                            biblioteca.EliminarLibro();
                        break;
                    }
                    break;
                case 2:
                    Console.WriteLine("--- Gestion Usuarios ---");

                    break;
                case 3:
                    Console.WriteLine("--- Gestion Prestamos ---");
                    Console.WriteLine("Ingrese el nombre del libro que desea buscar: ");

                    break;
                case 4:
                    Console.WriteLine("--- Cerrar Sesion ---");
                    Console.WriteLine("Ingrese el nombre del libro que desea actualizar: ");
                    
                    break;
                default:
                    Console.WriteLine("Ha ingresado una opción no válida. Por favor intente de nuevo.");
                break;
            }
        } while (opcion != 6);
    }
    //Cambiar Menus
    static void Menu() 
    {
        Console.WriteLine("\n\t\t\t\tBIBLIOTECA");
        Console.WriteLine("1. Gestion Libros");
        Console.WriteLine("2. Gestion Usuarios");
        Console.WriteLine("3. Gestion Prestamos");
        Console.WriteLine("4. Salir del Sistema");
        Console.Write("Ingrese una opcion: ");
    }
    static void GestionLibros() 
    {
        Console.WriteLine("1. Agregar libro nuevo");
        Console.WriteLine("2. Buscar libro");
        Console.WriteLine("3. Eliminar libro");
        Console.Write("Ingrese una opcion: ");
    }
    static void GestionUsuarios()
    {
        Console.WriteLine();
    }
    static void GestionPrestamos()
    {


    }

}
