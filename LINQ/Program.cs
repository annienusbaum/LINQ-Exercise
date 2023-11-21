namespace LINQ
{
    public class Program
    {
        static void Main()
        {
            List<string> videoGames = new List<string>
            {
                "The Legend of Zelda",
                "Minecraft",
                "Fortnite",
                "Overwatch"
            };

            var orderedGames = videoGames.OrderBy(game => game.Length);

            Console.WriteLine("Ordered List of Games by Length:");
            foreach (var game in orderedGames)
            {
                Console.WriteLine(game);
            }
        }
    }
}

//OrderBy is my method
//lambda expression used with OrderBy method is (game => game.Length) - key selector


//

//1.create a list of type string.

//2.Populate the list with video game names

//3.Order the list of games by tthe length of the game name.
///- Remember to use LINQ which involves using a lambda expression
///-Use the list of common LINQ methods on the lecture page for help on deciding which method(s) to use:
///Use Method Syntax for this exercise.
//Stage, Commit, and Push your work to Github.

