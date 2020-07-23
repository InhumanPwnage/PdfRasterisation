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

            //var ironPdf = new IronPdfRasteriser();
            //ironPdf.RasterizePdf(pdfs[0], $@"{projectPath}/output");

            var dynamicPdf = new DynamicPdfRasteriser();
            dynamicPdf.RasterisePdf(pdfs[0], $@"{projectPath}/output");

            Console.WriteLine("End of PDF Rasterisation tests --- ");
            Console.ReadKey();
        }

        public static void RunTests(string[] pdfs)
        {
            Stopwatch stopWatch = new Stopwatch();

            var ironPdf = new IronPdfRasteriser();
            var dynamicPdf = new DynamicPdfRasteriser();

            foreach (var pdf in pdfs)
            {
                stopWatch.Start();
                ironPdf.RasterizePdf(pdf, $@"{projectPath}/output");
                stopWatch.Stop();

                Console.WriteLine($@"[IronPDF] {FileHelper.FileNameFromPath(pdf)} took {stopWatch.ElapsedMilliseconds} ms");
                stopWatch.Reset();

                stopWatch.Start();
                dynamicPdf.RasterisePdf(pdf, $@"{projectPath}/output");
                stopWatch.Stop();

                Console.WriteLine($@"[DynamicPDF] {FileHelper.FileNameFromPath(pdf)} took {stopWatch.ElapsedMilliseconds} ms");
                stopWatch.Reset();
            }
        }
    }
}
