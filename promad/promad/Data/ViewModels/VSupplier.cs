using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace promad.Data.ViewModels
{
    public class VSupplier
    {
      [Key]
        public int IdProveedor { get; set; }

        [Column("Codigo")]
        public string Codigo { get; set; }

        [Column("Razon Social")]
        public string RazonSocila { get; set; }

        [Column("RFC")]
        public string RFC { get; set; }


    }
}
