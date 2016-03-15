using System;
using System.Collections.Generic;

// ReSharper disable InconsistentNaming

namespace OptimizelyNet.DTO
{
    public class Experiment
    {
        public string id { get; set; }
        public int percentage_included { get; set; }
        public List<string> display_goal_order_lst { get; set; }
        public bool is_multivariate { get; set; }
        public string project_id { get; set; }
        public List<string> variation_ids { get; set; }
        public string status { get; set; }
        public List<UrlCondition> url_conditions { get; set; }
        public string description { get; set; }
        public DateTime last_modified { get; set; }
        public string activation_mode { get; set; }
        public string details { get; set; }
        public string custom_css { get; set; }
        public DateTime created { get; set; }
        public string custom_js { get; set; }
        public string primary_goal_id { get; set; }
        public string experiment_type { get; set; }
        public string shareable_results_link { get; set; }
        public string edit_url { get; set; }
        public List<string> audience_ids { get; set; }
    }
}