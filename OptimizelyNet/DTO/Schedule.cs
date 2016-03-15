using System;

// ReSharper disable InconsistentNaming

namespace OptimizelyNet.DTO
{
    public class Schedule
    {
        public string status { get; set; }
        public DateTime start_time { get; set; }
        public DateTime stop_time { get; set; }
        public string experiment_id { get; set; }
        public string id { get; set; }
    }
}
