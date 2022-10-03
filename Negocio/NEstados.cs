using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;

namespace Negocio
{
    public class NEstados
    {
        InstitutoTichEntities _DBcontext = new InstitutoTichEntities();

        public List<Estados> ConsultarEstados()
        {
            return _DBcontext.Estados.ToList();

        }

        public Estados ConsultarEstados(int id)
        {
            return _DBcontext.Estados.Find(id);
        }
    }
}
