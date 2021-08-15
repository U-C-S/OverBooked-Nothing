using Microsoft.AspNetCore.Mvc;
using OverBookedAPI.Models;
using System.Text;
using System.Xml;
using System.Xml.Linq;

namespace OverBookedAPI.Controllers;

[Route("api/import")]
[ApiController]
public class ImportBookmarksController : ControllerBase
{
    private readonly ILogger<ImportBookmarksController> _logger;

    public ImportBookmarksController(ILogger<ImportBookmarksController> logger)
    {
        _logger = logger;
    }

    //[HttpGet]
    //public string Get(string x, bool y)
    //{
    //    return new FileImport
    //    {
    //        ImportData = x + "__lol",
    //        Simplified = y
    //    }.ImportData;
    //}


    [HttpPost]
    public string Post(IFormFile file, bool simplified)
    {
        string thedata = "Null";
        var x = file.OpenReadStream();
        return XMLRead(x);

        //x.ReadBytes((int) file.OpenReadStream().Length).

        /*
        byte[] b = new byte[1024];
        UTF8Encoding temp = new UTF8Encoding(true);
        while (x.Read(b, 0, b.Length) > 0)
        {
            thedata = temp.GetString(b);
        }

        var FileX = new FileImport()
        {
            ImportData = thedata,
            Simplified = simplified
        };
        */
        //return XMLRead(FileX.ImportData);
        //return file.FileName;
        //return FileX.ImportData;
    }

    private string XMLRead(Stream data)
    {
        try
        {
            XDocument xml = XDocument.Load(data);
            //XmlDocument xmlDoc = new XmlDocument();
            //xmlDoc.LoadXml(data);
            return xml.Root.Value;
        }
        catch (Exception ex)
        {
            return ex.ToString();
        }
    }
}
