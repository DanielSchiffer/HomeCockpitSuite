using System.IO;
namespace DanielSchiffer.HCS.Logic.WindowsIo
{
    public class NavDataIo
    {
        public bool createFSbuildImportFolder(string ort)
        {
            bool IsErstellt = false;

            ort = ort + "\\FSbuildImport";
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
    }
}
