using DevJobsAPI.entities;

namespace DevJobsAPI.Persistense
{
    public class DevJobsContext
    {
        public DevJobsContext(){
            JobVacancies = new List<JobVacancy>();
        }
        public List<JobVacancy> JobVacancies {get; set;}
    }
}