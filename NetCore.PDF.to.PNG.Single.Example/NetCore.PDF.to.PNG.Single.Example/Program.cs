using Cloudmersive.APIClient.NETCore.DocumentAndDataConvert.Api;
using Cloudmersive.APIClient.NETCore.DocumentAndDataConvert.Client;
using System;

namespace NetCore.PDF.to.PNG.Single.Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting...");

            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");



            var apiInstance = new ConvertDocumentApi();
            var inputFile = new System.IO.FileStream("C:\\temp\\inputfile", System.IO.FileMode.Open); // System.IO.Stream | Input file to perform the operation on.

            byte[] result = apiInstance.ConvertDocumentPdfToPngSingle(inputFile);

            Console.WriteLine("Done.");
        }
    }
}
