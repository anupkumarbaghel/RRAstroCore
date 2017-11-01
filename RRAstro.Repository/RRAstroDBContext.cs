using Microsoft.EntityFrameworkCore;
using RRAstro.Core.Domain.QuestionAns;
using RRAstro.Core.Domain.KundaliReq;
using RRAstro.Core.Domain.GetColorStone;
using RRAstro.Core.Domain.BookApp;

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
       
        public DbSet<KundaliRequest> KundaliReqs { get; set; }
        public DbSet<ColorStoneReq> ColorStoneReqs { get; set; }

        public DbSet<BookAppointment> BookAppointments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<QuestionTopic>().ToTable("Replys", schema: "dbo");
            modelBuilder.Entity<QuestionTopic>().ToTable("Questions", schema: "dbo");
            modelBuilder.Entity<QuestionTopic>().ToTable("QuestionTopics", schema: "dbo");
            //For Kundali Request
            modelBuilder.Entity<KundaliRequest>().ToTable("KundaliReqs", schema: "dbo");
            //For Color Stone Request
            modelBuilder.Entity<ColorStoneReq>().ToTable("ColorStoneReqs", schema: "dbo");
            //For booking the appointment
            modelBuilder.Entity<BookAppointment>().ToTable("BookAppointments", schema: "dbo");

        }

    }
}
