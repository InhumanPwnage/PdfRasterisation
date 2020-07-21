using System;
using System.Collections.Generic;
using System.Text;

namespace PdfRasterisation.Services
{
    public interface IIronPdfRasteriser
    {
        void RasterizePdf(string pathToPdf, string pathToSaveTo);
    }
}
