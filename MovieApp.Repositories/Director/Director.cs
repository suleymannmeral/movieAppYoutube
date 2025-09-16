using MovieApp.Repositories.Abstractions;

namespace MovieApp.Repositories.Director;

public sealed class Director:BaseEntity
{
    public string Name { get; set; } = null!;
    public string National { get; set; } = null!;
    public required  ICollection<Movie> Movies { get; set; }
}