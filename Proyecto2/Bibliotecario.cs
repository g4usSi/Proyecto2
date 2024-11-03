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
        public override void MostrarUsuario()
        {
            base.MostrarUsuario();
        }
    }
}
