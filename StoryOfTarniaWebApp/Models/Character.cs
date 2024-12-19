namespace StoryOfTarniaWebApp.Models
{
    public class Character
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }
        public string Race { get; set; }
        public string Class { get; set; }
        public List<string> Skills { get; set; }
        public int ProficiencyBonus { get; set; }
        public List<Feat> Feats { get; set; }
        //public List<string> CommonFeats { get; set; }
        //public List<string> HeroicFeats { get; set; }
        public List<Power> Powers { get; set; }
        //public List<string> Rank1Powers { get; set; }
        //public List<string> Rank2Powers { get; set; }
        //public List<string> Rank3Powers { get; set; }
    }
}
