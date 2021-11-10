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
    
    public class StudentsController : Controller
    {
        private readonly ILogger<StudentsController> _logger;
        private IRollments irollments;
        private IStudent istudent;

        public StudentsController(ILogger<StudentsController> logger, IStudent istudent, IRollments irollments)
        {
            this.irollments = irollments;
            this.istudent = istudent;
            _logger = logger;
        }

        public IActionResult Students()
        {
            var listado = istudent.ListOfStudents();

            return View(listado);
        }

        public IActionResult studentsRegistro()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Registro(Students students)
        {
            Students st = new Students();

            st.FirstMidName = students.FirstMidName;
            st.LastName = students.LastName;
            st.EnrrollmentsDate = students.EnrrollmentsDate;

            istudent.Insert(st);
            return Redirect("/Students/studentsRegistro");
        }

        //public IActionResult actualizar(int StudentId, string LastName, string FirstMidName, string ErollementsDate)
        //{
        //    ViewBag.StudentId = StudentId;
        //    ViewBag.LastName = LastName;
        //    ViewBag.FirstMidName = FirstMidName;
        //    ViewBag.ErollementsDate = ErollementsDate;
        //    return View("Insertar");
        //}
    }

    
}
