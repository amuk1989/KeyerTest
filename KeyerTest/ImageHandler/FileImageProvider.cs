using System.Drawing;
using System.Windows.Media.Imaging;

namespace KeyerTest.ImageHandler
{
    public class FileImageProvider(FileLoader fileLoader) : IImageProvider
    {
        private readonly FileLoader _fileLoader = fileLoader;
        
        private BitmapImage _image = new();

        public BitmapImage GetLoadedImage()
        {
            return LoadImage();
        }

        public BitmapImage LoadImage()
        {
            try
            {
                var path = _fileLoader.LoadFile();
                var bitMap = new Bitmap(path, true);
                _image = bitMap.ToBitmapImage();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            
            return _image;
        }
    }
}

