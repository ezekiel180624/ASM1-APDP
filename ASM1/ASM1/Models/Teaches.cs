namespace ASM1.Models
{
  public class Teaches
  {
    public int Id { get; set; }

    public Teacher Teacher { get; set; }

    public Course Course { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public Teaches() { }

    public Teaches(Teacher teacher, Course course,
      DateTime startDate, DateTime? endDate)
    {
      Teacher = teacher;
      Course = course;
      StartDate = startDate;
      EndDate = endDate;
    }
  }
}
