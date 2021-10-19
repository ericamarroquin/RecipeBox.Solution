using System.Collections.Generic;

namespace RecipeBox.Models
{
  public class Recipe
  {
    public Recipe()
    {
      this.JoinEntities = new HashSet<RecipeTag>();
    }

    public int RecipeId { get; set; }
    public string Description { get; set; }

    public virtual ICollection<RecipeTag> JoinEntities { get; }
  }
}