namespace ConsoleApp1;
//edit
public class SetupDb
{
    private readonly MovieDbContext _dbContext;
    private readonly RestService _restService;

    public SetupDb(MovieDbContext dbContext, RestService restService)
    {
        _dbContext = dbContext;
        _restService = restService;
    }
    public void Setup()
    {
        // Ensure database is created
        _dbContext.Database.EnsureCreated();

        // Add sample data if none exists
        if (!_dbContext.Movies.Any())
        {
            _dbContext.Movies.AddRange(
               
            );
            _dbContext.SaveChanges();
        }

        // Query and display data
        foreach (var Movie in _dbContext.Movies)
        {
            Console.WriteLine($"MovieID={Movie.MovieId}\tTitle={Movie.Title}\t{Movie.SubtitlesYn}\tDateTimeAdd={Movie.DateTimeAdd}");
        }
    }
}