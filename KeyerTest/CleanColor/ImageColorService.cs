using System.Drawing;
using System.Drawing.Imaging;

namespace KeyerTest.CleanColor
{
    public class ImageColorService:IImageColorService
    {
        private static int TrashHold = 50;
        public Bitmap ClearAllPixelsByColor(Bitmap image, Color color)
        {
            Bitmap resultBitmap = new Bitmap(image.Width, image.Height, PixelFormat.Format32bppArgb);
            
            for(var x=0; x<image.Width; x++)
            {
                for(var y=0; y<image.Height; y++)
                {
                    var pixelColor = image.GetPixel(x, y);

                    if (MathF.Abs(pixelColor.R - color.R) <= TrashHold &&
                        MathF.Abs(pixelColor.G - color.G) <= TrashHold &&
                        MathF.Abs(pixelColor.B - color.B) <= TrashHold)
                    {
                        var newColor = Color.FromArgb(0, 255, 255, 255);
                        resultBitmap.SetPixel(x, y, newColor);
                        continue;
                    }

                    resultBitmap.SetPixel(x,y,pixelColor);
                }
            }

            return resultBitmap;
        }
    }
}

