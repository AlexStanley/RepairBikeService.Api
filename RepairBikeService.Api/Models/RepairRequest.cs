using System.ComponentModel.DataAnnotations;

namespace RepairBikeService.Api.Models
{
    public class RepairRequest
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Description { get; set; }
    }
}
