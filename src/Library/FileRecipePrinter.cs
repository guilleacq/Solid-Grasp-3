using System.IO;
using Full_GRASP_And_SOLID.Library;

public class FileRecipePrinter : IRecipePrinter
{
    public void PrintRecipe(Recipe recipe)
    {
        File.WriteAllText("Recipe.txt", recipe.GetTextToPrint());
    }

    public void PrintRecipeAtPath(Recipe recipe, string destinationPath)
    {
        File.WriteAllText(destinationPath, recipe.GetTextToPrint());
    }
}