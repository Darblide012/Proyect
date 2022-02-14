using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace promad.Data.ViewModels
{
    public class VProducts
    {
        [Key]
        public int IdProduct { get; set; }

        [ForeignKey("Proveedor")]
        public int IdProvider { get; set; }

        [Column("Codigo")]
        public string Code { get; set; }

        [Column("Descripcion")]
        public string Description { get; set; }

        [Column("Unidad")]
        public string Unit { get; set; }

        [Column("Costo")]
        public float Cost { get; set; }
    }
}
