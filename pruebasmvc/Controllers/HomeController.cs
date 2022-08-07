using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace pruebasmvc.Controllers
{
    public class HomeController : Controller
    {

        public class persona{

            public string Nombre { get; set; }
            public int edad { get; set; }
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About( string nombredios, int edad)
        {
            ViewBag.Message = "la descripcion de la pagina hp." + nombredios+" Edad  del dios hp : " + edad;

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "tu pagina de contacto.";

            return View();
        }
        public ContentResult perrita()
        {
            return Content("<b>panocha humeda </b>");
        }

        public JsonResult jsonhp()
        {
            var hp1 = new persona() {Nombre ="Charles Grundy" ,edad =50};
            var hp2= new persona() { Nombre = "Charles Grundy Gallo", edad = 50 };
            return Json(new List<persona>() { hp1,hp2} , JsonRequestBehavior.AllowGet);
        }

        public RedirectResult xvideos()
        {
            return Redirect("https://xvideos.com");

        }

        public RedirectToRouteResult redirecciona()
        {

            return RedirectToAction("Register","Account");
        }

        public RedirectToRouteResult ruta()
        {
            return RedirectToRoute("porno");

        }

        public HttpStatusCodeResult codigo()
        {

            return new HttpStatusCodeResult(404,"porno no encontrado perro");
        }

        [HttpGet]
        public ActionResult enviarinformacion(string perrita)
        {
            ViewData["puta"] = " Rocio Robleto" + perrita;
            return View();
        }

        [HttpPost]
        public ActionResult enviarinformacion(string nombre, int edad)
        {
            ViewBag.Message = "Nombre del dios: " + nombre + " Edad hp : " + edad;
            ViewBag.chupada = "Xochil Aburto";
            ViewBag.Perrita = "Gabriela perrita";

            return View();
        }

        public ActionResult pruebavista()
        {

            return View();
        }
        [ChildActionOnly]
        public ActionResult pruebavistalayoutaut()
        {

            return View();
        }
    }
}