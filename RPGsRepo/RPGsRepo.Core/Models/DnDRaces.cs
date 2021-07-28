using System;
using System.Collections.Generic;

namespace RPGsRepo.Core.Models
{
    public class DnDRaces
    {

        public class AbilityScore
        {
            public string Index { get; set; }
            public string Name { get; set; }
            public string Url { get; set; }
        }

        public class AbilityBonus
        {
            public AbilityScore AbilityScore { get; set; }
            public int Bonus { get; set; }
        }

        public class StartingProficiency
        {
            public string Index { get; set; }
            public string Name { get; set; }
            public string Url { get; set; }
        }

        public class From
        {
            public string Index { get; set; }
            public string Name { get; set; }
            public string Url { get; set; }
        }

        public class StartingProficiencyOptions
        {
            public int Choose { get; set; }
            public string Type { get; set; }
            public List<From> From { get; set; }
        }

        public class Language
        {
            public string Index { get; set; }
            public string Name { get; set; }
            public string Url { get; set; }
        }

        public class Trait
        {
            public string Index { get; set; }
            public string Name { get; set; }
            public string Url { get; set; }
        }

        public class Subrace
        {
            public string Index { get; set; }
            public string Name { get; set; }
            public string Url { get; set; }
        }

        public class Root
        {
            public string Index { get; set; }
            public string Name { get; set; }
            public int Speed { get; set; }
            public List<AbilityBonus> AbilityBonuses { get; set; }
            public string Alignment { get; set; }
            public string Age { get; set; }
            public string Size { get; set; }
            public string SizeDescription { get; set; }
            public List<StartingProficiency> StartingProficiencies { get; set; }
            public StartingProficiencyOptions StartingProficiencyOptions { get; set; }
            public List<Language> Languages { get; set; }
            public string LanguageDesc { get; set; }
            public List<Trait> Traits { get; set; }
            public List<Subrace> Subraces { get; set; }
            public string Url { get; set; }
        }
    }
}
