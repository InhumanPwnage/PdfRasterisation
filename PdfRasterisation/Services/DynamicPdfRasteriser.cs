using ceTe.DynamicPDF.Rasterizer;
using PdfRasterisation.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace PdfRasterisation.Services
{
    public class DynamicPdfRasteriser : IDynamicPdfRasteriser
    {
        /// <summary>
        /// From NuGet, named ceTe.DynamicPDF.Rasterizer.NET
        /// Online https://www.dynamicpdf.com/Rasterizer-PDF-.NET.aspx
        /// To note: https://www.dynamicpdf.com/docs/dotnet/rasterizer-limitations
        /// Example https://www.dynamicpdf.com/docs/dotnet/cete.dynamicpdf.rasterizer.pdfrasterizer
        /// </summary>
        /// <param name="pathToFile"></param>
        /// <param name="pathToSaveTo"></param>
        public void RasterisePdf(string pathToFile, string pathToSaveTo)
        {
            // Create a PdfRasterizer object.
            PdfRasterizer rasterizer = new PdfRasterizer(pathToFile);

            // Save the image.
            //TiffImageFormat.TiffWithLzw
            rasterizer.Draw(FileHelper.PrepareOutputDirectoryAndFileName(pathToFile, pathToSaveTo), PngImageFormat.Png, ImageSize.Dpi72);
        }
    }
}
