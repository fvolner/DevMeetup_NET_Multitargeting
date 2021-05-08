#if NETFRAMEWORK
using System.Drawing;
#endif
#if NETSTANDARD
using System.Drawing.Imaging;
using System.IO; 
#endif

namespace Resources
{
    public class ImagesProvider
    {
        public static byte[] Kentico()
        {
            using (var bannerImage = EmbeddedResourceContainer.KenticoImage())
            {
#if NETFRAMEWORK

                var imageBytes = (byte[])new ImageConverter().ConvertTo(bannerImage, typeof(byte[]));
                return imageBytes;
#endif
#if NETSTANDARD
                using var memStream = new MemoryStream();
                bannerImage.Save(memStream, ImageFormat.Bmp);
                return memStream.ToArray();
#endif
            }
        }
    }
}
