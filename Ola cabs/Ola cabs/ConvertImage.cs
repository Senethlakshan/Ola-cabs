using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Ola_cabs
{

    public static class ConvertImage
    {
        public static BitmapImage bitmapImage(this Bitmap bitmap)
        {
            using (var memory = new MemoryStream())
            {
                bitmap.Save(memory, ImageFormat.Png);
                memory.Position = 0;
                var bitmapimage = new BitmapImage();
                bitmapimage.BeginInit();
                bitmapimage.StreamSource = memory;
                bitmapimage.CacheOption = BitmapCacheOption.OnLoad;
                bitmapimage.EndInit();
                bitmapimage.Freeze();
                return bitmapimage;






            }




        }




    }


}
