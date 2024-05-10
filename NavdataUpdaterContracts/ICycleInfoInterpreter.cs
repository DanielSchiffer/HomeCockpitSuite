namespace DanielSchiffer.HCS.Contracts.NavdataUpdaterContract
{
    public interface ICycleInfoInterpreter
    {
        string GetAirVersion();
        string GetGueltigBis();
        string GetGueltigVon();
    }
}