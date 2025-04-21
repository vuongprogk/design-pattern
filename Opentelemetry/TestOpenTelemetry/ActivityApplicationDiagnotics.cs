using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOpenTelemetryConsole
{
    public static class ActivityApplicationDiagnotics
    {
        public static string ActivityName { get; set; } = "TestOpenTelemetryConsole.ActivityApplicationDiagnotics";
        public static ActivitySource ActivitySource => new ActivitySource(ActivityName);
    }
}
