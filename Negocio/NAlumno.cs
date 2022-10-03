using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidades;
using Newtonsoft;
using Negocio.ServiceWCF;

namespace Negocio
{
    public class NAlumno
    {
        InstitutoTichEntities _DBContext = new InstitutoTichEntities();
        public List<Alumnos> Consultar()
        {
            List<Alumnos> _listaAlu = _DBContext.Alumnos.Include("Estados").Include("EstatusAlumnos").ToList();
            return _listaAlu;
        }

        public Alumnos Consultar(int id)
        {
            return _DBContext.Alumnos.Include("Estados").Include("EstatusAlumnos").Where(x => x.id == id).FirstOrDefault(); ;
        }

        public void CreateAlumno(Alumnos alumnos)
        {
            _DBContext.Alumnos.Add(alumnos);
            _DBContext.SaveChanges();
        }

        public void EditAlumno(Alumnos alumnos)
        {   
            _DBContext.Entry(alumnos).State = System.Data.Entity.EntityState.Modified;
            _DBContext.SaveChanges();
        }

        public void DeleteAlumno(int id)
        {
            Alumnos alumnos = _DBContext.Alumnos.Find(id); //Buscar, Extraer el objeto
            _DBContext.Alumnos.Remove(alumnos);
            _DBContext.SaveChanges();

        }

        public ServiceWCF.AportacionesIMSS CalcularIMSS(int id)
        {
            ServiceWCF.WCFAlumnosClient wCFAlumnosClient = new Negocio.ServiceWCF.WCFAlumnosClient();
            return wCFAlumnosClient.CalcularIMSS(id);

        }

        public ServiceWCF.ItemTablaISR CalcularISR(int id)
        {
            ServiceWCF.WCFAlumnosClient wCFAlumnosClient = new Negocio.ServiceWCF.WCFAlumnosClient();
            return wCFAlumnosClient.CalcularISR(id);
        }

    }
}


