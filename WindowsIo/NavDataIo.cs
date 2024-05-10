using DanielSchiffer.HCS.Contracts.IOSIO;
using System.IO;
namespace DanielSchiffer.HCS.Logic.WindowsIo
{
    public class NavDataIo : INavDataIo
    {
        public string GetFsBuildImportFolder()
        {
            return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "HCS", "FSbuildImport");
        }
        public bool CreateFSbuildImportFolder()
        {
            bool IsErstellt = false;

            var ort = GetFsBuildImportFolder();
            if (!Directory.Exists(ort))
            {
                try
                {
                    Directory.CreateDirectory(ort);
                    // Create an empty file named 'FsBuild2.exe'
                    string filePath = Path.Combine(ort, "FsBuild2.exe");
                    File.Create(filePath).Close();
                    IsErstellt = true;
                }
                catch (Exception)
                {
                    return false;
                }
            }

            return IsErstellt;
        }
        public List<string> GetTextFromCycleInfo()
        {
            string pfad = Path.Combine(GetFsBuildImportFolder(), "cycle_info.txt");

            if (!File.Exists(pfad))
                return new List<string>();

            return File.ReadAllLines(pfad).ToList();

        }
    }
}
