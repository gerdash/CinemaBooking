using System;
using System.Collections.Generic;

namespace CinemaLogic.DB
{
    public partial class Screening
    {
        public int Id { get; set; }
        public DateTime StartTime1 { get; set; }
        public DateTime? StartTime2 { get; set; }
        public DateTime? StartTime3 { get; set; }
    }
}
