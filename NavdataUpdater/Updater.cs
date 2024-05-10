using DanielSchiffer.HCS.Logic.NavdataUpdater.Parsing;

using DanielSchiffer.HCS.Contracts.NavdataUpdaterContract;

namespace DanielSchiffer.HCS.Logic.NavdataUpdater
{
    public class Updater
    {
        private CycleInfoInterpreter cycleInfo;
        private readonly FsBuildPaser paser;

        public Updater(CycleInfoInterpreter cycle,FsBuildPaser paser)
        {
            cycleInfo = cycle;
            this.paser = paser;
        }
        public void startUpdate()
        {
            paser.StartParsing();
        }
        public string GetAirVersionFromFile()
        {
            string result = cycleInfo.GetAirVersion();

            return result;
        }

        public string? GetGueltigBisFromFile()
        {
            string result = cycleInfo.GetGueltigBis();
            return result;
        }

        public string GetGueltigVonFromFile()
        {
            string result = cycleInfo.GetGueltigVon();
            return result;
        }

    }
}
