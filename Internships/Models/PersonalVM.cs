using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Internships
{
    public class PersonalVM
    {
        public UserAccount CurrentUser { get; set; }
        Personal Parent { get; set; }

        public PersonalVM(Personal parent, UserAccount currentUser)
        {
            Parent = parent;
            CurrentUser = currentUser;
        }

        private void SubmitClicked(object obj)
        {
            if (Parent.ValidateAllEntries())
            {
                CurrentUser.FirstName = Parent.UserFirstName.Text;
                CurrentUser.LastName = Parent.UserLastName.Text;
                CurrentUser.BirthDate = Parent.UserBirthDate.SelectedDate.Value.ToString();
                CurrentUser.Gender = Parent.UserGender.Children.OfType<RadioButton>().FirstOrDefault(x => (bool)x.IsChecked).Content.ToString();
                CurrentUser.Race = (Parent.UserRace.SelectedItem as ComboBoxItem).Content.ToString();
                CurrentUser.StreetName = Parent.UserStreetName.Text;
                CurrentUser.StreetNumber = Parent.UserStreetNumber.Text;
                CurrentUser.City = Parent.UserCity.Text;
                CurrentUser.State = Parent.UserState.Text;
                CurrentUser.ZipCode = Parent.UserZipCode.Text;
                CurrentUser.Country = Parent.UserZipCode.Text;
                CurrentUser.Nationality = Parent.UserNationality.Text;
                CurrentUser.PhoneNumber = Parent.UserPhone.Text;

                if (CurrentUser.EducationalInfoEntered == "No")
                {
                    CurrentUser.PersonalInfoEntered = "Yes";
                    Parent.WriteToFile();
                    Education edu = new Education(CurrentUser, Parent.Users);
                    Parent.Close();
                    edu.Show();
                }
                else
                {
                    Parent.WriteToFile();
                    Parent.Close();
                }
            }
            else
                MessageBox.Show("Invalid Entries", "Try Again");
        }
        public ICommand SubmitCommand
        {
            get
            {
                if (_submitEvent == null)
                {
                    _submitEvent = new DelegateCommand(SubmitClicked);
                }
                return _submitEvent;
            }
        }
        DelegateCommand _submitEvent;
    }
}
