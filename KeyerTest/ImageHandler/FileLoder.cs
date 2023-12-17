using System.IO;
using Microsoft.Win32;

namespace KeyerTest.ImageHandler
{
    public class FileLoader
    {
        public string LoadFile()
        {
            var openFileDialog = new OpenFileDialog();
            
            openFileDialog.Filter = "png files (*.png)|*.png";
            openFileDialog.RestoreDirectory = true;

            if (!(bool) openFileDialog.ShowDialog()!) return string.Empty;
            
            return openFileDialog.FileName;
        }
    }
}

