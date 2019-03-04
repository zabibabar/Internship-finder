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
using System.Windows.Shapes;

namespace Internships
{
    /// <summary>
    /// Interaction logic for AddInternship.xaml
    /// </summary>
    public partial class AddInternship : Window
    {
        public AddInternship()
        {
            AddVM addVM = new AddVM(this);
            InitializeComponent();
            DataContext = addVM;
        }
        
        public bool ValidateAllEntries()
        {
            bool name, city, state, link;

            name = string.IsNullOrWhiteSpace(Company.Text) ? false : ValidateForLetters(Company.Text);
            Company.Background = name ? Brushes.White : Brushes.Coral;

            city = string.IsNullOrWhiteSpace(City.Text) ? false : ValidateForLetters(City.Text);
            City.Background = city ? Brushes.White : Brushes.Coral;

            state = string.IsNullOrWhiteSpace(State.Text) ? false : ValidateForLetters(State.Text);
            State.Background = state ? Brushes.White : Brushes.Coral;

            link = string.IsNullOrWhiteSpace(Link.Text) ? false : ValidateForLetters(Link.Text);
            Link.Background = link ? Brushes.White : Brushes.Coral;

            return name && city && state && link;
        }

        private bool ValidateForLetters(string tester)
        {
            return tester.Where(x => char.IsLetter(x) || string.IsNullOrWhiteSpace(x.ToString()))
                 .Count() == tester.Length;
        }

        private void TextFieldChanged(object sender, RoutedEventArgs e)
        {          
           if (sender is TextBox)
            {
                TextBox tb = (sender as TextBox);
                tb.Background = Brushes.White;
            }                     
        }
    }
}
