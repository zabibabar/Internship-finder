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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Serialization;

namespace Internships
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<PositionInfo> InternshipCollection = new List<PositionInfo>();
        //List<PositionInfo> Shortlist = new List<PositionInfo>();
        //public ObservableCollection<PositionInfo> Shortlist = new ObservableCollection<PositionInfo> { };
        public List<UserAccount> Users { get; set; } = new List<UserAccount>();
        public List<Employer> Emps { get; set; } = new List<Employer>();
        Employer CurrentEmp { get; set; }
        public UserAccount CurrentUser { get; set; }

        XmlSerializer serializer = new XmlSerializer(typeof(ObservableCollection<PositionInfo>));
        XmlSerializer xmler = new XmlSerializer(typeof(ObservableCollection<PositionInfo>));
        
        public MainWindow(UserAccount user, List<UserAccount> users)
        {
            CurrentUser = user;
            Users = users;
            InternshipCollection =  StorePositions("internships.csv");
            //ReadFile();
            MainWindowVM mainWindow = new MainWindowVM(this, CurrentUser);
            InitializeComponent();
            DataContext = mainWindow;
        }

        private static List<PositionInfo> StorePositions(string pathToFile)
        {
            return
                File.ReadAllLines(pathToFile)
                .Skip(1)
                .Where(line => line.Length > 1)
                .Select(PositionInfo.ParseFromFile).ToList(); 
        }

        /*private void ReadFile()
        {
            string path = "Shortlist.xml";

            if (File.Exists(path))
            {
                using (FileStream rs = new FileStream(path, FileMode.Open, FileAccess.Read))
                {
                    Shortlist = xmler.Deserialize(rs) as ObservableCollection<PositionInfo>;
                }
            }
        }

        public void WriteToFile()
        {
            string path = "Shortlist.xml";
            if (InternshipCollection.Count == 0 && File.Exists(path))
            {
                File.Delete(path);
            }
            else
            {
                using (FileStream filestream = new FileStream(path, FileMode.Create, FileAccess.ReadWrite))
                {
                    serializer.Serialize(filestream, Shortlist);
                }
            }
        }*/

        /*private void Delete(object sender, RoutedEventArgs e)
        {
            if (Shortlisted.SelectedItem != null)
            {
                Shortlist.Remove(Shortlisted.SelectedItem as PositionInfo);
                Shortlisted.ItemsSource = Shortlist;
                WriteToFile();
            }
        }*/
    }
}
