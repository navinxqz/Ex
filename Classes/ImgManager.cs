using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using Encoder = System.Drawing.Imaging.Encoder;

namespace AdminSystem.Classes
{
    public class ImgManager
    {
        private Image img { get; set; }
        private string imgbase { get; set; }

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
                using (var ms = new MemoryStream(imgBytes))
                {
                    img = Image.FromStream(ms);
                    return img;
                }
            }
            catch (Exception ex)
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
            }
            return null;
            //return ImageCodecInfo.GetImageEncoders().FirstOrDefault(codec => codec.MimeType == s);
        }
        public long GetFileSize(string path)
        {
            if (string.IsNullOrEmpty(path))
            {
                Console.WriteLine("Error: File path is null or empty!");
                return -1;
            }
            try
            {
                FileInfo info = new FileInfo(path);
                return info.Length / 1024;  //convert bytes to KB
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error getting file size! {ex.Message}");
                return -1;
            }
        }

        public Image ImgSizeCompresser(Image asset, long quality = 15L, double maxSize = 350.0)
        {
            if (asset == null)
            {
                Console.WriteLine("Error! Img is null");
                imgbase = null;
                return null;
            }
            try
            {
                using (var ms = new MemoryStream())
                {
                    var encoderPeras = new EncoderParameters(1)
                    {
                        Param = { [0] = new EncoderParameter(Encoder.Quality, quality) }
                    };

                    var jpegCodec = GetEncoderInfo("image/jpeg");
                    if (jpegCodec == null)
                    {
                        Console.WriteLine("JPEG encoder not found.");
                        return null;
                    }

                    asset.Save(ms, jpegCodec, encoderPeras);
                    byte[] imgByte = ms.ToArray();
                    double imgSize = imgByte.Length / 1024;

                    if (imgSize > maxSize)
                    {
                        Console.WriteLine("Error! Img size exceeds the max limit.");
                        imgbase = string.Empty;
                        return null;
                    }
                    imgbase = Convert.ToBase64String(imgByte);
                    using (var imgStream = new MemoryStream(Convert.FromBase64String(imgbase)))
                    {
                        img = Image.FromStream(imgStream);
                    }
                    return img;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error while compressing img! {ex.Message}");
                return null;
            }
        }
        public string CompressImg(Image asset, long quality = 15L, double maxSize = 350.0)
        {
            var comImg = ImgSizeCompresser(asset, quality, maxSize);
            return comImg != null ? imgbase : null;
        }

        public string ConvertImgToimgbase(Image img)
        {
            if (img == null)
            {
                Console.WriteLine("Error! Img is null");
                return null;
            }
            try
            {
                using (var ms = new MemoryStream())
                {
                    img.Save(ms, img.RawFormat);
                    return Convert.ToBase64String(ms.ToArray());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error while converting img to imgbase! {ex.Message}");
                return null;
            }
        }
    }
}
