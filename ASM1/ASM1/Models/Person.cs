namespace ASM1.Models
{
  public class Person
  {
      public int Id { get; set; }
      public string Name { get; set; }
      public DateTime DateOfBirth { get; set; }

    public Person(int id, string name, DateTime dateOfBirth)
    {
      Id = id;
      Name = name;
      DateOfBirth = dateOfBirth;
    }

  }
}
