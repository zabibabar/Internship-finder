using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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
    /// Interaction logic for EmployerWindow.xaml
    /// </summary>
    public partial class EmployerWindow : Window
    {
        public Employer Emp { get; set; }

        public EmployerWindow(Employer emp)
        {
            Emp = emp;
            EmployerVM ew = new EmployerVM(this);
            InitializeComponent();
            this.DataContext = ew;
            //EName = Emp.Name;
        }

        
    }
}
