using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using Microsoft.Win32;

namespace KeyerTest.ImageHandler
{
    public class FileLoader
    {
        private const string FileFilter = "png files (*.png)|*.png";
        public string LoadFile()
        {
            var openFileDialog = new OpenFileDialog
            {
                Filter = FileFilter,
                RestoreDirectory = true
            };

            if (!(bool) openFileDialog.ShowDialog()!) return string.Empty;
            
            return openFileDialog.FileName;
        }
        
        public void SaveToFile(Bitmap image)
        {
            var saveFileDialog = new SaveFileDialog
            {
                Filter = FileFilter,
                RestoreDirectory = true
            };

            if (!(bool) saveFileDialog.ShowDialog()!) return;
            
            image.Save(saveFileDialog.FileName, ImageFormat.Png);
        }
    }
}

