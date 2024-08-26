using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
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
        private ImageCodecInfo GetEncoderInfo(string s)
        {
            ImageCodecInfo[] i = ImageCodecInfo.GetImageEncoders();
            foreach (ImageCodecInfo result in i)
            {
                if (result.MimeType == s) { return result; }
            }return null;
            //return ImageCodecInfo.GetImageEncoders().FirstOrDefault(codec => codec.MimeType == s);
        }
        public long GetFileSize(string path)
        {
            if(string.IsNullOrEmpty(path))
            {
                Console.WriteLine("Error: File path is null or empty!");
                return -1;
            }
            try
            {
                FileInfo info = new FileInfo(path);
                return info.Length / 1024;  //convert bytes to KB
            }catch(Exception ex)
            {
                Console.WriteLine($"Error getting file size! {ex.Message}");
                return -1;
            }
        }
    }
}
