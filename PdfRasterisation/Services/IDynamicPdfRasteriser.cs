using System;
using System.Collections.Generic;
using System.Text;

namespace PdfRasterisation.Services
{
    public interface IDynamicPdfRasteriser
    {
        void RasterisePdf(string pathToFile, string pathToSaveTo);
    }
}
