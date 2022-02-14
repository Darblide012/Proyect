﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace promad.Data.Model
{
    public class Supplier
    {
      [Key]
        public int IdProveedor { get; set; }

   
        public string Codigo { get; set; }

        
        public string  RazonSocila { get; set; }

       
        public string RFC { get; set; }

    }
}
