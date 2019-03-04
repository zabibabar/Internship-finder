using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;

namespace Internships
{
    public class SearchVM
    {
        Search Parent { get; set; }
        public SearchListVM SearchListVM { get; set; }

        public SearchVM(Search parent)
        {
            Parent = parent;
            SearchListVM = new SearchListVM();
        }

        private void SubmitClicked(object obj)
        {
            string selectedSemester = Parent.SearchSemesters.SelectionBoxItem.ToString();

            if (!string.IsNullOrWhiteSpace(Parent.SearchCompany.Text))
            {
                var list = Parent.InternshipCollection.Where(x => x.CompanyName == Parent.SearchCompany.Text).ToList();
                SearchListVM.Query = new ObservableCollection<PositionInfo>(list);
            }

            if (!string.IsNullOrWhiteSpace(Parent.SearchPosition.Text))
            {
                var list = Parent.InternshipCollection.Where(x => x.Position == Parent.SearchPosition.Text).ToList();
                SearchListVM.Query = new ObservableCollection<PositionInfo>(list);

            }

            if (!string.IsNullOrWhiteSpace(Parent.SearchCity.Text))
            {
                var list = Parent.InternshipCollection.Where(x => x.City == Parent.SearchCity.Text).ToList();
                SearchListVM.Query = new ObservableCollection<PositionInfo>(list);

            }

            if (!string.IsNullOrWhiteSpace(Parent.SearchState.Text))
            {
                var list = Parent.InternshipCollection.Where(x => x.State == Parent.SearchState.Text).ToList();
                SearchListVM.Query = new ObservableCollection<PositionInfo>(list);
            }

            if (Convert.ToBoolean(Parent.Yes.IsChecked) || Convert.ToBoolean(Parent.No.IsChecked))
            {
                string IsSponsor = Parent.SearchSponsorship.Children.OfType<RadioButton>().FirstOrDefault(x => (bool)x.IsChecked).Content.ToString();
                if (!string.IsNullOrWhiteSpace(IsSponsor))
                {
                    var list = Parent.InternshipCollection.Where(c => c.Sponsorship == IsSponsor).ToList();
                    SearchListVM.Query = new ObservableCollection<PositionInfo>(list);

                }
            }

            if (selectedSemester != "")
            {
                if (Parent.SearchSemesters.SelectedIndex != 3)
                {
                    var list = Parent.InternshipCollection.Where(c => c.TimePeriod == selectedSemester).ToList();
                    SearchListVM.Query = new ObservableCollection<PositionInfo>(list);

                }
                else
                {
                    var list = Parent.InternshipCollection;
                    SearchListVM.Query = new ObservableCollection<PositionInfo>(list);

                }
            }

            CollectionViewSource.GetDefaultView(SearchListVM.Query).Refresh();

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

        private void ApplyClicked(object obj)
        {
            if (SearchListVM.Selected != null)
            {
                MessageBox.Show((SearchListVM.Selected as PositionInfo).ApplicationLink, "Application Link");
            }
        }
        public ICommand ApplyCommand
        {
            get
            {
                if (_applyEvent == null)
                {
                    _applyEvent = new DelegateCommand(ApplyClicked);
                }
                return _applyEvent;
            }
        }
        DelegateCommand _applyEvent;

        private void ShortClicked(object obj)
        {
            if (SearchListVM.Selected != null)
            {
                if (Parent.Shortlist.Count == 0)
                    Parent.Shortlist.Add(SearchListVM.Selected as PositionInfo);
                else if (!Parent.Shortlist.Contains(SearchListVM.Selected))
                    Parent.Shortlist.Add(SearchListVM.Selected as PositionInfo);
            }
        }
        public ICommand ShortCommand
        {
            get
            {
                if (_shortEvent == null)
                {
                    _shortEvent = new DelegateCommand(ShortClicked);
                }
                return _shortEvent;
            }
        }
        DelegateCommand _shortEvent;
    }
}
