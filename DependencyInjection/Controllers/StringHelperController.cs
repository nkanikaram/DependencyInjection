using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DependencyInjection.IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjection.Controllers
{
    [Route("[controller]/[action]/")]
    [ApiController]
    [Produces("application/json")]
    public class StringHelperController : ControllerBase
    {
        private readonly IStringHelper _stringHelper;

        public StringHelperController(IStringHelper stringHelper)
        {
            _stringHelper = stringHelper;
        }

        [HttpGet]
        public ActionResult<bool> GetPalindrome(string str)
        {
            return _stringHelper.IsPalindrome(str);
        }
        [HttpGet]
        public ActionResult<string> GetReverse(string str)
        {
            return _stringHelper.Reverse(str);
        }
    }
}