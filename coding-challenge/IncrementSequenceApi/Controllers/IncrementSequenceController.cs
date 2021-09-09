using IncrementSequenceApi.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IncrementSequenceApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IncrementSequenceController : ControllerBase
    {
        [AllowAnonymous]
        [HttpPost("GetIncreasingSequence")]
        public IActionResult GetIncreasingSequence([FromBody] string input)
        {
            return Ok(IncrementSequenceService.GetIncreasingSequence(input));
        }
    }
}
