using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Endemic.Entidades
{
    public class Artista
    {
        public string Nombre { get; set; }

        public Artista obtenerArtista1()
        {
            Artista artista = new Artista();
            artista.Nombre = "Niall Horan";
            return artista;
        }

        public Artista obtenerArtista2()
        {
            Artista artista = new Artista();
            artista.Nombre = "Demi Lovato";
            return artista;
        }

        public Artista obtenerArtista3()
        {
            Artista artista = new Artista();
            artista.Nombre = "Miley Cyrus";
            return artista;
        }

        public Artista obtenerArtista4()
        {
            Artista artista = new Artista();
            artista.Nombre = "Kings of Leon";
            return artista;
        }

        public Artista obtenerArtista5()
        {
            Artista artista = new Artista();
            artista.Nombre = "The Killers";
            return artista;
        }
    }

   
    
}