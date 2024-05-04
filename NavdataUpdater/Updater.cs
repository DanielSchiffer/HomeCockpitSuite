namespace DanielSchiffer.HCS.Logic.NavdataUpdater
{
    public class Updater
    {
        private CycleInfoInterpreter cycleInfo;

        public Updater(CycleInfoInterpreter cycle)
        {
            cycleInfo = cycle;
        }
        public string? GetAirVersionFromFile()
        {
            string result = cycleInfo.GetAirVersion();

            return result;
        }

        public string? getGueltigBisFromFile()
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
