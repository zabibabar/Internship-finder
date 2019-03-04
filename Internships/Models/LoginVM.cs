using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Xml.Serialization;

namespace Internships
{
   
    public class LoginVM
    {
        Login Parent { get; set; }

        public List<UserAccount> Users { get; set; } = new List<UserAccount>();
        XmlSerializer userxmler = new XmlSerializer(typeof(List<UserAccount>));

        public List<Employer> Employers { get; set; } = new List<Employer>();
        XmlSerializer empxmler = new XmlSerializer(typeof(List<Employer>));

        public bool IsEdit { get; set; }

        public LoginVM(Login parent)
        {
            Parent = parent;
            ReadInUsers();
        }

        private void ReadInUsers()
        {
            string path = "Users.xml";

            if (File.Exists(path))
            {
                using (FileStream rs = new FileStream(path, FileMode.Open, FileAccess.Read))
                {
                    Users = userxmler.Deserialize(rs) as List<UserAccount>;
                }
            }

            path = "Employers.xml";

            if (File.Exists(path))
            {
                using (FileStream rs = new FileStream(path, FileMode.Open, FileAccess.Read))
                {
                    Employers = empxmler.Deserialize(rs) as List<Employer>;
                }
            }
        }

        private void LoginClicked(object obj)
        {
            if (Parent.ValidateAllEntries())
            {
                Employer emp = Employers.FirstOrDefault(x => x.Login == Parent.UserEnteredLogin.Text);
                UserAccount act = Users.FirstOrDefault(x => x.Login == Parent.UserEnteredLogin.Text);
                if (emp?.Password == Parent.UserEnteredPassword.Password)
                {
                    if (emp.PersonalInfoFilled == "Yes")
                    {
                        EmployerWindow mw = new EmployerWindow(emp);
                        Parent.Close();
                        mw.Show();
                    }
                    else
                    {
                        EmployerInformationxaml ei = new EmployerInformationxaml(emp, Employers);
                        Parent.Close();
                        ei.Show();
                    }
                }
                else if (act?.Password == Parent.UserEnteredPassword.Password)
                {
                    if (act.PersonalInfoEntered == "No")
                    {
                        Personal info = new Personal(act, Users);
                        Parent.Close();
                        info.Show();
                    }
                    else if (act.EducationalInfoEntered == "No")
                    {
                        Education edu = new Education(act, Users);
                        Parent.Close();
                        edu.Show();
                    }
                    else if (act.EducationalInfoEntered == "Yes")
                    {
                        MainWindow mw = new MainWindow(act, Users);
                        Parent.Close();
                        mw.Show();
                    }
                }
                else
                    MessageBox.Show("Invalid Login Credentials");

            }
        }
        public ICommand LoginCommand
        {
            get
            {
                if (_loginEvent == null)
                {
                    _loginEvent = new DelegateCommand(LoginClicked);
                }
                return _loginEvent;
            }
        }
        DelegateCommand _loginEvent;

        private void CancelClicked(object obj)
        {
            Application.Current.Shutdown();
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

        private void CreateClicked(object obj)
        {
            CreateAccount act = new CreateAccount(Users, Employers);
            act.ShowDialog();
            Employers = act.Employers;
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
    }
}
