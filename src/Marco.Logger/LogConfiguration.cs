using System.ComponentModel.DataAnnotations;

namespace Marco.Logger
{
    public class LogConfiguration
    {
        [Required]
        public LogType? LogType { get; set; }

        public LogWriteType LogWriteType { get; set; } = LogWriteType.Console;
    }
}