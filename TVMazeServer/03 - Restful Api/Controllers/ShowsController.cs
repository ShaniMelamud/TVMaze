using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TVMaze
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("EntireWorld")]
    public class ShowsController : ControllerBase
    {
        private readonly ShowsLogic logic;
        public ShowsController(ShowsLogic logic)
        {
            this.logic = logic;
        }
            
        [HttpGet]
        [Route("{searchText}")]
        public IActionResult GetShowsFromSearchText([FromRoute] string searchText)
        {
            try
            {
                List<Series> shows = logic.GetShowBySearchText(searchText);
                return Ok(shows);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}
