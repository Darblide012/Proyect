using promad.Data.Context;
using promad.Data.Model;
using promad.Data.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace promad.Bussines
{

    public class ManagerProveedores
    {
        private Context  _context;

        public ManagerProveedores(Context context)
        {
            _context = context;
        }


        /// <summary>
        /// Agregar un proovedor
        /// </summary>
        /// <param name="supplier"></param>
        public void Addsupplier(VSupplier supplier)
        {
            var _supplier = new Supplier()
            {
               
              IdProveedor = supplier.IdProveedor,
              Codigo = supplier.Codigo,
              RazonSocila = supplier.RazonSocila,
              RFC = supplier.RFC

            };

            _context.Proveedores.Add(_supplier);
            _context.SaveChanges();
        }
        
        /// <summary>
        /// Buscar todos los proovedores
        /// </summary>
        /// <returns></returns>
        public List<Supplier> GetAllsupplier()
        {
            var Allsupplier = _context.Proveedores.ToList();

            return Allsupplier;
        }

        /// <summary>
        /// Buscar por codigo de proovedor
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public Supplier GetCode(string code) => _context.Proveedores.FirstOrDefault(na => na.Codigo ==code );


        /// <summary>
        /// Actualizar por razon social
        /// </summary>
        /// <param name="UpdateRazonsocial"></param>
        /// <param name="supplier"></param>
        /// <returns></returns>
        public Supplier UpdatesRazonsocial(string UpdateRazonsocial, VSupplier supplier)
        {
            var _supplier = _context.Proveedores.FirstOrDefault(n => n.RazonSocila == UpdateRazonsocial);

            if (_supplier != null)
            {

                _supplier.Codigo = supplier.Codigo;
                _supplier.RFC = supplier.RFC;

                

                _context.SaveChanges();


            }
            return _supplier;


        }

        /// <summary>
        /// Eliminar proveedor por Id
        /// </summary>
        /// <param name="IdProovedor"></param>
        public void DeleteSupplierByid(int IdProovedor)
        {
            var _supplier = _context.Proveedores.FirstOrDefault(n => n.IdProveedor == IdProovedor);

            if (_supplier != null)
            {
                _context.Remove(_supplier);
                _context.SaveChanges();
            }

            


        }

    }
}
