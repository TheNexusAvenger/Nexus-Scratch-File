using System.Net;

namespace Nexus.Scratch.File;

public class Program
{
    /// <summary>
    /// Place id of the template to download.
    /// https://www.roblox.com/games/95206881/Baseplate
    /// </summary>
    public const ulong PlaceId = 95206881;
    
    /// <summary>
    /// File extension used for the downloaded file.
    /// </summary>
    public const string FileExtension = ".rbxl";
    
    /// <summary>
    /// Base URL to download files.
    /// </summary>
    public const string BaseDownloadUrl = "https://assetdelivery.roblox.com/v1/asset/?id=";
    
    /// <summary>
    /// Runs the program.
    /// </summary>
    /// <param name="args">Arguments from the command line.</param>
    public static void Main(string[] args)
    {
        // Download the template if it hasn't been download already.
        var downloadPath = Path.Combine(Path.GetTempPath(), PlaceId + FileExtension);
        if (!System.IO.File.Exists(downloadPath))
        {
            Console.WriteLine($"Downloading template place {PlaceId} to {downloadPath}");
            var httpClient = new HttpClient();
            var downloadResponse = httpClient.GetAsync(BaseDownloadUrl + PlaceId).Result;
            if (downloadResponse.StatusCode == HttpStatusCode.OK)
            {
                using var fileStream = System.IO.File.OpenWrite(downloadPath);
                downloadResponse.Content.CopyToAsync(fileStream).Wait();
                Console.WriteLine("Download complete.");
            }
            else
            {
                Console.WriteLine($"Error attempting to download file (HTTP {(int) downloadResponse.StatusCode})");
                Environment.Exit(-1);
            }
        }
        
        // Determine the file name.
        var fileName = "Baseplate";
        if (args.Length > 0)
        {
            fileName = args[0];
        }
        if (System.IO.File.Exists(fileName + FileExtension))
        {
            var baseFileName = fileName;
            var i = 1;
            do
            {
                fileName = $"{baseFileName} ({i})";
                i += 1;
            } while (System.IO.File.Exists(fileName + fileName));
        }
        
        // Copy the file.
        var targetPath = Path.GetFullPath(fileName + FileExtension);
        System.IO.File.Copy(downloadPath, targetPath);
        Console.WriteLine($"Created scratch file {targetPath}");
    }
}