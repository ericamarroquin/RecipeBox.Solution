using System.Collections.Generic;

namespace Recipe.Models
{
  public class Recipe
  {
    public Recipe()
    {
      this.JoinEntities = new HashSet<CategoryRecipe>();
    }

    public int RecipeId { get; set; }
    public string Description { get; set; }
    public virtual ApplicationUser User { get; set; }

    public virtual ICollection<TagRecipe> JoinEntities { get;}
  }
}