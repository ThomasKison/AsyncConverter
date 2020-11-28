using System;
namespace AsyncConverter.Models
{
    public class Image
    {
        public string Id { get; private set; }
        public string Filename { get; set; }

        public static Image CreateMock(string filename)
        {
            return new Image
            {
                Id = Guid.NewGuid().ToString(),
                Filename = filename
            };
        }
    }
}
