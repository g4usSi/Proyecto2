using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto2
{
    public class Bibliotecario : Usuario
    {
        public Bibliotecario() : base()
        {
            this.Rol = "Bibliotecario";
        }
        public Usuario BuscarUsuario(List<Usuario> listaUsuarios, string usuarioBuscar)
        {
            foreach (var usuarioActual in listaUsuarios) 
            {
                if (usuarioActual.ID == usuarioBuscar) 
                { 
                    return usuarioActual;
                }
            }
            return null;
        }


    }
}
