using System.Drawing;
using System.Windows.Media.Imaging;

namespace KeyerTest.ImageHandler
{
    public interface IImageProvider
    {
        public Bitmap GetLoadedImage();
        public Bitmap LoadImage();
        public void SetImage(Bitmap bitmap);
    }
}
