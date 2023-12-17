using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using Grace.DependencyInjection;
using Grace.DependencyInjection.Attributes;
using KeyerTest.Di;
using KeyerTest.ImageHandler;

namespace KeyerTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, IDisposable
    {
        private readonly IImageProvider _imageProvider;
    
        private Color _color = Color.FromArgb(255,255,255,255);
    
        public MainWindow()
        {
            InitializeComponent();
            
            _imageProvider = DiInitializer.Container.Locate<IImageProvider>();
        }

        private void OnFileImportClicked(object sender, RoutedEventArgs e)
        {
            var image = _imageProvider.LoadImage();
            MainImage.Source = image.ToBitmapImage();
        }
    
        private void OnFileExportClicked()
        {
        
        }
    
        private void OnColorChoseClicked()
        {
        
        }

        public void Dispose()
        {
        
        }

        private void ColorBlock_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            var textBox = (e.OriginalSource as TextBox);
            if (textBox == null) return;
        
            if (!byte.TryParse(textBox.Text, out var chanel)) return;
        
            if (textBox == RBlock) _color.R = chanel;
            if (textBox == GBlock) _color.G = chanel;
            if (textBox == BBlock) _color.B = chanel;
        
            if (ColorDisplay == null) return;
        
            ColorDisplay.Background = new SolidColorBrush(_color);
        }
    }
}