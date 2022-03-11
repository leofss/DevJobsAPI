namespace DevJobsAPI.Controllers
{
    using DevJobsAPI.models;
    using Microsoft.AspNetCore.Mvc;
    using DevJobsAPI.Persistense;
    using DevJobsAPI.entities;

    [Route("api/job-vacancy/{id}/applications")]
    [ApiController]
    public class JobApplicationController : ControllerBase
    {
        private readonly DevJobsContext _context;
        public JobApplicationController(DevJobsContext context){
            _context = context;
        }

        //api/job-vacancy/{id}/applications
        [HttpPost]
        public IActionResult Post(int id,AddJobApplicationInputModel model){ 
            
            var jobvacancy = _context.JobVacancies
             .SingleOrDefault(jv => jv.Id == id);

              if(jobvacancy == null){
                return NotFound();
            }

            var application = new JobApplication(
                model.ApplicantName,
                model.ApplicantEmail,
                id 
            );
            _context.JobApplications.Add(application);
            _context.SaveChanges();

            return NoContent();
        }
    }
}