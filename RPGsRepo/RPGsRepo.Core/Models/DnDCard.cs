using System.Collections.Generic;

namespace RPGsRepo.Core.Models
{
    public class DnDCard:BaseCard
    {
        public AbilityScores[] abilityScores { get; set; }
        public List<SavingThrows> SavingThrows { get; set; }


        public DnDCard()
        {
            abilityScores = new AbilityScores[6];
            abilityScores[0] = new AbilityScores
            {
                Name = "Strength",
                Value = 0,
                Modifier = 0
            };
            abilityScores[1] = new AbilityScores
            {
                Name = "Dexterity",
                Value = 0,
                Modifier = 0
            };
            abilityScores[2] = new AbilityScores
            {
                Name = "Constitution",
                Value = 0,
                Modifier = 0
            };
            abilityScores[3] = new AbilityScores
            {
                Name = "Inteligence",
                Value = 0,
                Modifier = 0
            };
            abilityScores[4] = new AbilityScores
            {
                Name = "Wisdom",
                Value = 0,
                Modifier = 0
            };
            abilityScores[5] = new AbilityScores
            {
                Name = "Charisma",
                Value = 0,
                Modifier = 0
            };
        }

    }
}