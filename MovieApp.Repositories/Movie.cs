
using MovieApp.Repositories.Abstractions;

namespace MovieApp.Repositories;

public class Movie: BaseEntity
{
    public string Title { get; set; } = null!;
    public uint MovieLenght { get; set; }
    public DateTime ReleaseDate { get; set; }
    public string Description { get; set; } = null!;
    public int DirectorId { get; set; }


}