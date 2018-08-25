using System.Linq;

namespace ConsoleApp1
{
    public static class FileProcessing
    {
        public static int CheckFileCount()
        {
            string archivePath = @"C:\FileTest\";
            
            string searchExistingFile = "SupplierExtract_UK_MRI_20180304092338";
            string[] files = System.IO.Directory.GetFiles(archivePath, string.Concat(searchExistingFile, "*"));
            int count = files.Count();
            string archiveFile = string.Concat(archivePath, searchExistingFile, "_", count.ToString(), ".txt");

            return count;
        }
    }
}
