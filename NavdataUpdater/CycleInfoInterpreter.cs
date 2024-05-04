using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DanielSchiffer.HCS.Logic.WindowsIo;


namespace DanielSchiffer.HCS.Logic.NavdataUpdater;

public class CycleInfoInterpreter
{
    private NavDataIo navDataIo;
    private List<string> cycleText;

    public CycleInfoInterpreter(NavDataIo io)
    {
        navDataIo = io;
        cycleText = navDataIo.GetTextFromCycleInfo();
    }

    public string GetAirVersion()
    {
        var line = cycleText.Find(x => x.Contains("AIRAC cycle"));
        var version = line?.Split(new[] { ":" }, StringSplitOptions.None)?[1]?.Trim();
        return version is null ? "-" :version;
    }

    public string GetGueltigBis()
    {
        var line = cycleText.Find(x => x.Contains("Valid "));
        var wert = line?.Split(new[] { ":" }, StringSplitOptions.None)[1];
        if (wert is null)
            return "-";
        var datum = wert.Split(new[] { " - " }, StringSplitOptions.None)[1];
        return datum;

    }

    public string GetGueltigVon()
    {
        var line = cycleText.Find(x => x.Contains("Valid "));
        var wert = line?.Split(new[] { ":" }, StringSplitOptions.None)[1];
        if (wert is null)
            return "-";
        var datum = wert.Split(new[] { " - " }, StringSplitOptions.None)[0];
        return datum;

    }
}
