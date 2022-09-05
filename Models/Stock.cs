using System.ComponentModel.DataAnnotations;

namespace Obliviate.Models
{
    public class Stock
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public float peRatio { get; set; } = 0;

        public Stock()
        {

        }
    }
}
