using System;
using System.Collections.Generic;
using System.Linq;

namespace VideoGames
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Creates list of videogames including name, genre, and rating
            List<VideoGame> games = new List<VideoGame>
            {
                new VideoGame {Name = "Super Mario Bros.", Genre = "Platform", Rating = 4.5},
                new VideoGame {Name = "Grand Theft Auto", Genre = "Action-adventure", Rating = 4.4},
                new VideoGame {Name = "Luigi's Mansion 3", Genre = "Adventure", Rating = 4.6},
                new VideoGame {Name = "Mario Kart 8 Deluxe", Genre = "Racing", Rating = 4.0},
                new VideoGame {Name = "Fruit Ninja", Genre = "Action", Rating = 4.5}

            };

//LINQ query that creates a new list that contains only the games with 4 or higher
            var topRatedGames = (from game in games
                              where game.Rating >= 4
                              select game).ToList();

//LINQ query to sort topRatedGames by name
            var sortedGames = (from game in topRatedGames
                               orderby game.Name
                               select game).ToList();

//Foreach loop that will print list of games
            foreach (var game in sortedGames)
            {
                //Prints out list
                Console.WriteLine(game.Name);
            }
        }
    }
}