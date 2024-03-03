namespace ASM1.Models
{
  public class Teacher : Person
  {
    public string Subject { get; set; }

    public Department Department { get; set; }

    public List<Course> CoursesTaught { get; set; }

    public Teacher()
    {
      CoursesTaught = new List<Course>();
    }

    public Teacher(int id, string name, DateTime dateOfBirth,
      string subject, Department department)
      : base(id, name, dateOfBirth)
    {
      Subject = subject;
      Department = department;
      CoursesTaught = new List<Course>();
    }

    public void TeachCourse(Course course)
    {
      CoursesTaught.Add(course);
    }
  }
}
