namespace DevJobsAPI.entities
{
    public class JobApplication
    {
        public JobApplication(int id, string applicantName, string applicantEmail, int idjobVacancy) 
        {
                ApplicantName = applicantName;
                ApplicantEmail = applicantEmail;
                IdJobVacancy = idjobVacancy;
               
        }
               public int Id { get; private set; }

       public string ApplicantName { get; private set; }
       public string ApplicantEmail { get; private set; }
       public int IdJobVacancy { get; private set; }
       
       
        
    }
}