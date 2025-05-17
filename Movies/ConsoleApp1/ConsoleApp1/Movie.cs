using System.ComponentModel.DataAnnotations;

namespace ConsoleApp1;

public class Movie
{ //required means constructor needs variables set
    [Key]
    public required long MovieId { get; init; } // constant
    [Required, MaxLength(156)]
    public required string Title { get; set; }
    [Required]
    public required bool SubtitlesYn { get; set; }
    [Required]
    public required DateTime DateTimeAdd { get; set; }
    [Required]
    public required decimal Duration { get; set; }
    [Required]
    public required int GenreId { get; set; }
    [Required]
    public required decimal Rating { get; set; }
    [Required]
    public required string Director { get; set; }
    [Required, MaxLength(156)]
    public required string Actors { get; set; }
    [Required,MaxLength(156)]
    public required int Year { get; set; }
    // optional
    public string? Description { get; set; }
    
}

public abstract class Actor
{ 
    [Key]
    public required long ActorId { get; init; }
    
    [Required]
    public string Name { get; set; }
    
    [Required]
    public int Age { get; set; }
    
    
    public  decimal? Rating { get; set; }
    
}