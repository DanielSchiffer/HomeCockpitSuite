using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanielSchiffer.HCS.Shared.DTO
{
    public class Fortschritt
    {
        public int Gesamtfortschritt { get; set; }
        public int WorkItemFortschritt { get; set; }
        public string WorkItemTest { get; set; } = "";
        public string WorkItemName { get; set; } = "";
    }
}
