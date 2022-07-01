using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Net.Mime;
namespace GenerateRobot
{
    class Program
    {
        static void Main(string[] args)
        {
            #region MyRegion

            // Bitmap baseImage;
            // Bitmap overlayImage;
            //
            // baseImage = (Bitmap)Image.FromFile(@"C:\Users\ZenBook\Downloads\test\v1_mil1_head.png");
            //
            // overlayImage = (Bitmap)Image.FromFile(@"C:\Users\ZenBook\Downloads\test\v1_mil1_legs.png");
            //
            // var finalImage = new Bitmap(baseImage.Width, overlayImage.Height, PixelFormat.Format64bppArgb);
            //
            // var graphics = Graphics.FromImage(finalImage);
            // graphics.CompositingMode = CompositingMode.SourceOver;
            //
            // graphics.DrawImage(baseImage, 20, 120);
            // graphics.DrawImage(overlayImage, 10, -55);
            //
            //
            // //save the final composite image to disk
            // finalImage.Save(@"C:\Users\ZenBook\Downloads\test\final.png", ImageFormat.Png);


            // Image image1 = Image.FromFile(@"C:\Users\ZenBook\Downloads\test\v1_mil1_legs.png");

            #endregion


            var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var subFolderPath = Path.Combine(path, "Test");

            if (!Directory.Exists(subFolderPath))
            {
                Directory.CreateDirectory(subFolderPath);
            }

           
        }
    }
}