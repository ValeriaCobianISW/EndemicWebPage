using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Endemic.Entidades
{
    public class Cancion
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Duracion { get; set; }
        public string Genero { get; set; }
        public string Direccion { get; set; }

        public List<Cancion> listaCanciones()
        {
            List < Cancion>listaCanciones= new List<Cancion>();
            Cancion c = new Cancion();
            c.Id = 1;
            c.Nombre = "Slow Hands";
            c.Duracion = "02:55";
            c.Genero = "Rock";
            c.Direccion = "http://localhost:50131/Content/Media/SlowHands.mp3";
            Cancion c1 = new Cancion();
            c1.Id = 1;
            c1.Nombre = "Beatiful Angel";
            c1.Duracion = "02:55";
            c1.Genero = "";
            c1.Direccion = "http://localhost:50131/Content/Media/SlowHands.mp3";
            Cancion c2 = new Cancion();
            c2.Id = 1;
            c2.Nombre = "Like a Paradise";
            c2.Duracion = "";
            c2.Genero = "";
            c2.Direccion = "http://localhost:50131/Content/Media/SlowHands.mp3";
            Cancion c3 = new Cancion();
            c3.Id = 1;
            c3.Nombre = "Baby, I'm yours";
            c3.Duracion = "";
            c3.Genero = "";
            c3.Direccion = "http://localhost:50131/Content/Media/SlowHands.mp3";
           

            listaCanciones.Add(c);
            listaCanciones.Add(c1);
            listaCanciones.Add(c2);
            listaCanciones.Add(c3);
            

            return listaCanciones;
        }
       

    }
}