using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Endemic.Entidades
{
    public class Puente
    {

        public List<Album> obtenerAlbums()
        {
            Artista art = new Artista();
            List<Album> albums = new List<Album>();
            Cancion c = new Cancion();
            c.Id = 1;
            c.Nombre = "Slow Hands";
            c.Duracion = "02:55";
            c.Genero = "Rock";
            c.Direccion = "http://localhost:50131/Content/Media/SlowHands.mp3";
            Cancion c1 = new Cancion();
            c1.Id = 2;
            c1.Nombre = "This town";
            c1.Duracion = "02:55";
            c1.Genero = "Pop";
            c1.Direccion = "http://localhost:50131/Content/Media/02%20-%20This%20Town.mp3";
            Cancion c2 = new Cancion();
            c2.Id = 3;
            c2.Nombre = "Seeing blind";
            c2.Duracion = "03:50";
            c2.Genero = "Pop";
            c2.Direccion = "http://localhost:50131/Content/Media/03%20-%20Seeing%20Blind.mp3";
            Cancion c3 = new Cancion();
            c3.Id = 4;
            c3.Nombre = "Too much to ask";
            c3.Duracion = "03:20";
            c3.Genero = "Pop";
            c3.Direccion = "http://localhost:50131/Content/Media/05%20-%20Too%20Much%20To%20Ask.mp3";
            List<Cancion> canciones = new List<Cancion>();
            canciones.Add(c);
            canciones.Add(c1);
            canciones.Add(c2);
            canciones.Add(c3);

            Album a = new Album();
            a.Canciones = canciones;
            a.id = 1;
            a.Nombre = "Flicker";
            a.Artista = art.obtenerArtista1();
            a.imagen = "/Content/Imagenes/v1.jpg";
            albums.Add(a);


            //Empieza nuevo album
            Cancion c21 = new Cancion();
            c21.Id = 1;
            c21.Nombre = "Sorry not Sorry";
            c21.Duracion = "03:24";
            c21.Genero = "Pop";
            c21.Direccion = "http://localhost:50131/Content/Media/01%20Sorry%20Not%20Sorry.mp3";
            Cancion c22 = new Cancion();
            c22.Id = 2;
            c22.Nombre = "Tell me you love me";
            c22.Duracion = "03:57";
            c22.Genero = "Pop";
            c22.Direccion = "http://localhost:50131/Content/Media/02%20Tell%20Me%20You%20Love%20Me.mp3";
            Cancion c23 = new Cancion();
            c23.Id = 3;
            c23.Nombre = "Sexy dirty love";
            c23.Duracion = "03:33";
            c23.Genero = "Pop";
            c23.Direccion = "http://localhost:50131/Content/Media/03%20Sexy%20Dirty%20Love.mp3";
            Cancion c24 = new Cancion();
            c24.Id = 4;
            c24.Nombre = "You Don't Do It For Me Anymore";
            c24.Duracion = "03:18";
            c24.Genero = "Pop";
            c24.Direccion = "http://localhost:50131/Content/Media/04%20You%20Dont%20Do%20It%20For%20Me%20Anymore.mp3";
            List<Cancion> canciones2 = new List<Cancion>();
            
            canciones2.Add(c21);
            canciones2.Add(c22);
            canciones2.Add(c23);
            canciones2.Add(c24);
            Album a2 = new Album();
            a2.Canciones = canciones2;
            a2.id = 2;
            a2.Nombre = "Tell Me You Love Me";
            a2.Artista = art.obtenerArtista2();
            a2.imagen = "/Content/Imagenes/v2.jpg";
            albums.Add(a2);


            //nuevo album
            Cancion c31 = new Cancion();
            c31.Id = 1;
            c31.Nombre = "Younger now";
            c31.Duracion = "03:24";
            c31.Genero = "Pop";
            c31.Direccion = "http://localhost:50131/Content/Media/01%20-%20Younger%20Now.mp3";
            Cancion c32 = new Cancion();
            c32.Id = 2;
            c32.Nombre = "Malibu";
            c32.Duracion = "03:57";
            c32.Genero = "Pop";
            c32.Direccion = "http://localhost:50131/Content/Media/02%20-%20Malibu.mp3";
            Cancion c33 = new Cancion();
            c33.Id = 3;
            c33.Nombre = "Rainbowland";
            c33.Duracion = "03:33";
            c33.Genero = "Pop";
            c33.Direccion = "http://localhost:50131/Content/Media/03%20-%20Rainbowland.mp3";
            Cancion c34 = new Cancion();
            c34.Id = 4;
            c34.Nombre = "Week without you";
            c34.Duracion = "03:18";
            c34.Genero = "Pop";
            c34.Direccion = "http://localhost:50131/Content/Media/04%20-%20Week%20Without%20You.mp3";
            List<Cancion> canciones3 = new List<Cancion>();
            canciones3.Add(c31);
            canciones3.Add(c32);
            canciones3.Add(c33);
            canciones3.Add(c34);
            Album a3 = new Album();
            a3.Canciones = canciones3;
            a3.id = 3;
            a3.Nombre = "Younger now";
            a3.Artista = art.obtenerArtista3();
            a3.imagen = "/Content/Imagenes/v3.jpg";
            albums.Add(a3);

            //nuevo albums
            Cancion c41 = new Cancion();
            c.Id = 1;
            c41.Nombre = "Younger now";
            c41.Duracion = "03:24";
            c41.Genero = "Pop";
            c41.Direccion = "http://localhost:50131/Content/Media/01%20-%20Younger%20Now.mp3";
            Cancion c42 = new Cancion();
            c42.Id = 2;
            c42.Nombre = "Malibu";
            c42.Duracion = "03:57";
            c42.Genero = "Pop";
            c42.Direccion = "http://localhost:50131/Content/Media/02%20-%20Malibu.mp3";
            Cancion c43 = new Cancion();
            c43.Id = 3;
            c43.Nombre = "Rainbowland";
            c43.Duracion = "03:33";
            c43.Genero = "Pop";
            c43.Direccion = "http://localhost:50131/Content/Media/03%20-%20Rainbowland.mp3";
            Cancion c44 = new Cancion();
            c44.Id = 4;
            c44.Nombre = "Week without you";
            c44.Duracion = "03:18";
            c44.Genero = "Pop";
            c44.Direccion = "http://localhost:50131/Content/Media/04%20-%20Week%20Without%20You.mp3";
            List<Cancion> canciones4 = new List<Cancion>();
            Album a4 = new Album();
            a4.Canciones = canciones4;
            canciones4.Add(c41);
            canciones4.Add(c42);
            canciones4.Add(c43);
            canciones4.Add(c44);
            a4.id = 4;
            a4.Nombre = "Walls";
            a4.Artista = art.obtenerArtista4();
            a4.imagen = "/Content/Imagenes/v4.jpg";
            albums.Add(a4);


            //nuevo albums
            Cancion c51 = new Cancion();
            c.Id = 1;
            c51.Nombre = "Wonderful wonderful";
            c51.Duracion = "03:24";
            c51.Genero = "Pop";
            c51.Direccion = "http://localhost:50131/Content/Media/01.%20Wonderful%20Wonderful.mp3";
            Cancion c52 = new Cancion();
            c52.Id = 2;
            c52.Nombre = "The man";
            c52.Duracion = "03:57";
            c52.Genero = "Pop";
            c52.Direccion = "http://localhost:50131/Content/Media/02.%20The%20Man.mp3";
            Cancion c53 = new Cancion();
            c53.Id = 3;
            c53.Nombre = "Rut";
            c53.Duracion = "03:33";
            c53.Genero = "Pop";
            c53.Direccion = "http://localhost:50131/Content/Media/03.%20Rut.mp3";
            Cancion c54 = new Cancion();
            c54.Id = 4;
            c54.Nombre = "Life to come";
            c54.Duracion = "03:18";
            c54.Genero = "Pop";
            c54.Direccion = "http://localhost:50131/Content/Media/04.%20Life%20To%20Come.mp3";
            List<Cancion> canciones5 = new List<Cancion>();
            canciones5.Add(c51);
            canciones5.Add(c52);
            canciones5.Add(c53);
            canciones5.Add(c54);
            Album a5 = new Album();

            a5.Canciones = canciones5;
            a5.id = 5;
            a5.Nombre = "Wonderful Wonderful";
            a5.Artista = art.obtenerArtista5();
            a5.imagen = "/Content/Imagenes/v5.jpg";
            albums.Add(a5);

            return albums;


        }


        public Album ObtenerlistaCancionAlbum(int id)
        {

            List<Album> albums = obtenerAlbums();
            Album album = new Album();
            foreach (Album a in albums)
            {
                if (id == a.id)
                {
                    album = a;
                }
            }
            return album;
        }

        public List<Album> ObtenerlistaAlbumFiltro(string busqueda)
        {

            List<Album> albums = obtenerAlbums();
            List<Album> albumesFiltro = new List<Album>();
            foreach (Album a in albums)
            {
                if (a.Nombre.ToLower().Contains(busqueda.ToLower())||a.Nombre.ToLower().StartsWith(busqueda.ToLower()))
                {
                    albumesFiltro.Add(a);
                }
            }
            return albumesFiltro;
        }
    }
}