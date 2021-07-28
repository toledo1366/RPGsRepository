using System;
using System.Collections.Generic;

namespace RPGsRepo.Core.Models
{
    public class Skills
    {
        public string Index { get; set; }
        public string Name { get; set; }
        public List<string> Desc { get; set; }
        public AbilityScore AbilityScore { get; set; }
        public string Url { get; set; }
    }
}
