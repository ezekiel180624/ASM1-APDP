namespace ASM1.Models
{
  public class Student : Person
  {
    public double Gpa { get; set; }

    public Department Department { get; set; }

    public List<Course> CoursesEnrolled { get; set; }

    public Student()
    {
      CoursesEnrolled = new List<Course>();
    }

    public Student(int id, string name, DateTime dateOfBirth,
      double gpa, Department department) : base(id, name, dateOfBirth)
    {
      Gpa = gpa;
      Department = department;
      CoursesEnrolled = new List<Course>();
    }

    public void EnrollCourse(Course course)
    {
      CoursesEnrolled.Add(course);
    }
  }
}
