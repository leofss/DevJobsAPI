namespace DevJobsAPI.models
{
    public record AddJobVacancyInputModel(
        string title,
        string descriprition,
        string Company,
        bool IsRemote,
        string SalaryRange)
    {
        //record simplifica a criação de objetos

    }
}