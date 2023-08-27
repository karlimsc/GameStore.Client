using System.ComponentModel.DataAnnotations;

namespace GameStore.Client.Models
{
    public class Game
    {
        public int Id { get; set; }
        [Required]
        [StringLength(10)]
        public required string Name { get; set; }

        [Required]
        [StringLength(20)]
        public required string Genre { get; set; }

        [Range(1, 200)]
        public decimal Price { get; set; }
        public DateTime RealeaseDate { get; set; }

    }
}