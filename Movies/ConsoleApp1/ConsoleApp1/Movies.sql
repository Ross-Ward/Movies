select * from Movies;
INSERT INTO Movies (Title, MovieId, SubtitlesYn, DateTimeAdd, Duration, GenreId, Rating, Director, Actors, Year)
VALUES ('Movie 2', 2, 0, '2025-05-17', 10, 20, 1.0, 'nulli', 'nully', 2010);
select Mov.Duration,DateTimeAdd,MovieId from Movies Mov ;