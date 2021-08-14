
namespace OverBookedAPI.Models;

/// <summary>
/// The Model for getting import data from the user
/// </summary>
public class FileImport
{
    /// <summary>
    /// The input file is converted to string
    /// </summary>
    public string ImportData { get; set; }

    /// <summary>
    /// If true, We assume a frontend converted the file to easy readable version.
    /// </summary>
    public bool? Simplified {  get; set; }
    public string? BrowserType {  get; set; }
}
