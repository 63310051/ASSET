using System.ComponentModel.DataAnnotations;
using API.DTOs.StockDtos;

namespace API.DTOs.AssetDtos
{
    public class CreateAssetDto
    {
        [Required]
        public string Id { get; set; }

        [Required]
        public int No { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Type { get; set; }

        [Required]
        public OwnerDto Owner { get; set; }

        [Required]
        public string Manufacturer { get; set; }

        [Required]
        public string Model { get; set; }

        [Required]
        public StockDto Stock { get; set; }
    }

}