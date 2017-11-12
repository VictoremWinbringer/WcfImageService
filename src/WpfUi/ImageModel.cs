using System.IO;
using System.Windows.Media.Imaging;

namespace WpfUi
{
    public class ImageModel
    {
        public ImageModel()
        {

        }

        public ImageModel(int id, string title, string description, byte[] image)
        {

            Id = id;
            Title = title;
            Description = description;

            if (image.Length > 0)
            {
                BitmapImage bi = new BitmapImage();

                bi.BeginInit();
                bi.StreamSource = new MemoryStream(image);
                bi.EndInit();

                Data = bi;
            }
        }

        public int Id { get; set; }

        public string Title { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public BitmapImage Data { get; set; } = new BitmapImage();
    }
}
