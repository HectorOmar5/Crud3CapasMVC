using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidades;


namespace Negocio
{
    public class NEstatusAlumnos
    {
        InstitutoTichEntities dbContext = new InstitutoTichEntities();

        public List<EstatusAlumnos> ConsultarEstatus()
        {
            return dbContext.EstatusAlumnos.ToList();
        }

        public EstatusAlumnos ConsultarEstatus(int id)
        {
            return dbContext.EstatusAlumnos.Find(id);
        }
    }
}
