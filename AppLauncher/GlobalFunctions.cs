using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppLauncher
{
    public static class GlobalFunctions
    {

        /// <summary>
        /// Returns the appdata folder for this application.
        /// </summary>
        /// <returns>The appdata folder for this application</returns>
        public static string GetProgramAppdataFolder()
        {
            return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "KiLauncher");
        }

        /// <summary>
        /// Resize the image to the specified width and height.
        /// </summary>
        /// <param name="image">The image to resize.</param>
        /// <param name="width">The width to resize to.</param>
        /// <param name="height">The height to resize to.</param>
        /// <returns>The resized image.</returns>
        public static Image ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }


        /// <summary>
        /// Now, you only need one function for switching windows.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="args"></param>
        public static void SwitchTo<T>(Panel Content, object[] args = null) where T : UserControl
        {
            Control topControl = Content.Controls[0];

            //Creates a new UserControl from T. 
            UserControl control = (UserControl)Activator.CreateInstance(typeof(T), args ?? new object[] { });
            control.Dock = DockStyle.Fill;

            // If the window on the top is different:
            if (topControl.GetType() != control.GetType())
            {
                foreach (Control x in topControl.Controls) { x.Dispose(); }
                topControl.Dispose();

                Content.Controls.Clear();
                Content.Controls.Add(control);
            }
        }

        /// <summary>
        /// Hides the scrollbars of a control.
        /// </summary>
        /// <param name="panel"></param>
        public static void HideScrollbars(Panel panel)
        {
            panel.AutoScroll = false;
            panel.HorizontalScroll.Maximum = 0;
            panel.VerticalScroll.Maximum = 0;

            panel.HorizontalScroll.Enabled = false;
            panel.VerticalScroll.Enabled = false;

            panel.AutoScroll = true;
        }



        /// <summary>
        /// Creates a copy of the image used in the cache.
        /// </summary>
        /// <param name="originalFilePath"></param>
        /// <param name="id"></param>
        public static string CreateCopyInCache(string originalFilePath, int id)
        {
            string extension = Path.GetExtension(originalFilePath);

            string pathToWrite = Path.Combine(GetProgramAppdataFolder(), "cache", $"{id}_posters{extension}");

            File.Copy(originalFilePath, pathToWrite);

            return pathToWrite;

        }
    }
}
