using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Xml.Serialization;

namespace Internships
{
    public class CreateVM
    {
        CreateAccount Parent { get; set; }
        public List<UserAccount> Users { get; set; } = new List<UserAccount>();
        public List<Employer> Employers { get; set; } = new List<Employer>();

        XmlSerializer xmler = new XmlSerializer(typeof(List<UserAccount>));
        XmlSerializer empxmler = new XmlSerializer(typeof(List<Employer>));
        public bool IsEdit { get; set; }
        public UserAccount EditingUser { get; set; }

        public CreateVM(CreateAccount parent, List<UserAccount> users, bool isEdit, List<Employer> employers)
        {
            Parent = parent;
            Users = users;
            IsEdit = IsEdit;
        }

        private void CreateClicked(object obj)
        {
            if (Parent.ValidateAllEntries())
            {
               if (Convert.ToBoolean(Parent.Intern.IsChecked))
                {
                    UserAccount act = new UserAccount(Parent.UserCreatedLogin.Text, 
                        Parent.UserCreatedPassword.Password, Parent.UserCreatedEmail.Text, "No", "No");
                    Users.Add(act);

                    string path = "Users.xml";
                    using (FileStream fs = new FileStream(path, FileMode.Create, FileAccess.ReadWrite))
                    {
                        xmler.Serialize(fs, Users);
                    }

                    MessageBox.Show("Account has been Updated", "Success!");
                    Parent.Close();
                }
               else if (Convert.ToBoolean(Parent.Employer.IsChecked))
                {
                    Employer act = new Employer(Parent.UserCreatedPassword.Password, Parent.UserCreatedEmail.Text, Parent.UserCreatedLogin.Text, "No");
                    Employers.Add(act);

                    string path = "Employers.xml";
                    using (FileStream fs = new FileStream(path, FileMode.Create, FileAccess.ReadWrite))
                    {
                        empxmler.Serialize(fs, Employers);
                    }

                    MessageBox.Show("Account has been Updated", "Success!");
                    Parent.Close();
                }

            }
            else MessageBox.Show("Invalid entries.");
        }
        public ICommand CreateCommand
        {
            get
            {
                if (_createEvent == null)
                {
                    _createEvent = new DelegateCommand(CreateClicked);
                }
                return _createEvent;
            }
        }
        DelegateCommand _createEvent;

        private void CancelClicked(object obj)
        {
            Parent.Close();
        }
        public ICommand CancelCommand
        {
            get
            {
                if (_cancelEvent == null)
                {
                    _cancelEvent = new DelegateCommand(CancelClicked);
                }
                return _cancelEvent;
            }
        }
        DelegateCommand _cancelEvent;


    }
}
