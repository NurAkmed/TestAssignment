using System;
using Microsoft.AspNetCore.Mvc;
using TestAssignment.ResultClasses;


namespace TestAssignment.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NumberController : Controller
    {
        private readonly ResultArray _resultArray;

        public NumberController(ResultArray resultArray)
        {
            _resultArray = resultArray;
        }
        
        [HttpGet("{num:int}")]
        public ActionResult<string> Get(int num)
        {
            return Ok(String.Join(String.Empty, _resultArray.Results(num)));
        }
    }
}