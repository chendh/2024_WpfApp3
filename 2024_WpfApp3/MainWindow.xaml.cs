using System.Windows;
using System.Windows.Controls;

namespace _2024_WpfApp3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Dictionary<string, int> drinks = new Dictionary<string, int>
        {
            { "紅茶大杯", 60 },
            { "紅茶小杯", 40 },
            { "綠茶大杯", 50 },
            { "綠茶小杯", 30 },
            { "可樂大杯", 50 },
            { "可樂小杯", 30 },
        };
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            var targetSlider = sender as Slider;
            int amount = (int)targetSlider.Value;
            var targetStackPanel = targetSlider.Parent as StackPanel;
            var targetLabel = targetStackPanel.Children[0] as Label;
            var drinkName = targetLabel.Content.ToString();
            MessageBox.Show(drinkName + " " + amount + "杯，共" + drinks[drinkName] * amount + "元");
        }

        //private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        //{
        //    var targetTextBox = sender as TextBox;

        //    //MessageBox.Show(targetTextBox.Text);
        //    int amount;
        //    bool success = int.TryParse(targetTextBox.Text, out amount);

        //    if (!success) MessageBox.Show("請輸入數字", "輸入錯誤");
        //    else if (amount <= 0) MessageBox.Show("請輸入正整數", "輸入錯誤");
        //    else
        //    {
        //        var targetStackPanel = targetTextBox.Parent as StackPanel;
        //        var targetLabel = targetStackPanel.Children[0] as Label;
        //        var drinkName = targetLabel.Content.ToString();

        //        MessageBox.Show(drinkName + " " + amount + "杯，共" + drinks[drinkName] * amount + "元");
        //    }
        //}
    }
}