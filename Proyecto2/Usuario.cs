﻿using System;
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
        public Usuario(string iD, string password, string rol)
        {
            ID = iD;
            Password = password;
            Rol = rol;
        }
        public void EditarUsuario() 
        { 
            
        }


    }
}
