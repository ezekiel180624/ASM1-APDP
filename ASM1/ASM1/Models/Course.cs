using System.ComponentModel.DataAnnotations;

namespace ASM1.Models
{
  public class Course
  {
    public int Id { get; set; }

    [Required]
    public string Name { get; set; }

    public string Code { get; set; }

    public string Semester { get; set; }

    public Department Department { get; set; }

    public List<Subject> Subjects { get; set; }

    public List<Student> Students { get; set; }

    public List<Teacher> Teachers { get; set; }

    public Course()
    {
      Subjects = new List<Subject>();
      Students = new List<Student>();
      Teachers = new List<Teacher>();
    }

    public Course(int id, string name, string code, string semester,
      Department department)
    {
      Id = id;
      Name = name;
      Code = code;
      Semester = semester;
      Department = department;

      Subjects = new List<Subject>();
      Students = new List<Student>();
      Teachers = new List<Teacher>();
    }
  }
}
