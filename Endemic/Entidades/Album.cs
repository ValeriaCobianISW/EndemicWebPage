using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Endemic.Entidades
{
    public class Album
    {
        public int id { get; set; }
        public string Nombre { get; set; }
        public Artista Artista { get; set; }
        public List<Cancion> Canciones { get; set; }
        public int Anio { get; set; }
        public List<Comentario> Comentarios { get; set; }
        public string imagen { get; set; }
           
        
        
      


    }
}