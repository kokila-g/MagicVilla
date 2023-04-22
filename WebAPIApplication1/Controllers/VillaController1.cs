using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPIApplication1.Models;

namespace WebAPIApplication1.Controllers
{
    public class VillaController1 : ApiController
    {
        // GET api/<controller>
        public IEnumerable<Villa> GetVilla()
        {
            return new List<Villa>
            {
                new Villa {Id=1,Name="pool view"},
                new Villa {Id=2,Name="lake view"}
            };
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}