using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using Encoder = System.Drawing.Imaging.Encoder;

namespace AdminSystem.Classes
{
    public class ImgManager
    {
        private Image img {  get; set; }
        private string imgbase {  get; set; }

        public Image ImgbaseToImg(string imgbaseString)
        {
            if (string.IsNullOrEmpty(imgbaseString))
            {
                Console.WriteLine("Error!");
                return null;
            }
            try
            {
                byte[] imgBytes = Convert.FromBase64String(imgbaseString);
                using(var ms = new MemoryStream(imgBytes))
                {
                    img = Image.FromStream(ms);
                    return img;
                }
            }catch(Exception ex)
            {
                Console.WriteLine($"Error convertion! {ex.Message}");
                return null;
            }
        }

    }
}
