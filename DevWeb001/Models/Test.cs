using System.ComponentModel.DataAnnotations;

namespace DevWeb001.Models;

public class Test
{
    [Key]
    public int Id { get; set; }
    [MinLength(4)] 
    public string Name { get; set; }
    [MaxLength(9)]
    public string Number { get; set; }
}