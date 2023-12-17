using System.Globalization;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace KeyerTest;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window, IDisposable
{
    private Color _color = Color.FromArgb(255,255,255,255);
    public MainWindow()
    {
        InitializeComponent();
    }

    private void OnFileImportClicked()
    {
        
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
        Console.WriteLine(textBox.Text);
        
        if (textBox == RBlock) _color.R = chanel;
        if (textBox == GBlock) _color.G = chanel;
        if (textBox == BBlock) _color.B = chanel;
        
        Console.WriteLine(_color);
        
        if (ColorDisplay == null) return;
        
        ColorDisplay.Background = new SolidColorBrush(_color);
    }
}