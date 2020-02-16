using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using DependencyInjection.IServices;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjection.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        //private readonly IStringHelper _stringHelper;

        //public ValuesController(IStringHelper stringHelper)
        //{
        //    _stringHelper = stringHelper;
        //}

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get([FromServices] IStringHelper _stringHelper)
        {
            Debug.WriteLine(_stringHelper.IsPalindrome("CIVIC"));
            Debug.WriteLine(_stringHelper.Reverse("Naveen"));

            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
