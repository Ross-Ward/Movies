using System.ComponentModel.DataAnnotations;

namespace ConsoleApp1.Models;

public class Actor
{   
    //Build actor model
    [Key]
    public long ActorId { get; init; }
    [Required, MaxLength(50)] 
    public string Name { get; set; }   
    [Required, Range(0, 76)]
    public required DateTime DateTimeAdd { get; set; }
        [Required]

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