using System;

// ReSharper disable InconsistentNaming

namespace OptimizelyNet.DTO
{
    public class Variation
    {
        public bool is_paused { get; set; }
        public string description { get; set; }
        public int weight { get; set; }
        public DateTime created { get; set; }
        public string section_id { get; set; }
        public string js_component { get; set; }
        public string experiment_id { get; set; }
        public string project_id { get; set; }
        public string id { get; set; }
    }
}
