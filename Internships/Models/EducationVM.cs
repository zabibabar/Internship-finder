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
    public class EducationVM
    {
        Education Parent { get; set; }
        public UserAccount CurrentUser { get; set; }

        public EducationVM(Education parent, UserAccount currentUser)
        {
            Parent = parent;
            CurrentUser = currentUser;
        }


        private void SubmitClicked(object obj)
        {
            if (Parent.ValidateAllEntries())
            {
                CurrentUser.School = Parent.UserSchool.Text;
                CurrentUser.Major = Parent.UserMajor.Text;
                CurrentUser.GPA = Parent.GPA.Text;
                CurrentUser.EnrollmentYear = Parent.UserEnrollment.SelectedDate.Value.Year.ToString();
                CurrentUser.ExpectedGraduationYear = Parent.UserGraduation.SelectedDate.Value.Year.ToString();
                CurrentUser.CollegeStanding = (Parent.UserCollegeStanding.SelectedItem as ComboBoxItem).Content.ToString();

                if (CurrentUser.EducationalInfoEntered == "No")
                {
                    CurrentUser.EducationalInfoEntered = "Yes";
                    Parent.WriteToFile();
                    MainWindow mw = new MainWindow(CurrentUser, Parent.Users);
                    Parent.Close();
                    mw.Show();
                }
                else
                {
                    Parent.WriteToFile();
                    Parent.Close();
                }
            }
            else MessageBox.Show("Invalid or missing entries");

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
