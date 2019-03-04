using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace Internships
{
    public class AddVM
    {
        AddInternship Parent { get; set; }

        public AddVM(AddInternship parent)
        {
            Parent = parent;
        }

        private void AddClicked(object obj)
        {
            if (Parent.ValidateAllEntries())
            {
                string internshipDetails = Parent.Company.Text + "," + (Parent.Position.SelectedItem as ComboBoxItem).Content.ToString() + ","
                    + (Parent.Duration.SelectedItem as ComboBoxItem).Content.ToString() + "," + Parent.City.Text + "," + Parent.State.Text + ","
                    + (Parent.Sponsor.SelectedItem as ComboBoxItem).Content.ToString() + "," + Parent.Link.Text + "," 
                    + (Parent.Cover.SelectedItem as ComboBoxItem).Content.ToString();

                File.AppendAllText("Internships.csv", internshipDetails);
            }
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


    }
}
