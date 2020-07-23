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

        public static string FileNameForImage(string prefix, string pathToFile, int? index)
        {
            var indexString = index.HasValue ? (string.Format("{0:D3}", index)) : string.Empty;

            return $"[{prefix}]_{Path.GetFileName(pathToFile)}_{indexString}";
        }
        
        

        public static string PrepareOutputDirectoryAndFileName(string fileName, string pathToSaveTo)
        {
            return $@"{pathToSaveTo}/{FileNameFromPath(fileName)}.png";
        }

        public static string[] GetPdfs(string pathToFiles)
        {
            return Directory.GetFiles(pathToFiles);
        }
    }
}
