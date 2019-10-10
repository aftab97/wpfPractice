using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFPractice
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

        private void ApplyButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("the description is " + this.DescriptionText.Text);
        }

        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            this.Weld.IsChecked = this.Assembly.IsChecked = this.Plasma.IsChecked = this.Laser.IsChecked = this.Purchase.IsChecked
                = this.Lathe.IsChecked = this.Drilly.IsChecked = this.Fold.IsChecked = this.Roll.IsChecked = this.Saw.IsChecked = false;
        }
    }
}
