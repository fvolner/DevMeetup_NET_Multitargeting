using System.Drawing;
using System.Reflection;

namespace Resources
{
    public class EmbeddedResourceContainer
    {
        public static Image KenticoImage()
        {
            using (var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("Resources.Images.Kentico.png"))
            {
                return Image.FromStream(stream);
            }
        }
    }
}
