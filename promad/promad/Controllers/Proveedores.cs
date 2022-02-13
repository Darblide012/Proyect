using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using promad.Bussines;
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

        [HttpPost("add - supplier")]
        public IActionResult AddSupplier([FromBody] supplier supplier)
        {
            _managerProveedores.Addsupplier(supplier);
            
            return Ok();

        }

        [HttpGet("get-all-supplier")]
        public IActionResult getallSupplier()
        {
            var allsupplier = _managerProveedores.GetAllsupplier();
            return Ok(allsupplier);

        }


        [HttpGet("get-Supplier")]
        public IActionResult getSupplier(string Code)
        {
           
            var code = _managerProveedores.GetCode(Code);
            return Ok(Code);
        }



    }
}

