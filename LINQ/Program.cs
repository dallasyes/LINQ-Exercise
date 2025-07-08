namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            var games = new List<string> { "League Of Legends", "Team Fight Tactics", "Hearthstone" };
            List<string> orderedGames = games.OrderBy(g => g.Length).ToList();
        }
    }
}
