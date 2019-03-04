using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internships
{
    public class SearchListVM: INotifyPropertyChanged
    {
        private ObservableCollection<PositionInfo> _query = new ObservableCollection<PositionInfo>();
        public ObservableCollection<PositionInfo> Query
        {
            get { return _query; }
            set
            {
                _query = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Query"));
            }
        }


        private PositionInfo selected;
        public PositionInfo Selected
        {
            get { return selected; }
            set
            {
                selected = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Selected"));
            }
        }

        public SearchListVM()
        {

        }


        public event PropertyChangedEventHandler PropertyChanged= delegate { };
    }
}
