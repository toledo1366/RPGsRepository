using System;
using System.Collections.Generic;

namespace RPGsRepo.Core.Models
{
    public class DnDClass
    {
        public string Index;
        public string Name;
        public string Url;
        public EquipmentCategory EquipmentCategory;
        public Equipment Equipment;
        public int Quantity;
        public EquipmentOption EquipmentOption;
    }

    public class ProficiencyChoice
    {
        public int Choose;
        public string Type;
        public List<DnDClass> From;
    }

    public class Proficiency
    {
        public string Index;
        public string Name;
        public string Url;
    }

    public class SavingThrows
    {
        public string Index;
        public string Name;
        public string Url;
    }

    public class Equipment
    {
        public string Index;
        public string Name;
        public string Url;
    }

    public class StartingEquipment
    {
        public Equipment Equipment;
        public int Quantity;
    }

    public class EquipmentCategory
    {
        public string Index;
        public string Name;
        public string Url;
    }

    public class EquipmentOption
    {
        public int Choose;
        public string Type;
        public DnDClass From;
    }

    public class StartingEquipmentOption
    {
        public int Choose;
        public string Type;
        public List<DnDClass> From;
    }

    public class AbilityScore
    {
        public string Index;
        public string Name;
        public string Url;
    }

    public class Prerequisite
    {
        public AbilityScore AbilityScore;
        public int MinimumScore;
    }

    public class MultiClassing
    {
        public List<Prerequisite> Prerequisites;
        public List<Proficiency> Proficiencies;
        public List<ProficiencyChoice> ProficiencyChoices;
    }

    public class Subclass
    {
        public string Index;
        public string Name;
        public string Url;
    }

    public class SpellcastingAbility
    {
        public string Index;
        public string Name;
        public string Url;
    }

    public class Info
    {
        public List<string> Desc;
        public string Name;
    }

    public class Spellcasting
    {
        public int Level;
        public SpellcastingAbility SpellcastingAbility;
        public List<Info> Info;
    }

    public class Root
    {
        public string Index;
        public string Name;
        public int HitDie;
        public List<ProficiencyChoice> ProficiencyChoices;
        public List<Proficiency> Proficiencies;
        public List<SavingThrows> SavingThrows;
        public List<StartingEquipment> StartingEquipment;
        public List<StartingEquipmentOption> StartingEquipmentOptions;
        public string ClassLevels;
        public MultiClassing MultiClassing;
        public List<Subclass> Subclasses;
        public Spellcasting Spellcasting;
        public string Spells;
        public string Url;
    }
}
