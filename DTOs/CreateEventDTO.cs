using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BravvoxAPITesting.DTOs
{
    public class CreateEventDTO
    {
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public string Details { get; set; }
        public DateTimeOffset EventStartTime { get; set; }
        public DateTimeOffset EventEndTime { get; set; }
        public Uri Location { get; set; }
        public bool IsModerated { get; set; }
        public bool IsPostingOpen { get; set; }
        public bool IsPublic { get; set; }
        public bool RequireAttendeeApproval { get; set; }
    }
}

