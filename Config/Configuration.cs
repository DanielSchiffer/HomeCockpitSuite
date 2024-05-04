using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanielSchiffer.HCS.Logic.Settings
{
    public class Configuration
    {
        public bool EntwicklerModus { get; set; }
        public string? PilotsName { get;  set; }
        public string? SimBriefUser { get;  set; }
    }
}
