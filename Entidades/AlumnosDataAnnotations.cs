using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Entidades
{
    [MetadataType(typeof(AlumnosDataAnnotations))]

    //Enlaza a clase de la entidad genberada por entityframework
    public partial class Alumnos
    {

    }
    public class AlumnosDataAnnotations
    {
        [Key]
        public int id { get; set; }

        [Required(ErrorMessage = "El {0} es obligatorio")]
        [RegularExpression(@"[a-zñA-ZÑ\u00C0-\u017F\s]*")]
        [DisplayName("Nombre del Alumno")]
        public string nombre { get; set; }

        [Required(ErrorMessage = "El {0} es obligatorio")]
        [RegularExpression(@"[a-zñA-ZÑ\u00C0-\u017F\s]*")]
        [DisplayName("Apellido Paterno")]

        public string primerApellido { get; set; }

        [Required(ErrorMessage = "El {0} es obligatorio")]
        [RegularExpression(@"[a-zñA-ZÑ\u00C0-\u017F\s]*")]
        [Display(Name = "Apellido Materno")]

        public string segundoApellido { get; set; }

        [Required(ErrorMessage = "El {0} es obligatorio")]
        [Display(Name = "Correo Electronico")]
        [EmailAddress(ErrorMessage = "{0} formato incorrecto")]
        public string correo { get; set; }

        [Required(ErrorMessage = "El {0} es obligatorio")]
        [DisplayName("Telefono")]
        [StringLength(10, MinimumLength = 10, ErrorMessage = "El {0} debe tener máximo {1} caracteres")]
        public string telefono { get; set; }

        [DisplayName("Fecha de Nacimeinto")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]

        public System.DateTime fechaNacimiento { get; set; }

        [Display(Name = "CURP")]
        [RegularExpression(@"^([A-Z][AEIOUX][A-Z]{2}\d{2}(?:0[1-9]|1[0-2])(?:0[1-9]|[12]\d|3[01])[HM](?:AS|B[CS]|C[CLMSH]|D[FG]|G[TR]|HG|JC|M[CNS]|N[ETL]|OC|PL|Q[TR]|S[PLR]|T[CSL]|VZ|YN|ZS)[B-DF-HJ-NP-TV-Z]{3}[A-Z\d])(\d)$", ErrorMessage = "El formato de {0} es incorrecto")]
        [Required(ErrorMessage = "El {0} es obligatorio")]
        [StringLength(18, MinimumLength = 18, ErrorMessage = "El {0} debe tener máximo {2} caracteres")]
        public string curp { get; set; }

        [Required(ErrorMessage = "El {0} es obligatorio")]
        [Display(Name = "Sueldo")]
        [DataType(DataType.Currency, ErrorMessage = "No es una moneda")]
        [Range(10000, 40000, ErrorMessage = "El valor debe estar entre el {1} y el {2}")]
        public Nullable<decimal> sueldo { get; set; }

        [Required(ErrorMessage = "El {0} es obligatorio")]
        [Display(Name = "Estado")]

        public int idEstadoOrigen { get; set; }

        [Required(ErrorMessage = "El {0} es obligatorio")]
        [DisplayName("Estatus")]
        public short idEstatus { get; set; }
    }
}
