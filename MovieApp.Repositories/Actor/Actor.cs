using MovieApp.Repositories.Abstractions;
using MovieApp.Repositories.JunctionsConfigurations;

namespace MovieApp.Repositories.Actor;

public sealed class Actor: BaseEntity
{
    public string Name { get; set; } = null!;
    public string National { get; set; } = null!;
    public int BirthYear { get; set; }
    public required ICollection<MovieActor> MovieActor { get; set; }
}