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

namespace WPFIntro1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            //InitializeComponent();
        }

        private void ApplyButtonName_Click(object sender, RoutedEventArgs e)
        {
            //to access the button you can do this.//
            MessageBox.Show($"The description is: { this.DescriptionText.Text}");
        }

        private void ResetButtonName_Click(object sender, RoutedEventArgs e)
        {
                this.WeldCheckBox.IsChecked =
                this.AssemblyCheckBox.IsChecked =
                this.PlasmaCheckBox.IsChecked =
                this.LaserCheckBox.IsChecked =
                this.PurchaseCheckBox.IsChecked =
                this.LatheCheckBox.IsChecked =
                this.DrillCheckBox.IsChecked =
                this.FoldCheckBox.IsChecked =
                this.RollCheckBox.IsChecked =
                this.SawCheckBox.IsChecked = false;
            this.LengthText.Text = null;
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            //this.LengthText.Text += ((CheckBox)sender).Content;
            this.LengthText.Text += (String)((CheckBox)sender).Content+ " ";
        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            this.LengthText.Text = LengthText.Text.Replace((String)((CheckBox)sender).Content,"");
        }
    }
}
