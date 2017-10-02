using Microsoft.EntityFrameworkCore;
using RRAstro.Core.Domain.QuestionAns;

namespace RRAstro.Repository
{
    public class RRAstroDBContext:DbContext
    {
        public RRAstroDBContext(DbContextOptions<RRAstroDBContext> options) : base(options)
        {

        }
        public DbSet<Reply> Replys { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<QuestionTopic> QuestionTopics { get; set; }
       
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<QuestionTopic>().ToTable("Replys", schema: "dbo");
            modelBuilder.Entity<QuestionTopic>().ToTable("Questions", schema: "dbo");
            modelBuilder.Entity<QuestionTopic>().ToTable("QuestionTopics", schema: "dbo");
        }

    }
}
