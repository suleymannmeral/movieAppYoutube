namespace MovieApp.Repositories;
public sealed class Genre
{
    public string Name { get; set; } = null!;
    public required ICollection<MovieGenre> MovieGenres { get; set; }
}