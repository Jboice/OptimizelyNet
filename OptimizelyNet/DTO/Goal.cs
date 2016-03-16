using System;
using System.Collections.Generic;

// ReSharper disable InconsistentNaming

namespace OptimizelyNet.DTO
{
    public class Goal
    {
        public bool is_editable { get; set; }
        public bool target_to_experiments { get; set; }
        public bool archived { get; set; }
        public string description { get; set; }
        public string id { get; set; }
        public List<string> target_urls { get; set; }
        public string title { get; set; }
        public string event_name { get; set; }
        public List<string> url_match_types { get; set; }
        public string project_id { get; set; }
        public int goal_type { get; set; }
        public List<string> experiment_ids { get; set; }
        public string selector { get; set; }
        public DateTime created { get; set; }
        public DateTime last_modified { get; set; }
        public List<string> target_url_match_types { get; set; }
        public List<string> urls { get; set; }
    }
}
