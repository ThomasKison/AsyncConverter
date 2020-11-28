using System;
using System.Globalization;
using System.IO;
using System.Threading.Tasks;
using AsyncConverter.Services;
using Xamarin.Forms;

namespace AsyncConverter.Converters
{
    public class ImageModelConverter : AsyncConverter<ImageSource>
    {
        // its a little bit tricky to inject this using IoC, but it's possible
        // but that's not part of this ... so I just create the service here
        public ImageCacheService _imageCacheService = new ImageCacheService();
        public override async Task<ImageSource> AsyncConvert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is Models.Image image)
            {
                var imageData = await _imageCacheService.GetImageData(image);
                return ImageSource.FromStream(() => new MemoryStream(imageData));
            }
            return null;
        }
    }
}
