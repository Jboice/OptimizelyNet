using System;

// ReSharper disable InconsistentNaming

namespace OptimizelyNet.DTO
{
    public class UrlCondition
    {
        public int index { get; set; }
        public string match_type { get; set; }
        public DateTime created { get; set; }
        public string value { get; set; }
        public DateTime last_modified { get; set; }
        public bool negate { get; set; }
    }
}