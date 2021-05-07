using System.Drawing;

namespace Resources
{
    public class ImagesProvider
    {
        public static byte[] Kentico()
        {
            using (var bannerImage = EmbeddedResourceContainer.KenticoImage())
            {
                var imageBytes = (byte[])new ImageConverter().ConvertTo(bannerImage, typeof(byte[]));
                return imageBytes;
            }
        }
    }
}
