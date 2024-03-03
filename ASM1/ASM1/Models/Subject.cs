using System.ComponentModel.DataAnnotations;

namespace ASM1.Models
{
  public class Subject
  {
    public int Id { get; set; }

    [Required]
    public string Name { get; set; }

    public string Code { get; set; }

    public List<Course> Courses { get; set; }

    public Subject()
    {
      Courses = new List<Course>();
    }

    public Subject(int id, string name, string code)
    {
      Id = id;
      Name = name;
      Code = code;

      Courses = new List<Course>();
    }
  }
}
