
using MovieApp.Repositories.Abstractions;

namespace MovieApp.Repositories;

public class Movie: BaseEntity
{
    public string Title { get; set; } = null!;
    public DateTime ReleaseDate { get; set; }
    public int DurationInMinutes { get; set; }
    public string Description { get; set; }  = null!;

    // Director relationship
    public int DirectorId { get; set; }
    public Director Director { get; set; }

    public ICollection<MovieActor> MovieActors { get; set; }
    public ICollection<MovieGenre>MovieGenres { get; set; }


}