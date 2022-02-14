using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using promad.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace promad.Data.Context
{
    public class Context : DbContext
    {

        public Context(DbContextOptions<Context> options) : base(options)
        {

        }
        public DbSet<Supplier> Proveedores { get; set; }
        public DbSet<Products> Productos   { get; set; }
    }
}

    

