namespace DevJobsAPI.Controllers
{

    using Microsoft.AspNetCore.Mvc;

    [Route("api/job-vacancy ")]
    [ApiController]
    public class JobVacancyController : ControllerBase
    {
        //api/job-vacancy 
        [HttpGet]
        public Task<IActionResult> Get()
        {
            
            
            return Ok();
        }
    }
}