using System.ComponentModel.DataAnnotations;

namespace DereksBlazorApp2.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required, StringLength(20)]
        public string Name { get; set; } = string.Empty;
        
        [StringLength(250)]
        public string Description { get; set; } = string.Empty;

        [StringLength(100)]
        public string ImageURL { get; set; } = string.Empty;

        [Range(0,6)]
        public int Type { get; set; } = 0;
    }
}
