using Business;
using Data.Model;
using Microsoft.VisualBasic;
using System.Net;

RecipeBusiness recipeBusiness = new RecipeBusiness();

Console.WriteLine("Virtual Recipe Book");
Console.WriteLine("-----‐--------------------------");
Console.WriteLine("Input the following commands using the given numbers: \n");
Console.WriteLine("1. Show all recipes \n2. Show recipes with cook time less than + [input amount in minutes int] \n3. Show full recipe + [input recipe (id)] \n4. Search by Meal Course \n5. Quit Program");

string command = "";

//I put the entire thing in a while function so that I can make multiple commands in one start of application.
while (command != "5") {
    Console.WriteLine("\n\n");
    switchCaseProg(Console.ReadLine());
}
void switchCaseProg(string command) {
    string[] commandArr = command.Split(' ');
    switch (commandArr[0])
    {
        case "1": showall(); break;
        case "2": if (commandArr.Length > 1 && int.TryParse(commandArr[1], out int n)) { showallWithTime(n); } else { Console.WriteLine("Please follow input directions."); }; break;
        case "3": if (commandArr.Length > 1 && int.TryParse(commandArr[1], out int n1)) { showByID(n1); } else { Console.WriteLine("Please follow input directions."); }; break;
            //I'm using Int.TryParse to check if there is a value after command num.
        case "4": showAllMealCourse(); break;
        case "5": Environment.Exit(0); break;
        default: Console.WriteLine("Incorrect input."); break;
    }
}
void showall()
{
    Console.WriteLine("\n\n");
    foreach (Recipe rec in recipeBusiness.GetAll()) {
        Console.WriteLine($"ID: {rec.ID} || Name of Recipe: {rec.Name}");
    }
}
void showallWithTime(int CookTime)
{
    Console.WriteLine("\n\n");
    foreach (Recipe rec in recipeBusiness.GetAll()) {
        if(rec.CookingTime <= CookTime) {
            Console.WriteLine($"ID: {rec.ID} || Name of Recipe: {rec.Name} || Cooking Time: {rec.CookingTime}.");
        }
    }
}
void showAllMealCourse() {
    Console.WriteLine("\n\n");
    Console.WriteLine("Input number of meal course: ");
    Console.WriteLine("\n1. Breakfast & Brunch\n2. Lunch\n3. Appetizers & Snacks\n4. Salads\n5. Side Dishes\n6. Soups\n7. Bread\n8. Drinks\n9. Desserts\n10. Sauces\n11. Other\n\n");
    string[] listMC = { "Breakfast & Brunch", "Lunch", "Appetizers & Snacks", "Salads", "Side Dishes", "Soups", "Bread", "Drinks", "Desserts", "Sauces", "Other" };
    if (int.TryParse(Console.ReadLine(), out int mc) && mc < 12 && mc > 0)
    {
        Console.WriteLine("\n\n");
        foreach (Recipe rec in recipeBusiness.GetAll())
        {
            if (Array.IndexOf(listMC, rec.MealCourse) == (mc - 1))
            {
                Console.WriteLine($"ID: {rec.ID} || Name of Recipe: {rec.Name} || Meal Course: {rec.MealCourse}.");
            }
        }
    }
    else {
        Console.WriteLine("\n\nInput was either not a number or not in the range of 1 to 11.");
    }
}
void showByID(int ID)
{
    Console.WriteLine("\n\n");
    Recipe rec = recipeBusiness.Get(ID);
    if (rec != null)
    {
        Console.WriteLine($"\n\n{rec.Name} \n{rec.MealCourse}\n\nCooking Time: {rec.CookingTime} \nYield: {rec.Yield}\nThis recipe is {rec.Tags}. \n\nIngredients: \n\n{rec.Ingredients} \n\nInstructions: \n\n{rec.Instructions} \n\nNotes: \n\n{rec.Notes} \n\nSource of recipe: {rec.SourceOfRec}");
    }
    else {
        Console.WriteLine("ID of recipe not found in Database.");
    }
}