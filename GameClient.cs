using GameStore.Client.Models;

namespace GameStore.Client;
public static class GameClient
{
    public static readonly List<Game> games = new()
        {
            new Game(){
                Id = 1,
                Name = "Street Fighter II",
                Genre = "Fighting",
                Price = 19.99M,
                RealeaseDate = new DateTime(1991,2,1)
            },
            new Game(){
                Id = 2,
                Name = "Final Fantasy XIV",
                Genre = "RolePlaying",
                Price = 59.99M,
                RealeaseDate = new DateTime(2010,9,12)
            },
            new Game(){
                Id = 3,
                Name = "FIFA",
                Genre = "Sports",
                Price = 69.99M,
                RealeaseDate = new DateTime(2022,8,21)

            }
        };

    public static Game[] GetGames()
    {
        return games.ToArray();
    }

    public static void AddGame(Game game)
    {
        game.Id = games.Max(game => game.Id) + 1;
        games.Add(game);
    }

    public static Game GetGame(int id){
        return games.Find(game => game.Id == id) ??
         throw new Exception("Could not find game!");
    }

    public static void UpdateGame(Game updatedGame){
        
        Game existingGame = GetGame(updatedGame.Id);
        existingGame.Name = updatedGame.Name;
        existingGame.Genre = updatedGame.Genre;
        existingGame.Price = updatedGame.Price;
        existingGame.RealeaseDate = updatedGame.RealeaseDate;

    }

    public static void DeleteGame(int id){
        
        Game gameSelected = GetGame(id);
        games.Remove(gameSelected);

    }

};




