using System.ComponentModel.DataAnnotations;

namespace ASM1.Models
{
  public class Department
  {
    public int Id { get; set; }

    [Required]
    public string Name { get; set; }

    public string Code { get; set; }

    public List<Teacher> Teachers { get; set; }

    public List<Student> Students { get; set; }

    public List<Course> Courses { get; set; }

    public Department()
    {
      Teachers = new List<Teacher>();
      Students = new List<Student>();
      Courses = new List<Course>();
    }

    public Department(int id, string name, string code)
    {
      Id = id;
      Name = name;
      Code = code;

      Teachers = new List<Teacher>();
      Students = new List<Student>();
      Courses = new List<Course>();
    }
  }
}
