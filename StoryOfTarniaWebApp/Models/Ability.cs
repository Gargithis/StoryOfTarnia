using System.ComponentModel.DataAnnotations;

namespace StoryOfTarniaWebApp.Models
{
    public class Ability
    {
        [Key]
        public int AbilityID { get; set; }

        [Required]
        [StringLength(20, ErrorMessage = "Name cannot exceed 20 characters.")]
        public string AbilityName { get; set; }

        [Required]
        [MaxLength]
        public string AbilityDesc { get; set; }

        [Range(6, 40, ErrorMessage = "Score must be between 6 and 40.")]
        public int? AbilityScore { get; set; }

        [Range(-5, +12, ErrorMessage = "Modifier must be between -5 and +12.")]
        public int? AbilityModifier { get; set; }
    }
}
