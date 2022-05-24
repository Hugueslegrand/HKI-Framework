using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation_Framework.Models
{
    /// <summary>
    /// LoggerConfiguration Model
    /// </summary>
    public class LoggerConfiguration
    {
        /// <summary>
        /// Path where log files will be saved
        /// </summary>
        public string LogsPath { get; set; }
        /// <summary>
        /// Enable logger or not
        /// </summary>
        public bool EnableLog { get; set; }
    }
}
