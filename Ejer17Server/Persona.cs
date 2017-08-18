using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ejer17Server
{
    public class Persona
    {
        public long ID { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public int Edad { get; set; }

        public Persona()
        {

        }

        public Persona(string _Nombre, string _Apellidos, int _Edad)
        {
            this.Nombre = _Nombre;
            this.Apellidos = _Apellidos;
            this.Edad = _Edad;
        }

    }
}