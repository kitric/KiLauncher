using AppLauncher.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
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
        private static Image ResizeImage(Image image, int width, int height)
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

        // Algorithm utilises the SizeMode.CenterImage property on a PictureBox, so it accurately works out the proportion the 
        // image must be in order to not be squished.
        // It also utilises the ResizeImage function (see below).
        public static Image CropImageCenter(string imageLocation, Button btn)
        {
            using (Image image = Image.FromFile(imageLocation))
            {
                // If the Width of the image is bigger than the height, then we know the sides will be cut off
                if (image.Width > image.Height)
                {
                    // The algorithm works by making the height of the final image the same as the height of the PictureBox (this is different for width, see else statement), 
                    // but we first need to find out what the final width will be so the image doesn't come out as squished.
                    // This formula determines the number we need to multiply by to get an unstretched image
                    double multiplier = Math.Round((double)(btn.Height) / image.Height, 2);

                    int newHeight = btn.Height;
                    // Apply that multiplier to the width to get the final width of the image
                    double newWidth = image.Width * multiplier;

                    return ResizeImage(image, Convert.ToInt32(Math.Round(newWidth, 0)), newHeight);
                }
                else
                {
                    // Same as above, however the top and bottom will be cut instead, so we do the calucaltion around width instead.
                    double multiplier = Math.Round((double)(btn.Width) / image.Width, 2);

                    double newHeight = image.Height * multiplier;
                    int newWidth = btn.Width;

                    return ResizeImage(image, newWidth, Convert.ToInt32(Math.Round(newHeight, 0)));
                }
            }
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



        #region serialization
        internal static void DeserializeUserData()
        {
            string cachePath = GlobalFunctions.GetProgramAppdataFolder();
            string fpath = Path.Combine(cachePath, "buttons.apl");

            if (File.Exists(fpath))
            {
                using (FileStream fs = new FileStream(fpath, FileMode.Open))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    MainScreen.Data = (UserData)formatter.Deserialize(fs);
                }
            }
            else
            {
                MainScreen.Data = new UserData();
            }
        }

        /// <summary>
        /// This function works both as a way to serialize data to the .apl file
        /// and as a way to export data to a file.
        /// 
        /// If no argument is passed, the code will serialize data to the default .apl file. 
        /// otherwise serializes it to a different .apl file.
        /// </summary>
        /// <param name="fPath"></param>
        public static void SerializeOrExportUserData(string fPath="")
        {
            using (FileStream fs = new FileStream((fPath == "" ? Path.Combine(GetProgramAppdataFolder(), "buttons.apl") : fPath), FileMode.OpenOrCreate))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fs, MainScreen.Data);
            }
        }
        #endregion
    }
}
