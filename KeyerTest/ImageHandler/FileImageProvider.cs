using System.Drawing;
using System.Windows.Media.Imaging;

namespace KeyerTest.ImageHandler
{
    public class FileImageProvider(FileLoader fileLoader) : IImageProvider
    {
        private static int DefaultSize = 100;
        private readonly FileLoader _fileLoader = fileLoader;
        
        private Bitmap _image = new(DefaultSize, DefaultSize);

        public Bitmap GetLoadedImage()
        {
            return LoadImage();
        }

        public Bitmap LoadImage()
        {
            try
            {
                var path = _fileLoader.LoadFile();
                _image = new Bitmap(path, true);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            
            return _image;
        }
    }
}

