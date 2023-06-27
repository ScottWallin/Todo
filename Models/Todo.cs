using System.ComponentModel.DataAnnotations;

namespace Todo.Models;

public class ToDo
{
  public ToDo(int id, string name, int? minutes, string description, bool? completed)
  {
    Id = Id;
    Name = name;
    Minutes = minutes;
    Description = description;
    Completed = completed;
  }

  public int Id { get; set; }
  [Required]
  public string Name { get; set; }
  public int? Minutes { get; set; }
  public string Description { get; set; }
  public bool? Completed { get; set; }
}