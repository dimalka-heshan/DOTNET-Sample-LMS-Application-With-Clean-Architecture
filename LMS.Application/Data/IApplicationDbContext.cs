using LMS.Core.Entities;
using Microsoft.EntityFrameworkCore;


namespace LMS.Application.Data
{
    public interface IApplicationDbContext 
    {
         DbSet<Student> Students { get; set; }
         DbSet<Principal> Principals { get; set; }
         DbSet<Administrator> Administrators { get; set; }
         DbSet<Classes> Classes { get; set; }
         DbSet<Subject> Subjects { get; set; }
         DbSet<Teacher> Teachers { get; set; }
         DbSet<Grade> Grades { get; set; }
    }
}
