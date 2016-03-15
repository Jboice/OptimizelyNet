using System;

// ReSharper disable InconsistentNaming

namespace OptimizelyNet.DTO
{
    public class Result
    {
        public string variation_id { get; set; }
        public string variation_name { get; set; }
        public string goal_id { get; set; }
        public string goal_name { get; set; }
        public string baseline_id { get; set; }
        public DateTime begin_time { get; set; }
        public DateTime end_time { get; set; }
        public ulong visitors { get; set; }
        public ulong conversions { get; set; }
        public decimal conversion_rate { get; set; }
        public string status { get; set; }
        public decimal improvement { get; set; }
        public decimal statistical_significance { get; set; }
        public decimal difference { get; set; }
        public decimal difference_confidence_interval_min { get; set; }
        public decimal difference_confidence_interval_max { get; set; }
        public ulong visitors_until_significance { get; set; }
        public bool is_revenue { get; set; }
    }
}
