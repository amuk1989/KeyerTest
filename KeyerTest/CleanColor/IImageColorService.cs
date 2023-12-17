using System.Drawing;

namespace KeyerTest.CleanColor
{
    public interface IImageColorService
    {
        Bitmap ClearAllPixelsByColor(Bitmap image, Color color);
    }
}

