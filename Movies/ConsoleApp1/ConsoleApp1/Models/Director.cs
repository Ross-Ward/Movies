using System.ComponentModel.DataAnnotations;

namespace ConsoleApp1.Models;

public class Director
{   
    //Build Director model
    [Key]
    public long DirectorId { get; init; }
    [Required, MaxLength(50)] 
    public string Name { get; set; }   
    [Required,Range(0, 76)]
    public int Age  { get; set; }
    [MaxLength(3)]
    public string Country { get; set; }
    [MaxLength(50)]
    public string City { get; set; }
    [MaxLength(50)]
    public decimal Rating { get; set; }
    
    
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
    public DateTime? DeletedAt { get; set; }
    public bool IsDeleted { get; set; }
}