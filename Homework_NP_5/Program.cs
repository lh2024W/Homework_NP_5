using System.Net;

namespace Homework_NP_5
{
    public class Program
    {
        static void Main()
        {
            string urlString = "https://cdn.pixabay.com/photo/2024/02/09/23/02/trees-8563877_1280.jpg";
            string fileCopy = @"C:\html\image.jpg";

            WebClient client = new WebClient();

            using (Stream stream = client.OpenRead(urlString))
            {
                using (FileStream fileStream = File.Create(fileCopy))
                {
                    stream.CopyTo(fileStream);
                }
            }

            Console.WriteLine("The file was successfully saved to the path: " + fileCopy);
        }
    }
}
