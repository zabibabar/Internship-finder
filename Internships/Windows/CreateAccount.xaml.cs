using System;
using System.Collections.Generic;
using System.IO;
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
using System.Xml.Serialization;

namespace Internships
{
    /// <summary>
    /// Interaction logic for CreateAccount.xaml
    /// </summary>
    public partial class CreateAccount : Window
    {
        private List<UserAccount> Users { get; set; } = new List<UserAccount>();
        public List<Employer> Employers { get; set; } = new List<Employer>();

        XmlSerializer xmler = new XmlSerializer(typeof(List<UserAccount>));
        XmlSerializer empxmler = new XmlSerializer(typeof(List<Employer>));
        private bool IsEdit { get; set; }
        private UserAccount EditingUser { get; set; }

        public CreateAccount(List<UserAccount> users, List<Employer> emps,  bool isEdit = false)
        {
            Users = users;
            IsEdit = isEdit;
            Employers = emps;
            CreateVM create = new CreateVM(this, Users, IsEdit, Employers);
            InitializeComponent();
            DataContext = create;
        }

        public CreateAccount(List<UserAccount> users, UserAccount user, bool isEdit = true)
        {
            InitializeComponent();
            IsEdit = isEdit;
            EditingUser = user;
            Users = users;
        }

        public bool ValidateAllEntries()
        {
            bool emailValid, loginValid, passwordValid, statusValid;

            emailValid = !string.IsNullOrWhiteSpace(UserCreatedEmail.Text);
            UserCreatedEmail.Background = emailValid ? Brushes.White : Brushes.Coral;

            loginValid = !string.IsNullOrWhiteSpace(UserCreatedLogin.Text);
            UserCreatedLogin.Background = loginValid ? Brushes.White : Brushes.Coral;

            passwordValid = !string.IsNullOrWhiteSpace(UserCreatedPassword.Password);
            UserCreatedPassword.Background = emailValid ? Brushes.White : Brushes.Coral;

            if (UserCreatedPassword.Password.Length < 6)
            {
                passwordValid = false;
            }

            if (!Convert.ToBoolean(Intern.IsChecked) && !Convert.ToBoolean(Employer.IsChecked))
            {
                statusValid = false;
                Status.Background = Brushes.Coral;
            }
            else
            {
                statusValid = true;
                Status.Background = Brushes.White;
            }
            
            return loginValid && passwordValid && statusValid && emailValid;
        }

        private void TextFieldChanged(object sender, RoutedEventArgs e)
        {
            if (sender is TextBox)
            {
                TextBox tb = (sender as TextBox);
                tb.Background = Brushes.White;
            }

            if (sender is StackPanel)
            {
                StackPanel sp = (sender as StackPanel);
                sp.Background = Brushes.White;
            }
        }
    }
}
