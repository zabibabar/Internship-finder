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
    /// Interaction logic for EmployerInformationxaml.xaml
    /// </summary>
    public partial class EmployerInformationxaml : Window
    {
        Employer Emp { get; set; }
        public List<Employer> Employers { get; set; } = new List<Employer>();
        XmlSerializer serializer = new XmlSerializer(typeof(List<Employer>));

        public EmployerInformationxaml(Employer emp, List<Employer> emps)
        {
            Employers = emps;
            Emp = emp;
            EmployerInfoVM empInfo = new EmployerInfoVM(this, Emp);
            InitializeComponent();
            DataContext = empInfo;
        }

        public bool ValidateAllEntries()
        {
            bool nameValid, companyValid, addressValid, phoneValid;

            nameValid = string.IsNullOrWhiteSpace(UserName.Text) ? false : ValidateForLetters(UserName.Text);
            UserName.Background = nameValid ? Brushes.White : Brushes.Coral;

            companyValid = string.IsNullOrWhiteSpace(UserCompany.Text) ? false : ValidateForLetters(UserCompany.Text);
            UserCompany.Background = companyValid ? Brushes.White : Brushes.Coral;

            addressValid = !string.IsNullOrWhiteSpace(UserAddress.Text); 
            UserAddress.Background = addressValid ? Brushes.White : Brushes.Coral;

            phoneValid = string.IsNullOrWhiteSpace(UserPhone.Text) ? false : ValidateForDigits(UserPhone.Text);
            UserPhone.Background = phoneValid ? Brushes.White : Brushes.Coral;
            
            return nameValid && companyValid && addressValid && phoneValid;
        }

        private bool ValidateForLetters(string tester)
        {
            return tester.Where(x => char.IsLetter(x) || string.IsNullOrWhiteSpace(x.ToString()))
                 .Count() == tester.Length;
        }

        private bool ValidateForDigits(string tester)
        {
            return tester.Where(x => char.IsDigit(x)).Count() == tester.Length;
        }

        public void WriteToFile()
        {
            string path = "Employers.xml";
            if (Employers.Count == 0 && File.Exists(path))
            {
                File.Delete(path);
            }
            else
            {
                using (FileStream filestream = new FileStream(path, FileMode.Create, FileAccess.ReadWrite))
                {
                    serializer.Serialize(filestream, Employers);
                }
                MessageBox.Show("Your Information has been saved.", "Success!!");
            }
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
