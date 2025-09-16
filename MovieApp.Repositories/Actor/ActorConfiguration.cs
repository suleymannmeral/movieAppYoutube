
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MovieApp.Repositories.Actor;

public class ActorConfiguration : IEntityTypeConfiguration<Actor>
{
    public void Configure(EntityTypeBuilder<Actor> builder)
    {
          builder.HasKey(x => x.Id);
          builder.Property(x => x.Name).IsRequired().HasMaxLength(100);
          builder.Property(x => x.National).IsRequired().HasMaxLength(50);
          builder.Property(x => x.BirthYear).IsRequired();


    }
}
