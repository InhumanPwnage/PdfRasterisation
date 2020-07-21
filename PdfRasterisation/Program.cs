using PdfRasterisation.Helpers;
using PdfRasterisation.Services;
using System;
using System.Diagnostics;

namespace PdfRasterisation
{
    class Program
    {
        private static readonly string projectPath = $@"{AppDomain.CurrentDomain.BaseDirectory}";

        static void Main(string[] args)
        {
            var pdfs = FileHelper.GetPdfs($@"{projectPath}/input");

            Console.WriteLine("Beginning PDF Rasterisation tests --- ");

            Stopwatch stopWatch = new Stopwatch();

            var ironPdf = new IronPdfRasteriser();

            foreach (var pdf in pdfs)
            {
                ironPdf.RasterizePdf(pdf, $@"{projectPath}/output");
            }
            

            Console.WriteLine("End of PDF Rasterisation tests --- ");
            Console.ReadKey();
        }
    }
}
