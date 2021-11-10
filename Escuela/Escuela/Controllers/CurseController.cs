using Escuela.Dominio;
using Escuela.Servicio;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Escuela.Controllers
{

    public class CurseController : Controller
    {
        private readonly ILogger<CurseController> _logger;
        private ICourese icourse;
        private IRollments irollements;

        public CurseController(ILogger<CurseController> logger, ICourese icourse,
            IRollments irollements, IStudent istudent)
        {
            this.icourse = icourse;
            this.irollements = irollements;
            _logger = logger;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Cursos()
        {

            return View();
        }

        public IActionResult GetAll()
        {
            var DandoFormatoJson = icourse.ListarCursos();

            return Json(new { data = DandoFormatoJson });
        }

        public IActionResult Registrar()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Registro(Course course)
        {
            Course cr = new Course();

            cr.Title = course.Title;
            cr.Credits = course.Credits;

            icourse.Insertar(cr);
            return Redirect("/Curse/Cursos");
        }
    }
}
