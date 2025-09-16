using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MovieApp.Repositories.Movie;

public class MovieConfiguration : IEntityTypeConfiguration<Movie>
{
    public void Configure(EntityTypeBuilder<Movie> builder)
    {
       builder.HasKey(m => m.Id);
       builder.Property(m => m.Title).IsRequired().HasMaxLength(50);
       builder.Property(m => m.Description).IsRequired().HasMaxLength(500);
       builder.Property(m => m.ReleaseDate).IsRequired();
       builder.Property(m => m.DurationInMinutes).IsRequired();

        builder.HasOne(m => m.Director)
            .WithMany(d => d.Movies)
            .HasForeignKey(m => m.DirectorId);

        
        
   

    }
}
