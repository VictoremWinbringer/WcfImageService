using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using Microsoft.Win32;

namespace WpfUi
{
    /// <summary>
    /// Interaction logic for CreatePage.xaml
    /// </summary>
    public partial class CreatePage : Page
    {

        public CreatePage(ImageModel image)
        {
            InitializeComponent();

            Id.Text = image.Id.ToString();

            Title.Text = image.Title;

            Description.Text = image.Description;

            Data.Source = image.Data;
        }

        private void LoadButton_OnClick(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.RestoreDirectory = true;

            bool? result = openFileDialog.ShowDialog();
            if (result == true)
            {
                if (openFileDialog.FileName.Length > 0)
                {
                    BitmapImage bi = new BitmapImage();

                    bi.BeginInit();
                    bi.StreamSource = new MemoryStream(File.ReadAllBytes(openFileDialog.FileName));
                    bi.EndInit();

                    ((BitmapImage)Data.Source)?.StreamSource?.Dispose();

                    Data.Source = bi;
                }
            }
        }

        private byte[] GetData()
        {
            var stream = (MemoryStream)((BitmapImage)Data.Source)?.StreamSource;

            return stream?.ToArray() ?? new byte[0];
        }

        private void SaveButton_OnClick(object sender, RoutedEventArgs e)
        {
            var service = new ImageServiceReferense.ImageServiceClient();

            var data = GetData();

            if (data.Length == 0)
            {
                MessageBox.Show("Выберите файл!");

                return;
            }

            service.Create(new ImageServiceReferense.Image()
            {
                Title = Title.Text,
                Description = Description.Text,
                Data = data
            });

            service.Close();

            NavigationService.Navigate(new MainWindow());
        }

        private void UpdateButton_OnClick(object sender, RoutedEventArgs e)
        {
            var service = new ImageServiceReferense.ImageServiceClient();

            var data = GetData();

            if (data.Length == 0)
            {
                MessageBox.Show("Выберите файл!");

                return;
            }

            service.Update(new ImageServiceReferense.Image()
            {
                Id = int.Parse(Id.Text),
                Title = Title.Text,
                Description = Description.Text,
                Data = data
            });

            service.Close();

            NavigationService.Navigate(new MainWindow());
        }

        private void DeleteButton_OnClick(object sender, RoutedEventArgs e)
        {
            var service = new ImageServiceReferense.ImageServiceClient();

            service.Delete(int.Parse(Id.Text));

            service.Close();

            NavigationService.Navigate(new MainWindow());
        }
    }
}
