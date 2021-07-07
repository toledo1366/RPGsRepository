using System;
using System.Collections.Generic;

namespace RPGsRepo.Core.Models
{
    public class DnDClass
    {
        public string index { get; set; }
        public string name { get; set; }
        public string url { get; set; }
        public EquipmentCategory equipment_category { get; set; }
        public Equipment equipment { get; set; }
        public int quantity { get; set; }
        public EquipmentOption equipment_option { get; set; }
    }

    public class ProficiencyChoice
    {
        public int choose { get; set; }
        public string type { get; set; }
        public List<DnDClass> from { get; set; }
    }

    public class Proficiency
    {
        public string index { get; set; }
        public string name { get; set; }
        public string url { get; set; }
    }

    public class SavingThrow
    {
        public string index { get; set; }
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Equipment
    {
        public string index { get; set; }
        public string name { get; set; }
        public string url { get; set; }
    }

    public class StartingEquipment
    {
        public Equipment equipment { get; set; }
        public int quantity { get; set; }
    }

    public class EquipmentCategory
    {
        public string index { get; set; }
        public string name { get; set; }
        public string url { get; set; }
    }

    public class EquipmentOption
    {
        public int choose { get; set; }
        public string type { get; set; }
        public DnDClass from { get; set; }
    }

    public class StartingEquipmentOption
    {
        public int choose { get; set; }
        public string type { get; set; }
        public List<DnDClass> from { get; set; }
    }

    public class AbilityScore
    {
        public string index { get; set; }
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Prerequisite
    {
        public AbilityScore ability_score { get; set; }
        public int minimum_score { get; set; }
    }

    public class MultiClassing
    {
        public List<Prerequisite> prerequisites { get; set; }
        public List<Proficiency> proficiencies { get; set; }
    }

    public class Subclass
    {
        public string index { get; set; }
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Root
    {
        public string index { get; set; }
        public string name { get; set; }
        public int hit_die { get; set; }
        public List<ProficiencyChoice> proficiency_choices { get; set; }
        public List<Proficiency> proficiencies { get; set; }
        public List<SavingThrow> saving_throws { get; set; }
        public List<StartingEquipment> starting_equipment { get; set; }
        public List<StartingEquipmentOption> starting_equipment_options { get; set; }
        public string class_levels { get; set; }
        public MultiClassing multi_classing { get; set; }
        public List<Subclass> subclasses { get; set; }
        public string url { get; set; }
    }

}
