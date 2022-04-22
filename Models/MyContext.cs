using Microsoft.EntityFrameworkCore;
namespace exam_01.Models
{
  public class MyContext : DbContext
  {
    public MyContext(DbContextOptions options) : base(options) { }
    public DbSet<User> Users { get; set; }
    public DbSet<Meetup> Meetups { get; set; }
    public DbSet<Reservation> Reservations { get; set; }
  }
}