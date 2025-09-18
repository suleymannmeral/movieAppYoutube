using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MovieApp.Repositories.JunctionsConfigurations;

public class MovieActorConfiguration : IEntityTypeConfiguration<MovieActor>
{
    public void Configure(EntityTypeBuilder<MovieActor> builder)
    {
       
        builder.HasKey(ma => new { ma.MovieId, ma.ActorId }); // Composite primary key
        builder.HasOne(ma => ma.Movie)
            .WithMany(m => m.MovieActors)
            .HasForeignKey(ma => ma.MovieId);

        builder.HasOne(ma => ma.Actor)
            .WithMany(a => a.MovieActor)
            .HasForeignKey(ma => ma.ActorId);
    }
}
