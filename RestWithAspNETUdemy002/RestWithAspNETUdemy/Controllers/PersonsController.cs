﻿using Microsoft.AspNetCore.Mvc;
using RestWithAspNETUdemy.Business.Interfaces;
using RestWithAspNETUdemy.Data.VO;

namespace RestWithAspNETUdemy.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonsController : Controller
    {
        private IPersonBusiness _personBusiness;

        public PersonsController(IPersonBusiness personBusiness)
        {
            _personBusiness = personBusiness;
        }

        // GET api/values
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(_personBusiness.FindAll());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var person = _personBusiness.FindById(id);
            if (person == null)
                return NotFound();

            return Ok(person);
        }

        // POST api/values
        [HttpPost]
        public ActionResult Post([FromBody] PersonVO person)
        {
            if (person == null)
                return BadRequest();

            return new ObjectResult(_personBusiness.Create(person));
        }

        // PUT api/values/5
        [HttpPut]
        public ActionResult Put(int id, [FromBody] PersonVO person)
        {
            if (person == null)
                return BadRequest();

            var updatedPerson = _personBusiness.Update(person);
            if (updatedPerson == null)
                return NoContent();

            return new ObjectResult(updatedPerson);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            _personBusiness.Delete(id);
            return NoContent();
        }
    }
}
