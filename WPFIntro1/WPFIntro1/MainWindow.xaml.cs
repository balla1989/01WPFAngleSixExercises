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
            //to access the button you can do this. Basically this ==all the items in WPFIntro1.Mainwindow//
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

        {// here CheckBox is the sender
            //this.LengthText.Text += ((CheckBox)sender).Content;
            this.LengthText.Text += (String)((CheckBox)sender).Content+ " ";
        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            // here CheckBox is the sender
            this.LengthText.Text = LengthText.Text.Replace((String)((CheckBox)sender).Content,"");
        }

        private void FinishDropdown_SelectionChanged(object sender, SelectionChangedEventArgs e)

        {
            if (this.NoteText == null)
                return;
            //here combobox is the sender. we then get the SelectedValue. But the selected value is a ComboBoxItem.
            //So we then get the Content of ComboBoxItem and type cast it to string.
            this.NoteText.Text =(string) ((ComboBoxItem)((ComboBox)sender).SelectedValue).Content;
        }


        //this piece of code added so that the default text in "Note" is "Painted"//
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            FinishDropdown_SelectionChanged(this.FinishDropDown, null);
        }

        private void SupplierNameText_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            // this.MassText.Text = (string)((TextBox)sender).DataContext;
            this.MassText.Text = this.SupplierNameText.Text;
        }
    }
}
