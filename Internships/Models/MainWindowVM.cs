using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Input;

namespace Internships
{
    public class MainWindowVM
    {
        MainWindow Parent { get; set; }
        UserAccount User { get; set; }
        public InternshipsVM InternshipVM { get; set; }

        public MainWindowVM(MainWindow parent, UserAccount user)
        {
            InternshipVM = new InternshipsVM();
            Parent = parent;
            User = user;
        }

        private void PersonalClicked(object obj)
        {
            Personal info = new Personal(Parent.CurrentUser, Parent.Users);
            info.ShowDialog();
        }
        public ICommand PersonalCommand
        {
            get
            {
                if (_personalEvent == null)
                {
                    _personalEvent = new DelegateCommand(PersonalClicked);
                }
                return _personalEvent;
            }
        }
        DelegateCommand _personalEvent;

        private void EducationalClicked(object obj)
        {         
            Education edu = new Education(Parent.CurrentUser, Parent.Users);
            edu.ShowDialog();
        }
        public ICommand EducationalCommand
        {
            get
            {
                if (_educationalEvent == null)
                {
                    _educationalEvent = new DelegateCommand(EducationalClicked);
                }
                return _educationalEvent;
            }
        }
        DelegateCommand _educationalEvent;

        private void SearchClicked(object obj)
        {
            Search search = new Search(Parent.InternshipCollection, InternshipVM.Shortlist);
            search.ShowDialog();
            InternshipVM.Shortlist = search.Shortlist;
            CollectionViewSource.GetDefaultView(InternshipVM.Shortlist).Refresh();
            InternshipVM.WriteToFile();
        }

        public ICommand SearchCommand
        {
            get
            {
                if (_searchEvent == null)
                {
                    _searchEvent = new DelegateCommand(SearchClicked);
                }
                return _searchEvent;
            }
        }
        DelegateCommand _searchEvent;

        private void DeleteClicked(object obj)
        {
            if (InternshipVM.Selected != null)
            {
                InternshipVM.Shortlist.Remove(InternshipVM.Selected as PositionInfo);
                InternshipVM.WriteToFile();
            }
        }
        public ICommand DeleteCommand
        {
            get
            {
                if (_deleteEvent == null)
                {
                    _deleteEvent = new DelegateCommand(DeleteClicked);
                }
                return _deleteEvent;
            }
        }
        DelegateCommand _deleteEvent;
    }
}
