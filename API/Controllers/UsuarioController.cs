﻿using System;
using Microsoft.AspNetCore.Mvc;
using Domain.Entities;
using Domain.Interfaces;
using Service.Services;
using Service.Validators;
using Microsoft.AspNetCore.Cors;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{

    [Route("api/[controller]")]
    public class UsuarioController : Controller
    {  

        private IService<Usuario> service = new UsuarioService<Usuario>();
          
        [HttpGet]
        public IActionResult Get()

        {
            try
            {
                return new ObjectResult(service.Get());
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        //api/person/byId?id=1
        [HttpGet("byId")]
        public IActionResult Get(int id)
        {
            try
            {
                return new ObjectResult(service.GetId(id));
            }
            catch (ArgumentException ex)
            {
                return NotFound(ex);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        // POST api/<controller>
        [HttpPost]        
        public IActionResult Post([FromBody]Usuario value)
        {
            try
            {
                service.Post<UsuarioValidator>(value);

                return new OkObjectResult(value.Id);
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

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public IActionResult Put([FromBody]Usuario value)
        {
            try
            {               
                service.Put<UsuarioValidator>(value);

                return new ObjectResult(value);
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

        //DELETE api/controller/1
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                service.Remove(id);
                return NoContent();
            }
            catch (ArgumentException ex)
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
