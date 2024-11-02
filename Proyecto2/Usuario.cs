using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto2
{
    public class Usuario
    {
        public string ID { get; set; }
        public string Password  { get; set; }
        public string Rol { get; set; }
        public Usuario(string iD = null, string password = null, string rol = "Superusuario")
        {
            if (iD == null)
            {
                Console.Write("Ingrese el nombre: ");
                ID = Console.ReadLine();
            }
            else
            {
                ID = iD;
            }

            if (password == null)
            {
                Console.Write("Ingrese la contraseña: ");
                Password = Console.ReadLine();
            }
            else
            {
                Password = password;
            }
            this.Rol = rol;
        }
        public virtual void MostrarUsuario() 
        {
            Console.WriteLine($"Nombre: {ID} \nRol: {Rol}");
        }
        public virtual void SolicitarLibro(Libro libroPrestar)
        {
        }
        public virtual void DevolverLibro()
        {
        }

    }
}
