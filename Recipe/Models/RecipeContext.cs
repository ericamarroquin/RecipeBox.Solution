using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Recipe.Models
{
  public class RecipeContext : IdentityDbContext<ApplicationUser>
  {
    public DbSet<Tag> Tags { get; set; }
    public DbSet<Recipe> Recipes { get; set; }
    public DbSet<TagRecipe> TagRecipe { get; set; }

    public RecipeContext(DbContextOptions options) : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseLazyLoadingProxies();
    }
  }
}