using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace promad
{
    public class Products
    {

        [Key ]
        public int IdProduct { get; set; }

        [ForeignKey ("")]
        public int IdProvider { get; set; }

        [Column("")]
        public string Code { get; set; }

        [Column("")]
        public string  Description { get; set; }

        [Column("")]
        public  string Unit { get; set; }

        [Column("")]
        public string Cost { get; set; }
    }
}
