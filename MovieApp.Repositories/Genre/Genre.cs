using MovieApp.Repositories.Abstractions;
using MovieApp.Repositories.JunctionsConfigurations;

namespace MovieApp.Repositories.Genre;
public sealed class Genre:BaseEntity
{
    public string Name { get; set; } = null!;
    public required ICollection<MovieGenre> MovieGenres { get; set; }
}