using System;
using System.IO;
using Full_GRASP_And_SOLID.Library;

public class ConsoleRecipePrinter : IRecipePrinter
{
    public void PrintRecipe(Recipe recipe)
    {
        Console.WriteLine(recipe.GetTextToPrint());
    }

}