using Proyecto2;
class Program
{
    static void Main(string[] args)
    {
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



                    break;
                case 2:
                    Console.WriteLine("--- Mostrar Libros ---");

                    break;
                case 3:
                    Console.WriteLine("--- Gestion Usuarios ---");
                    Console.WriteLine("Ingrese el nombre del libro que desea buscar: ");

                    break;
                case 4:
                    Console.WriteLine("--- Gestion Prestamos ---");
                    Console.WriteLine("Ingrese el nombre del libro que desea prestar: ");

                    break;
                case 5:
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

    
    }


}
