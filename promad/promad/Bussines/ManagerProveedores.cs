using promad.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace promad.Bussines
{

    public class ManagerProveedores
    {
        private Context  _context;

        public ManagerProveedores(Context context)
        {
            _context = context;
        }


        public void Addsupplier(supplier supplier)
        {
            var _supplier = new supplier()
            {
                Supplier = supplier.Supplier,
                Code = supplier.Code,
                RazonSocila = supplier.RazonSocila,
                RFC = supplier.RFC



            };

            _context.Proveedores.Add(_supplier);
            _context.SaveChanges();
        }

        public List<supplier> GetAllsupplier()
        {
            var Allsupplier = _context.Proveedores.ToList();

            return Allsupplier;
        }


        public supplier GetCode(string code) => _context.Proveedores.FirstOrDefault(na => na.Code ==code );




    }
}
