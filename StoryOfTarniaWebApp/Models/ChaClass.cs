using StoryOfTarniaWebApp.Migrations;

namespace StoryOfTarniaWebApp.Models
{
    public class ChaClass
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Character_Abilities> MainAbilities { get; set; }
        public List<string> Features { get; set; }
    }
}
