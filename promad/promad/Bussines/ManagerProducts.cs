using promad.Data.Context;
using promad.Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace promad.Bussines
{
    public class ManagerProducts
    {
        private Context _context;
        public ManagerProducts(Context context)
        {
            _context = context;
        }

        /// <summary>
        /// Agregar un producto
        /// </summary>
        /// <param name="products"></param>
        public void AddProducts(VProducts products)
        {
            var _product = new Products()
            {
                IdProduct = products.IdProduct,
                Code = products.Code,
                Description = products.Description,
                Unit = products.Unit,
                Cost = products.Cost
                

            };

            _context.Productos.Add(_product);
            _context.SaveChanges();
        }

        /// <summary>
        /// Buscar todos los productos
        /// </summary>
        /// <returns></returns>
        public List<Products> GetAllProducts()
        {
            var AllProducts = _context.Productos.ToList();

            return AllProducts;
        }

        /// <summary>
        /// Buscar por codigo de producto
        /// </summary>
        /// <param name="Code"></param>
        /// <returns></returns>
        public Products GetCode(string  Code) => _context.Productos.FirstOrDefault(na => na.Code == Code);

        /// <summary>
        /// Actulizar elemento de producto
        /// </summary>
        /// <param name="description"></param>
        /// <param name="products"></param>
        /// <returns></returns>
        public Products UpdateProduct(string description, VProducts products)
        {
            var _products = _context.Productos.FirstOrDefault(n => n.Description == description);

            if (_products != null)
            {
                _products.Code=products.Code;
                _products.Cost=products.Cost;
                _products.Unit=products.Unit;

                _context.SaveChanges();

            }
            return _products;


        }

        /// <summary>
        /// Eliminar por id de producto
        /// </summary>
        /// <param name="idproduct"></param>
        public void DeleteProduct(int idproduct)
        {
            var _products = _context.Productos.FirstOrDefault(n => n.IdProduct == idproduct);

            if (_products != null)
            {
                _context.Remove(_products);
                _context.SaveChanges();
            }

        }

    }

   
}
