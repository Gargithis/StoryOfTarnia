using System.ComponentModel.DataAnnotations;
using static StoryOfTarniaWebApp.Models.Tiers;

namespace StoryOfTarniaWebApp.Models
{
    public class Feat
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Tier is required.")]
        public TierType Tier { get; set; }
        [Required(ErrorMessage = "Name is required.")]
        [StringLength(100, ErrorMessage = "Name cannot exceed 100 characters.")]
        public string Name { get; set; }
        public string? Prerequisite { get; set; }
        [Required(ErrorMessage = "Description is required.")]
        public string Description { get; set; }

    }
}
