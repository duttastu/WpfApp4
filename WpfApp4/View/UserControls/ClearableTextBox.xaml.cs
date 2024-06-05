using System.Windows;
using System.Windows.Controls;

namespace WpfApp4.View.UserControls
{

    public partial class ClearableTextBox : UserControl
    {
        public ClearableTextBox()
        {
            InitializeComponent();
        }
        private string placeholder;

        public string Placeholder
        {
            get { return placeholder; }
            set { 
                placeholder = value; 
                tbPlaceholder.Text = placeholder;
            }
        }


        private void btnClass_Click(object sender, RoutedEventArgs e)
        {
            txtInput.Clear();
            txtInput.Focus();

        }

        private void txtInput_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(string.IsNullOrEmpty(txtInput.Text))
            {
                tbPlaceholder.Visibility = Visibility.Visible;
            }
            else
            {
                tbPlaceholder.Visibility = Visibility.Hidden;
            }
        }
    }
}
