using System.ComponentModel.DataAnnotations;

namespace ASM1.Models
{
  public class Account
  {
    public int Id { get; set; }

    [Required]
    public string Username { get; set; }

    [Required]
    public string Password { get; set; }

    public Person Person { get; set; }

    public bool IsActive { get; set; }

    public Account() { }

    public Account(string username, string password,
      Person person, bool isActive)
    {
      Username = username;
      Password = password;
      Person = person;
      IsActive = isActive;
    }
  }
}
