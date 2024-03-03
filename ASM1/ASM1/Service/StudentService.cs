using ASM1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace ASM1.Service
{
    public class StudentService
    {
        private readonly StudentContext _context;

        public StudentService(StudentContext context)
        {
            _context = context;
        }

        public Student AddStudent(Student student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();
            return student;
        }

        // other methods

        public List<Student> GetStudentsByDepartment(int departmentId)
        {
            return _context.Students
              .Include(s => s.Department)
              .Where(s => s.DepartmentId == departmentId)
              .ToList();
        }
    }

    //In Startup.cs

    public void ConfigureServices(IServiceCollection services)
    {
        services.AddDbContext<StudentContext>(options =>
           options.UseSqlServer(Configuration.GetConnectionString("Default"));

        services.AddScoped<StudentService>();

        // other services
    }
}
