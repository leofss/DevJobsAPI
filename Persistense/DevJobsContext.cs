using DevJobsAPI.entities;
using Microsoft.EntityFrameworkCore;

namespace DevJobsAPI.Persistense
{
    public class DevJobsContext : DbContext
    {
        public DevJobsContext(DbContextOptions<DevJobsContext> options) : base(options) {

            
        }
        
        public DbSet<JobVacancy> JobVacancies {get; set;}
        public DbSet<JobApplication> JobApplications {get; set;}

        protected override void OnModelCreating(ModelBuilder builder){
            builder.Entity<JobVacancy>(e => {
                e.HasKey(jv => jv.Id);
                //e.ToTable("tb_vaga");
                e.HasMany(jv => jv.Applications)
                .WithOne()
                .HasForeignKey(ja => ja.Id)
                .OnDelete(DeleteBehavior.Restrict);
            });

            builder.Entity<JobApplication>(e =>{
                e.HasKey(ja => ja.Id);
            });
        }
    }
}