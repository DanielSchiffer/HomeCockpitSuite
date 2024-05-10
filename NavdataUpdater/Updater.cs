using DanielSchiffer.HCS.Contracts.NavdataUpdaterContract;

namespace DanielSchiffer.HCS.Logic.NavdataUpdater
{
    public class Updater
    {
        private ICycleInfoInterpreter cycleInfo;

        public Updater(ICycleInfoInterpreter cycle)
        {
            cycleInfo = cycle;
        }
        public string? GetAirVersionFromFile()
        {
            string result = cycleInfo.GetAirVersion();

            return result;
        }

        public string? GetGueltigBisFromFile()
        {
            string result = cycleInfo.GetGueltigBis();
            return result;
        }

        public string? GetGueltigVonFromFile()
        {
            string result = cycleInfo.GetGueltigVon();
            return result;
        }

    }
}
