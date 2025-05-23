﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {   // BuildING A SERVICE COLLECTION
        HostApplicationBuilder builder = Host.CreateApplicationBuilder(args);
        var services = new ServiceCollection();
        //DBCONTEXT SERVICE
        services.AddDbContext<MovieDbContext>(options => options.UseSqlite(@"Data Source=F:\Software Developement\Gamblingwithextrasteps\cs\Movies\ConsoleApp1\ConsoleApp1\Movies.db"));
        //DBSCOPE SERVICE
        services.AddScoped<SetupDb>();
        
        services.AddScoped<RestService>();
        //COMBINES SERVICE AND BUILDER collection
        
        var serviceProvider = services.BuildServiceProvider();
        // Resolve and use Movie Service
        using (var scope = serviceProvider.CreateScope())
        {
            var setupDb = scope.ServiceProvider.GetService<SetupDb>();
            setupDb.Setup();
        }
        using IHost host = builder.Build();
        host.Run();
        var m = new Movie
        {
            MovieId = 1,
            Title = "The movie : null",
            SubtitlesYn = false,
            DateTimeAdd = default,
            Duration = 120.5m,
            GenreId = 1,
            Rating = 5,
            Director = "null mcnull",
            Actors = "nullaig nullaird",
            Year = 2025,
        };
    }
}