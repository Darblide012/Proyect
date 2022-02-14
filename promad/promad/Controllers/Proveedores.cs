using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using promad.Bussines;
using promad.Data.Model;
using promad.Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace promad.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Proveedores : ControllerBase
    {
        public ManagerProveedores _managerProveedores;

        public Proveedores(ManagerProveedores managerProveedores)
        {
            _managerProveedores = managerProveedores;

        }

        /// <summary>
        /// Agregar Proovedor
        /// </summary>
        /// <param name="supplier"></param>
        /// <returns></returns>
        [HttpPost("add - supplier")]
        public IActionResult AddSupplier([FromBody] VSupplier supplier)
        {
            _managerProveedores.Addsupplier(supplier);
            
            return Ok();

        }


        /// <summary>
        /// Mostrar todos los proovedores
        /// </summary>
        /// <returns></returns>
        [HttpGet("get-all-supplier")]
        public IActionResult getallSupplier()
        {
            var allsupplier = _managerProveedores.GetAllsupplier();
            return Ok(allsupplier);

        }


        /// <summary>
        /// Mostrar por Codigo de proveedor
        /// </summary>
        /// <param name="Code"></param>
        /// <returns></returns>
        [HttpGet("get-Supplier")]
        public IActionResult getSupplier(string Code)
        {
           
            var code = _managerProveedores.GetCode(Code);
            return Ok(Code);
        }


        /// <summary>
        /// Actualizar por id de razon social
        /// </summary>
        /// <param name="RFC"></param>
        /// <param name="supplier"></param>
        /// <returns></returns>
        [HttpPut("Update- razon social")]
        public IActionResult UpdateRazonSocial(string RFC, [FromBody] VSupplier supplier)
        {
            var UpdateRFC = _managerProveedores.UpdatesRazonsocial(RFC,supplier);

            return Ok(UpdateRFC);

        }



        /// <summary>
        /// Eliminar proveedor por id
        /// </summary>
        /// <param name="idSupplier"></param>
        /// <returns></returns>
        [HttpDelete("DeleteIDsupplier")]
        public IActionResult DeleteidSupplier(int idSupplier)
        {
            _managerProveedores.DeleteSupplierByid(idSupplier);

            return Ok();


        }

    }
}

