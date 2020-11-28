using System;
namespace AsyncConverter.Models
{
    public class Product
    {
        public string Id { get; private set; }
        public string Name { get; set; }
        public Image Image { get; set; }

        public static Product CreateMock(string name)
        {
            return new Product
            {
                Id = Guid.NewGuid().ToString(),
                Name = name,
                Image = Image.CreateMock($"{name}.png")
            };
        }
    }
}
