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
    /// Interaction logic for Personal.xaml
    /// </summary>
    public partial class Personal : Window
    {
        public List<UserAccount> Users { get; set; } = new List<UserAccount>();
        UserAccount CurrentUser { get; set; }
        XmlSerializer serializer = new XmlSerializer(typeof(List<UserAccount>));

        public Personal(UserAccount user, List<UserAccount> users)
        {
            Users = users;
            CurrentUser = user;
            PersonalVM personal = new PersonalVM(this, CurrentUser);
            InitializeComponent();
            DataContext = personal;
            UserBirthDate.DisplayDateStart = DateTime.Today.AddYears(-65);
            UserBirthDate.DisplayDateEnd = DateTime.Today.AddYears(-14);
        }

        private void ClickSubmit(object sender, RoutedEventArgs e)
        {
            if (ValidateAllEntries())
            {
                CurrentUser.FirstName = UserFirstName.Text;
                CurrentUser.LastName = UserLastName.Text;
                CurrentUser.BirthDate = UserBirthDate.SelectedDate.Value.ToString();
                CurrentUser.Gender = UserGender.Children.OfType<RadioButton>().FirstOrDefault(x => (bool)x.IsChecked).Content.ToString();
                CurrentUser.Race = (UserRace.SelectedItem as ComboBoxItem).Content.ToString();
                CurrentUser.StreetName = UserStreetName.Text;
                CurrentUser.StreetNumber = UserStreetNumber.Text;
                CurrentUser.City = UserCity.Text;
                CurrentUser.State = UserState.Text;
                CurrentUser.ZipCode = UserZipCode.Text;
                CurrentUser.Country = UserZipCode.Text;
                CurrentUser.Nationality = UserNationality.Text;
                CurrentUser.PhoneNumber = UserPhone.Text;

                if (CurrentUser.EducationalInfoEntered == "No")
                {
                    CurrentUser.PersonalInfoEntered = "Yes";
                    WriteToFile();
                    Education edu = new Education(CurrentUser, Users);
                    this.Close();
                    edu.Show();
                }
                else
                {
                    WriteToFile();
                    this.Close();
                } 
            }
            else
                MessageBox.Show("Invalid Entries", "Try Again");
        }

        public bool ValidateAllEntries()
        {
            bool firstNameValid, lastNameValid, birthDateValid, genderValid, raceValid, streetNumberValid,
                streetNameValid, cityValid, stateValid, zipCodeValid, countryValid, nationalityValid, phoneValid;

            firstNameValid = string.IsNullOrWhiteSpace(UserFirstName.Text) ? false : ValidateForLetters(UserFirstName.Text);
            UserFirstName.Background = firstNameValid ? Brushes.White : Brushes.Coral;

            lastNameValid = string.IsNullOrWhiteSpace(UserLastName.Text) ? false : ValidateForLetters(UserLastName.Text);
            UserLastName.Background = lastNameValid ? Brushes.White : Brushes.Coral;

            birthDateValid = UserBirthDate.SelectedDate.HasValue;
            UserBirthDate.Background = birthDateValid ? Brushes.White : Brushes.Coral;

            if (!Convert.ToBoolean(MaleRadioButton.IsChecked) && !Convert.ToBoolean(FemaleRadioButton.IsChecked))
            {
                genderValid = false;
                UserGender.Background = Brushes.Coral;
            }
            else
            {
                genderValid = true;
                UserGender.Background = Brushes.White;
            }

            if (UserRace.SelectionBoxItem.ToString() == "")
            {
                raceValid = false;
                UserRace.BorderBrush = Brushes.Coral;
            }
            else
            {
                raceValid = true;
                UserRace.Background = Brushes.White;
            }

            streetNumberValid = !string.IsNullOrWhiteSpace(UserStreetNumber.Text);
            UserStreetNumber.Background = streetNumberValid ? Brushes.White : Brushes.Coral;

            streetNameValid = !string.IsNullOrWhiteSpace(UserStreetName.Text);
            UserStreetName.Background = streetNameValid ? Brushes.White : Brushes.Coral;

            cityValid = string.IsNullOrWhiteSpace(UserCity.Text) ? false : ValidateForLetters(UserCity.Text);
            UserCity.Background = cityValid ? Brushes.White : Brushes.Coral;

            stateValid = string.IsNullOrWhiteSpace(UserState.Text) ? false : ValidateForLetters(UserState.Text);
            UserState.Background = stateValid ? Brushes.White : Brushes.Coral;

            zipCodeValid = string.IsNullOrWhiteSpace(UserZipCode.Text) ? false : ValidateForDigits(UserZipCode.Text);
            UserZipCode.Background = zipCodeValid ? Brushes.White : Brushes.Coral;

            countryValid = string.IsNullOrWhiteSpace(UserCountry.Text) ? false : ValidateForLetters(UserCountry.Text);
            UserCountry.Background = countryValid ? Brushes.White : Brushes.Coral;

            nationalityValid = string.IsNullOrWhiteSpace(UserNationality.Text) ? false : ValidateForLetters(UserNationality.Text);
            UserNationality.Background = nationalityValid ? Brushes.White : Brushes.Coral;

            phoneValid = string.IsNullOrWhiteSpace(UserPhone.Text) ? false : ValidateForDigits(UserPhone.Text);
            UserPhone.Background = phoneValid ? Brushes.White : Brushes.Coral;

            return birthDateValid && genderValid && raceValid && streetNumberValid && streetNameValid &&
                cityValid && stateValid && zipCodeValid && countryValid && nationalityValid && phoneValid;
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

            if (sender is StackPanel)
            {
                StackPanel sp = (sender as StackPanel);
                sp.Background = Brushes.White;
            }

            if (sender is DatePicker)
            {
                DatePicker dp = (sender as DatePicker);
                dp.Background = Brushes.White;
            }
        }
    }
}
