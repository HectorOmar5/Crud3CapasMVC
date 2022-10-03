using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Negocio;
using Entidades;

namespace Presentacion.Controllers
{
    public class AlumnoController : Controller
    {
        NAlumno alumno = new NAlumno();
        NEstados nestados = new NEstados();
        NEstatusAlumnos estatusAlumnos = new NEstatusAlumnos();
        // GET: Alumno
        public ActionResult Index()
        {
           
            return View(alumno.Consultar());
        }

        // GET: Alumno/Details/5
        public ActionResult Details(int id)
        {
            return View(alumno.Consultar(id));
        }

        // GET: Alumno/Create
        public ActionResult Create()
        {
            ViewBag.estados = nestados.ConsultarEstados();
            ViewBag.estatus = estatusAlumnos.ConsultarEstatus();
            return View();
        }

        // POST: Alumno/Create
        [HttpPost]
        public ActionResult Create(Alumnos alumnos)
        {
            try
            {
                // TODO: Add insert logic here
                alumno.CreateAlumno(alumnos);
                return RedirectToAction("Index");
            }
            catch
            {
                ViewBag.estados = nestados.ConsultarEstados();
                ViewBag.estatus = estatusAlumnos.ConsultarEstatus();
                return View();
            }
        }

        // GET: Alumno/Edit/5
        public ActionResult Edit(int id)
        {
            ViewBag.estados = nestados.ConsultarEstados();
            ViewBag.estatus = estatusAlumnos.ConsultarEstatus();
            return View(alumno.Consultar(id));
        }

        // POST: Alumno/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Alumnos alumnos)
        {
            try
            {
                // TODO: Add update logic here
               
                alumno.EditAlumno(alumnos);
                return RedirectToAction("Index");
            }
            catch
            {
                ViewBag.estados = nestados.ConsultarEstados();
                ViewBag.estatus = estatusAlumnos.ConsultarEstatus();
                return View();
            }
        }

        // GET: Alumno/Delete/5
        public ActionResult Delete(int id)
        {
            return View(alumno.Consultar(id));
        }

        // POST: Alumno/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Alumnos alumnos)
        {
            try
            {
                // TODO: Add delete logic here
                alumno.DeleteAlumno(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult _AportacionesIMSS(int id)
        {
           NAlumno alumno = new NAlumno();
            return PartialView(alumno.CalcularIMSS(id));
        }

        public ActionResult _CalcularISR(int id)
        {
            NAlumno alumno2 = new NAlumno();
            return PartialView(alumno2.CalcularISR(id));
        }

    }
}
