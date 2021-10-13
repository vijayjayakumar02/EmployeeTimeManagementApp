using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.ViewModels
{
    public class AdminDashboardViewModel
    {
        public string Email { get; set; }

        public TimeSpan? InTime { get; set; }

        public TimeSpan? OutTime { get; set; }

        public float? TotalBreakTime { get; set; }

        public float? TotalWorkingTime { get; set; }
    }
}
