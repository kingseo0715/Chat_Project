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

namespace Chat;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void btn_join_Click(object sender, RoutedEventArgs e)
    {
        Join join = new Join();
        Close();
        join.Show();
    }

    private void btn_login_Click(object sender, RoutedEventArgs e)
    {
        ChatMain ch = new ChatMain();
        Close();
        ch.Show();
    }
}