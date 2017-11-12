using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace WpfUi
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Page
    {
        private ImageServiceReferense.ImageServiceClient _client;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Load()
        {
            var array = _client
                .GetAll()
                .Select(i => new ImageModel(i.Id, i.Title, i.Description,i.Data))
                .ToArray();

            imagesGrid.ItemsSource = array;
        }

        private void Reload_OnClick(object sender, RoutedEventArgs e)
        {
            Load();
        }

        private void Create_OnClick(object sender, RoutedEventArgs e)
        {
            var image = (ImageModel)imagesGrid.SelectedItem;

            if (image == null)
                image = new ImageModel();

            NavigationService.Navigate(new CreatePage(image));
        }

        private void MainWindow_OnLoaded(object sender, RoutedEventArgs e)
        {
            _client = new ImageServiceReferense.ImageServiceClient();
            Load();
        }

        private void MainWindow_OnUnloaded(object sender, RoutedEventArgs e)
        {
            _client.Close();
        }
    }
}
