using System;
using Microsoft.AspNetCore.Mvc;
using Domain.Entities;
using Service.Services;
using Service.Validators;

namespace API.Controllers
{
    [Route("api/[controller]")]
    public class LoginController : Controller
    {  
        private UsuarioService<Usuario> service = new UsuarioService<Usuario>();
          
        // POST api/<controller>
        [HttpPost]        
        public IActionResult Post([FromBody]Usuario value)
        {
            try
            {
                service.PostLogin<UsuarioValidator>(value);                     
                return Ok(value);
            }
            catch (ArgumentNullException ex)
            {
                return NotFound(ex);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }


    }
}
