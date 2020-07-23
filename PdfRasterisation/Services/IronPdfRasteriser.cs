using IronPdf;
using PdfRasterisation.Helpers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;


namespace PdfRasterisation.Services
{
    public class IronPdfRasteriser : IIronPdfRasteriser
    {
        /// <summary>
        /// From https://ironpdf.com/examples/rasterize-a-pdf-to-images/
        /// To save Bitmaps as images https://docs.microsoft.com/en-us/dotnet/api/system.drawing.image.save?view=dotnet-plat-ext-3.1
        /// </summary>
        /// <param name="pathToPdf"></param>
        /// <param name="pathToSaveTo"></param>
        public void RasterizePdf(string pathToPdf, string pathToSaveTo)
        {
            //Example rendering PDF documents to Images or Thumbnails
            var pdf = PdfDocument.FromFile(pathToPdf);

            //Extract all pages to a folder as image files
            //pdf.RasterizeToImageFiles(@"C:\image\folder\*.png");

            //Dimensions and page ranges may be specified
            //pdf.RasterizeToImageFiles(@"C:\image\folder\thumbnail_*.jpg", 100, 80);

            //Extract all pages as System.Drawing.Bitmap objects
            Bitmap[] pageImages = pdf.ToBitmap();

            // Save the image as a PNG.
            // image in pageImages
            for (int i = 0; i < pageImages.Length; i++ )
            {
                //FileHelper.PrepareOutputDirectoryAndFileName(pathToPdf, pathToSaveTo)
                pageImages[i].Save(
                    FileHelper.PrepareOutputDirectoryAndFileName(
                        FileHelper.FileNameForImage("IronPDF", pathToPdf, (i + 1)),
                        pathToSaveTo), 
                    System.Drawing.Imaging.ImageFormat.Png);

                pageImages[i].Dispose();
            }
        }

        //No non-sense PDF rasteriser. Rasterises as seen when viewing normally in PDF format.
    }
}
