using System.Drawing;
using System.Windows.Media.Imaging;

namespace KeyerTest.ImageHandler
{
    public interface IImageProvider
    {
        public BitmapImage GetLoadedImage();
        public BitmapImage LoadImage();
    }
}
