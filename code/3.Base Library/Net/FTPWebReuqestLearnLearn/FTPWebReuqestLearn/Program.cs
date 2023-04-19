using System.Net;

namespace FTPClientLearn
{
    public class Program
    {
        public static void Main(string[] args)
        {
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create("ftp://example.com/remote/path/file.txt");
            request.Method = WebRequestMethods.Ftp.UploadFile;
            request.Credentials = new NetworkCredential("username", "password");

            using(Stream stream = File.OpenRead(@"C:\local\path\file.txt"))
            using(Stream requestStream = request.GetRequestStream())
            {
                stream.CopyTo(requestStream);
            }

            using(FtpWebResponse response = (FtpWebResponse)request.GetResponse())
            {
                Console.WriteLine($"Status code: {response.StatusCode}, upload status: {response.StatusDescription}");
            }
        }

    }
}
