namespace DevJobsAPI.Controllers
{
    using DevJobsAPI.models;
    using Microsoft.AspNetCore.Mvc;
    using DevJobsAPI.Persistense;
    using DevJobsAPI.entities;

    [Route("api/job-vacancy ")]
    [ApiController]
    public class JobVacancyController : ControllerBase
    {
        private readonly DevJobsContext _context;
        public JobVacancyController(DevJobsContext context){
            _context = context;
        }
        //GET api/job-vacancy 
        [HttpGet]
        public IActionResult GetAll()
        {
            var jobvacancies = _context.JobVacancies;

            return Ok(jobvacancies);
        }
        
        //GET api/vacancy/4 - obtem pelo parametro
        [HttpGet("{id}")]
        public IActionResult GetById(int id){
            var jobvacancy = _context.JobVacancies
            .SingleOrDefault(jv => jv.Id == id);

            if(jobvacancy == null){
                return NotFound();
            }
            return Ok();
        }

        //POST api/job-vacancy
        [HttpPost]
        public IActionResult Post(AddJobVacancyInputModel model){
            var jobvacancy = new JobVacancy(
                model.title,
                model.descriprition,
                model.Company,
                model.IsRemote,
                model.SalaryRange

            );
            _context.JobVacancies.Add(jobvacancy);
            return CreatedAtAction("GetById", new {id = jobvacancy.Id}, jobvacancy);
        }

        //PUT api/vacancy/4
        [HttpPut("{id}")]
        public IActionResult Put(int id, UpdateJobVacancyInputModel model){
            var jobvacancy = _context.JobVacancies
            .SingleOrDefault(jv => jv.Id == id);

            if(jobvacancy == null){
                return NotFound();
            }
            jobvacancy.Update(model.Title, model.Description);
            return NoContent();
        }
    }
}