﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CatFacts.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        // GET: api/<UserController>
        // Get Random Fact,
        // Returns a random fact,
        [HttpGet]
        public IEnumerable<string> Get()
        {
            CatLogic clgic = new CatLogic();
            yield return clgic.GetRndmFact();

            //return new string[] { "value1", "value2" };
        }

        // GET api/<UserController>/5
        // Get a list of facts,
        // Returns a a list of facts,
        [HttpGet("{id}")]
        public IEnumerable<string> Get(int id)
        {
            CatLogic clgic = new CatLogic();
            yield return clgic.Getallfact(id);
            //return "value";
        }

        //// POST api/<UserController>
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT api/<UserController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<UserController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
