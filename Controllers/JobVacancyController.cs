namespace DevJobsAPI.Controllers
{
    using DevJobsAPI.models;
    using Microsoft.AspNetCore.Mvc;

    [Route("api/job-vacancy ")]
    [ApiController]
    public class JobVacancyController : ControllerBase
    {
        //GET api/job-vacancy 
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok();
        }
        
        //GET api/vacancy/4 - obtem pelo parametro
        [HttpGet("{id}")]
        public IActionResult GetById(int id){
            return Ok();
        }

        //POST api/job-vacancy
        [HttpPost]
        public IActionResult Post(AddJobVacancyInputModel model){
            return Ok();
        }

        //PUT api/vacancy/4
        [HttpPut("")]
        public IActionResult Put(UpdateJobVacancyInputModel model){
            return NoContent();
        }
    }
}