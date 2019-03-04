using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for Education.xaml
    /// </summary>
    public partial class Education : Window
    {
        public List<UserAccount> Users { get; set; } = new List<UserAccount>();
        UserAccount CurrentUser { get; set; }
        XmlSerializer serializer = new XmlSerializer(typeof(List<UserAccount>));

        public Education(UserAccount act, List<UserAccount> users)
        {
            Users = users;
            CurrentUser = act;
            EducationVM education = new EducationVM(this, CurrentUser);
            InitializeComponent();
            DataContext = education;
            UserEnrollment.DisplayDateStart = DateTime.Today.AddYears(-6);
            UserEnrollment.DisplayDateEnd = DateTime.Today;
            UserGraduation.DisplayDateStart = DateTime.Today;
            UserGraduation.DisplayDateEnd = DateTime.Today.AddYears(+6);
        }

        public bool ValidateAllEntries()
        {
            bool schoolValid, majorValid, enrollmentValid, graduationValid, collegeStandingValid;

            schoolValid = string.IsNullOrWhiteSpace(UserSchool.Text) ? false : ValidateForLetters(UserSchool.Text);
            UserSchool.Background = schoolValid ? Brushes.White : Brushes.Coral;

            majorValid = string.IsNullOrWhiteSpace(UserMajor.Text) ? false : ValidateForLetters(UserMajor.Text);
            UserMajor.Background = majorValid ? Brushes.White : Brushes.Coral;

            enrollmentValid = UserEnrollment.SelectedDate.HasValue;
            UserEnrollment.Background = enrollmentValid ? Brushes.White : Brushes.Coral;

            graduationValid = UserGraduation.SelectedDate.HasValue;
            UserGraduation.Background = graduationValid ? Brushes.White : Brushes.Coral;

            if (UserCollegeStanding.SelectionBoxItem.ToString() == "")
            {
                collegeStandingValid = false;                
            }
            else
            {
                collegeStandingValid = true;
            }

            return schoolValid && majorValid && enrollmentValid && graduationValid && collegeStandingValid;
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
            string path = "Users.xml";
            if (Users.Count == 0 && File.Exists(path))
            {
                File.Delete(path);
            }
            else
            {
                using (FileStream filestream = new FileStream(path, FileMode.Create, FileAccess.ReadWrite))
                {
                    serializer.Serialize(filestream, Users);
                }
                MessageBox.Show("Your Personal Information has been saved.", "Success!!");
            }
        }

        private void TextFieldChanged(object sender, RoutedEventArgs e)
        {
            if (sender is TextBox)
            {
                TextBox tb = (sender as TextBox);
                tb.Background = Brushes.White;
            }

            if (sender is DatePicker)
            {
                DatePicker dp = (sender as DatePicker);
                dp.Background = Brushes.White;
            }
        }
    }
}
