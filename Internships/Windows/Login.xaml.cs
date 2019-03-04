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
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public List<UserAccount> Users { get; set; } = new List<UserAccount>();
        XmlSerializer userxmler = new XmlSerializer(typeof(List<UserAccount>));

        public List<Employer> Employers { get; set; } = new List<Employer>();
        XmlSerializer empxmler = new XmlSerializer(typeof(List<Employer>));

        public bool IsEdit { get; set; }

        public Login()
        {
            LoginVM loginvm = new LoginVM(this);
            InitializeComponent();
            DataContext = loginvm;
            //ReadInUsers();
        }

        /*private void ReadInUsers()
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

        private void LoginCommand(object sender, RoutedEventArgs e)
        {
            if (ValidateAllEntries())
            {
                Employer emp = Employers.FirstOrDefault(x => x.Login == UserEnteredLogin.Text);
                UserAccount act = Users.FirstOrDefault(x => x.Login == UserEnteredLogin.Text);
                if (emp?.Password == UserEnteredPassword.Password)
                {
                    if (emp.PersonalInfoFilled == "Yes")
                    {
                        EmployerWindow mw = new EmployerWindow(emp);
                        this.Close();
                        mw.Show();
                    }
                    else
                    {
                        EmployerInformationxaml ei = new EmployerInformationxaml(emp, Employers);
                        this.Close();
                        ei.Show();
                    }
                }
                else if (act?.Password == UserEnteredPassword.Password)
                {
                    if (act.PersonalInfoEntered == "No")
                    {
                        Personal info = new Personal(act, Users);
                        this.Close();
                        info.Show();
                    }
                    else if (act.EducationalInfoEntered == "No")
                    {
                        Education edu = new Education(act, Users);
                        this.Close();
                        edu.Show();
                    }
                    else if (act.EducationalInfoEntered == "Yes")
                    {
                        MainWindow mw = new MainWindow(act, Users);
                        this.Close();
                        mw.Show();
                    }
                }
                else
                    MessageBox.Show("Invalid Login Credentials");

            }
        }*/

        public bool ValidateAllEntries()
        {
            if (string.IsNullOrWhiteSpace(UserEnteredLogin.Text)) { return false; }
            if (string.IsNullOrWhiteSpace(UserEnteredPassword.Password)) { return false; }

            return true;
        }
        /*
        private void CancelCommand(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void CreateCommand(object sender, RoutedEventArgs e)
        {
            CreateAccount act = new CreateAccount(Users, Employers);
            act.ShowDialog();
        }*/
    }
}
