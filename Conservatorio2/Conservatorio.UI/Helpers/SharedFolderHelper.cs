using System.Configuration;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net;

namespace Conservatorio.UI.Helpers
{
    public class SharedFolderHelper
    {
        private static readonly string ImageFolder = ConfigurationManager.AppSettings["imagesFolder"];
        private static readonly string ImagesFolderNetwork = ConfigurationManager.AppSettings["imagesFolderNetwork"];
        private static readonly string ImagesFolderUser = ConfigurationManager.AppSettings["imagesFolderUser"];
        private static readonly string ImagesFolderPassword = ConfigurationManager.AppSettings["imagesFolderPassword"];

        private static string GetCompleteFilePath(string fileName)
        {
            return string.Format("{0}\\{1}", ImageFolder, fileName);
        }

        private static NetworkCredential NetworkCredentials
        {
            get
            {
                return new NetworkCredential(string.Format("{0}\\{1}", ImagesFolderNetwork, ImagesFolderUser), ImagesFolderPassword);
            }
        }

        public static Image GetImage(string fileName)
        {
            using (new NetworkConnection(ImageFolder, NetworkCredentials))
            {
                var bytes = File.ReadAllBytes(GetCompleteFilePath(fileName));
                var ms = new MemoryStream(bytes);
                return Image.FromStream(ms);
            }
        }

        public static void Save(Image image, string fileName)
        {
            using (new NetworkConnection(ImageFolder, NetworkCredentials))
            {
                image.Save(GetCompleteFilePath(fileName), ImageFormat.Png);
            }
        }
    }
}
