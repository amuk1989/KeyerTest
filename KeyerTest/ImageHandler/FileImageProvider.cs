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
            return _image;
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

        public void SetImage(Bitmap bitmap)
        {
            _image = bitmap;
        }

        public void SaveImage()
        {
            _fileLoader.SaveToFile(_image);
        }
    }
}

