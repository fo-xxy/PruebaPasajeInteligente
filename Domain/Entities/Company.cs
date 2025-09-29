using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Company
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmpresaId { get; set; }
        public string Nombre { get; set; }
        public int Codigo { get; set; }
        public string Direccion { get; set; }
        public int Telefono { get; set; }
        public string Ciudad { get; set; }
        public string Departamento { get; set; }
        public string Pais { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaActualizacion { get; set; }
    }
}
