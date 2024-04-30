using System.ComponentModel.DataAnnotations;

namespace WorkingWithSeriLog.Models;

public class Person
{
    [Key]
    public int Id { get; set; }
    [MaxLength(10)]
    public string Name { get; set; }
    [MaxLength(20)]
    public string Surname { get; set; }
    [Range(1, 120)]
    public int Age { get; set; }
}
