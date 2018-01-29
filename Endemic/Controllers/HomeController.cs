using Endemic.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;



namespace Endemic.Controllers
{
    
    public class HomeController : Controller
    {
       
        public ActionResult Index()
        {
            Puente p = new Puente();
            List<Album> albums = p.obtenerAlbums();
            return View(albums);
        }
        public ActionResult ViewPlaylist(int id)
        {
            Puente p = new Puente();
            Album a = new Album();
            a = p.ObtenerlistaCancionAlbum(id);
            return View(a);
        }
        

        public ActionResult LlenarTabla(int id)
        {
            Puente p = new Puente();
            Album a = new Album();
            a = p.ObtenerlistaCancionAlbum(id);
            return Json(a, JsonRequestBehavior.AllowGet); 
        }

        public ActionResult buscarAlbum(string busqueda)
        {
            Puente p = new Puente();
            List<Album> albumes = new List<Album>();
            albumes = p.ObtenerlistaAlbumFiltro(busqueda);
            return Json(albumes, JsonRequestBehavior.AllowGet);
        }

        public ActionResult obtenerAlbumes()
        {
            Puente p = new Puente();
            List<Album> albumes = new List<Album>();
            albumes = p.obtenerAlbums();
            return Json(albumes, JsonRequestBehavior.AllowGet);
        }

        public ActionResult obtenerAlbum(int id)
        {
            Puente p = new Puente();
            Album a = new Album();
            a = p.ObtenerlistaCancionAlbum(id);
            return Json(a, JsonRequestBehavior.AllowGet);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}