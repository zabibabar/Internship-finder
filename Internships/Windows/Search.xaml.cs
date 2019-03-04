using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Internships
{
    /// <summary>
    /// Interaction logic for Search.xaml
    /// </summary>
    public partial class Search : Window
    {
        public List<PositionInfo> InternshipCollection = new List<PositionInfo>();
        //public List<PositionInfo> Query = new List<PositionInfo>();
        //public List<PositionInfo> Shortlist = new List<PositionInfo>();
        public ObservableCollection<PositionInfo> Shortlist = new ObservableCollection<PositionInfo> { };

        public Search(List<PositionInfo> internships, ObservableCollection<PositionInfo> shortlist)
        {
            InternshipCollection = internships;
            Shortlist = shortlist;
            SearchVM search = new SearchVM(this);
            InitializeComponent();
            DataContext = search;
        }

    }
}
