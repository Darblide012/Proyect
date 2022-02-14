using Microsoft.AspNetCore.Mvc;
using promad.Bussines;
using promad.Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace promad.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Products : Controller
    {
        public ManagerProducts _managerProducts;

        public Products( ManagerProducts managerProducts)
        {
            _managerProducts = managerProducts;
        }

        /// <summary>
        /// Enviar Producto
        /// </summary>
        /// <param name="products"></param>
        /// <returns></returns>
        [HttpPost("add - Products")]
        public IActionResult AddProduct([FromBody] VProducts products)
        {
            _managerProducts.AddProducts(products);
            return Ok();

        }

        /// <summary>
        /// Mostrar todo los productos
        /// </summary>
        /// <returns></returns>
        [HttpGet("get-all-product")]
        public IActionResult getallproduct()
        {
            var allProduct = _managerProducts.GetAllProducts();
            return Ok(allProduct);

        }

        /// <summary>
        /// Mostrar los productos por codigo
        /// </summary>
        /// <param name="Code"></param>
        /// <returns></returns>
        [HttpGet("get-Product")]
        public IActionResult getProduct(string Code)
        {
            var codo = _managerProducts.GetCode(Code);      
            return Ok(Code);
        }


        /// <summary>
        /// Actualizar por descripcion
        /// </summary>
        /// <param name="Desc"></param>
        /// <param name="products"></param>
        /// <returns></returns>
        [HttpPut("Update-description")]
        public IActionResult UpdateDescription(string Desc, [FromBody] VProducts products)
        {
            var UpdateDescription = _managerProducts.UpdateProduct(Desc, products);

            return Ok(UpdateDescription);

        }
      
        /// <summary>
        /// Eliminar por producto
        /// </summary>
        /// <param name="idProduct"></param>
        /// <returns></returns>
        [HttpDelete("DeleteIDProduct")]
        public IActionResult DeleteProductbyId(int idProduct)
        {
            _managerProducts.DeleteProduct(idProduct);

            return Ok();


        }
    }
}
