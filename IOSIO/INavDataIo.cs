namespace DanielSchiffer.HCS.Contracts.IOSIO
{
    public interface INavDataIo
    {
        bool CreateFSbuildImportFolder();
        string GetFsBuildImportFolder();
        List<string> GetTextFromCycleInfo();
    }
}