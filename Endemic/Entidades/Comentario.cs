using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Endemic.Entidades
{
    public class Comentario
    {
        public Usuario Usuario { get; set; }
        public string Descripcion { get; set; }
        public int Valoracion { get; set; } 

    }
}