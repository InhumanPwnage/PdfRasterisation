using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace PdfRasterisation.Helpers
{
    public static class FileHelper
    {
        

        public static string FileNameFromPath(this string pathToFile)
        {
            return Path.GetFileName(pathToFile);
        }

        public static string PrepareOutputDirectoryAndFileName(string pathToFile, string pathToSaveTo)
        {
            return $@"{pathToSaveTo}/{FileNameFromPath(pathToFile)}.png";
        }

        public static string[] GetPdfs(string pathToFiles)
        {
            return Directory.GetFiles(pathToFiles);
        }
    }
}
