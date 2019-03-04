using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Internships
{
    public class InternshipsVM: INotifyPropertyChanged
    {
        public ObservableCollection<PositionInfo> Shortlist { get; set; } = new ObservableCollection<PositionInfo>();

        XmlSerializer serializer = new XmlSerializer(typeof(ObservableCollection<PositionInfo>));
        XmlSerializer xmler = new XmlSerializer(typeof(ObservableCollection<PositionInfo>));

        public InternshipsVM()
        {
            ReadFile();           
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

        private void ReadFile()
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
            if (Shortlist.Count == 0 && File.Exists(path))
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
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
