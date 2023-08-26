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

        public static Game[] GetGames(){
            return games.ToArray();
        }

    };

   

    
