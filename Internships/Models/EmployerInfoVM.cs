using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Internships
{
    public class EmployerInfoVM
    {
        EmployerInformationxaml Parent { get; set; }
        Employer Emp { get; set; }

        public EmployerInfoVM(EmployerInformationxaml parent, Employer currentUser)
        {
            Parent = parent;
            Emp = currentUser;
        }

        private void SubmitClicked(object obj)
        {
            if (Parent.ValidateAllEntries())
            {
                Emp.Name = Parent.UserName.Text;
                Emp.Company = Parent.UserCompany.Text;
                Emp.Address = Parent.UserAddress.Text;
                Emp.Phone = Parent.UserPhone.Text;

                if (Emp.PersonalInfoFilled == "No")
                {
                    Emp.PersonalInfoFilled = "Yes";
                    Parent.WriteToFile();
                    EmployerWindow ew = new EmployerWindow(Emp);
                    Parent.Close();
                    ew.Show();
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
