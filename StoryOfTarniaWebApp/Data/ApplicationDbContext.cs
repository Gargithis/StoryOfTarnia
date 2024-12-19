using Microsoft.EntityFrameworkCore;
using StoryOfTarniaWebApp.Models;

namespace StoryOfTarniaWebApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        { 
            
        }
        public DbSet<Ability> Abilities { get; set; }
        public DbSet<Feat> Feats { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ability>().HasData(
                new Ability { AbilityID = 1, AbilityName = "Strength", AbilityDesc = "Strength measures a character\'s physical power, including their ability to lift, push, pull, and perform feats of raw might. It\'s crucial for characters who rely on melee combat and physical prowess.", AbilityScore = 8, AbilityModifier = -1 },
                new Ability { AbilityID = 2, AbilityName = "Dexterity", AbilityDesc = "Dexterity represents agility, reflexes, and balance. It\'s critical for characters who rely on speed and precision, such as rogues and rangers.", AbilityScore = 8, AbilityModifier = -1 },
                new Ability { AbilityID = 3, AbilityName = "Constitution", AbilityDesc = "Constitution measures endurance and health. It determines how well a character resists physical stress, illness, and how much punishment they can take.", AbilityScore = 8, AbilityModifier = -1 },
                new Ability { AbilityID = 4, AbilityName = "Intelligence", AbilityDesc = "Intelligence reflects mental acuity, analytical ability, and memory. It’s vital for spellcasters like wizards and for understanding complex problems.", AbilityScore = 8, AbilityModifier = -1 },
                new Ability { AbilityID = 5, AbilityName = "Wisdom", AbilityDesc = "Wisdom reflects perception, intuition, and awareness of the world. It\'s crucial for clerics, druids, and other characters who rely on insight.", AbilityScore = 8, AbilityModifier = -1 },
                new Ability { AbilityID = 6, AbilityName = "Charisma", AbilityDesc = "Charisma measures force of personality, persuasiveness, and leadership. It\'s essential for characters like bards, sorcerers, and warlocks.", AbilityScore = 8, AbilityModifier = -1 }
                );

            modelBuilder.Entity<Feat>().HasData(
                new Feat { Id = 1, Tier = Tiers.TierType.Common, Name = "Alert",  Description = "+3 on Initiative"},
                new Feat { Id = 2, Tier = Tiers.TierType.Common, Name = "Attack Bonus", Description = "+1 on attack rolls" },
                new Feat { Id = 3, Tier = Tiers.TierType.Common, Name = "Toughness", Description = "+10 HP" },
                new Feat { Id = 4, Tier = Tiers.TierType.Heroic, Name = "Improved Attack Bonus", Prerequisite= "Attack Bonus", Description = "+2 on attack rolls" },
                new Feat { Id = 5, Tier = Tiers.TierType.Heroic, Name = "Empower Spell", Description = "+5 on spells cast for every class point spent" }
                );

            //modelBuilder.Entity<Character>().HasData(
            //    new Character
            //    {
            //        Id = 1,
            //        Name = "Alzramir(Alzi)",
            //        Race = "Elf",
            //        Class = "Wizard",
            //        Level = 8,
            //        Skills = { "Arcana", "Perception", "Academics" },
            //        ProficiencyBonus = +4,
            //        Feats = { Feat. },
            //        Powers = { }
            //    }
            //    );
        }
    }
}
