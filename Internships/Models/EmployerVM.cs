using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Internships
{
    public class EmployerVM: INotifyPropertyChanged
    {
        List<PositionInfo> InternshipCollection = new List<PositionInfo>();
        EmployerWindow Parent { get; set; }
        public EmployerVM(EmployerWindow parent)
        {
            Parent = parent;
            EName = Parent.Emp.Name;
            InternshipCollection = StorePositions("internships.csv");
        }

        private string _ename;
        public string EName
        {
            get { return _ename; }
            set
            {
                if (_ename != value)
                {
                    _ename = value;
                    PropertyChanged(this, new PropertyChangedEventArgs("EName"));
                }
            }
        }

        private void AddClicked(object obj)
        {
            AddInternship add = new AddInternship();
            add.ShowDialog();
        }
        public ICommand AddCommand
        {
            get
            {
                if (_addEvent == null)
                {
                    _addEvent = new DelegateCommand(AddClicked);
                }

                return _addEvent;
            }
        }
        DelegateCommand _addEvent;


        private static List<PositionInfo> StorePositions(string pathToFile)
        {
            return
                File.ReadAllLines(pathToFile)
                .Skip(1)
                .Where(line => line.Length > 1)
                .Select(PositionInfo.ParseFromFile).ToList();
        }
        public event PropertyChangedEventHandler PropertyChanged = delegate { };
    }
}
