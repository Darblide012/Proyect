using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace promad
{
    public class supplier
    {
        [Key]
        public int Supplier { get; set; }

        public string Code { get; set; }

        public string RazonSocila { get; set; }

        public string RFC { get; set; }

    }
}
