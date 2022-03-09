namespace DevJobsAPI.Controllers
{
    using DevJobsAPI.models;
    using Microsoft.AspNetCore.Mvc;

    [Route("api/job-vacancy/{id}/applications")]
    [ApiController]
    public class JobApplicationController : ControllerBase
    {
        [HttpPost]
        public IActionResult Post(int id,AddJobApplicationInputModel model){ 
            
            return NoContent();
        }
    }
}