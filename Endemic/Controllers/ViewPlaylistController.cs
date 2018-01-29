using Endemic.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Endemic.Controllers
{
    public class ViewPlaylistController : Controller
    {

        public ActionResult obtenerAlbumes()
        {
            Puente p = new Puente();
            List<Album> albumes = new List<Album>();
            albumes = p.obtenerAlbums();
            return Json(albumes, JsonRequestBehavior.AllowGet);
        }
    }
}