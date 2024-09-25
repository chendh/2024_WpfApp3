using System.Windows;
using System.Windows.Controls;

namespace _2024_WpfApp3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            var targetTextBox = sender as TextBox;

            MessageBox.Show(targetTextBox.Text);
        }
    }
}