namespace MovieApp.Repositories;

public sealed class Actor
{
    public string Name { get; set; } = null!;
    public string National { get; set; } = null!;
    public int BirthYear { get; set; }
    public required ICollection<MovieActor> MovieActor { get; set; }
}