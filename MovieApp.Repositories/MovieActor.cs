﻿namespace MovieApp.Repositories;

public sealed class MovieActor
{
    public int MovieId { get; set; }
    public Movie Movie { get; set; } = null!;
    public int ActorId { get; set; }
    public Actor Actor { get; set; } = null!;

    public string RoleName { get; set; } = null!;
}
