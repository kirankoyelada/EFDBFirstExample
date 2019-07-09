using System;
using System.Collections.Generic;

namespace test.Models
{
    public partial class DataLoader
    {
        public int Id { get; set; }
        public string JobId { get; set; }
        public string JobName { get; set; }
        public string TaskName { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public string EnqueuedTime { get; set; }
        public string Status { get; set; }
        public string CommonStatus { get; set; }
        public string Message { get; set; }
        public string Source { get; set; }
        public string TimeStamp { get; set; }
    }
}
