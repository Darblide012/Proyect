using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace promad
{
    public class Proveers
    {

        [Key]
        public string Supplier { get; set; }

        public Guid Code { get; set; }

        public string BusinessName { get; set; }

        public string RFC { get; set; }

    }
}
