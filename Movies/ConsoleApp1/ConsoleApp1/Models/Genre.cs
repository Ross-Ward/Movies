using System.ComponentModel.DataAnnotations;
namespace ConsoleApp1.Models;

public class Genre
{   
    public long GenreId { get; set; }
    [Required, MaxLength(50)]
    public string Name { get; set; }
    [Required, MaxLength(50)]
    public string Description { get; set; }
    
    
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
    public DateTime? DeletedAt { get; set; }
    public bool IsDeleted { get; set; }
}