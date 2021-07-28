using System;
namespace RPGsRepo.Core.Models
{
    public class BaseCard
    {
        public string CharacterName { get; set; }
        public string PlayerName { get; set; }
        public int CharacterLevel { get; set; }
        public DnDRaces Race { get; set; }
        public DnDClass Class { get; set; }
        public int ExpPoints { get; set; }
    }
}
