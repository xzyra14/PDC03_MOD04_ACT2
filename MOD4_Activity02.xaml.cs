using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PDC03_MOD2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MOD4_Activity2 : ContentPage
    {
        ObservableCollection<Employee> employees = new ObservableCollection<Employee>();
        public ObservableCollection<Employee> Employees { get { return Employees; } }
        public MOD4_Activity2()
        {
            InitializeComponent();


            EmployeeView.ItemsSource = employees;

            employees.Add(new Employee { DisplayName = "Juan Dela Cruz", Position = "President", Image = "beach.jpg" });
            employees.Add(new Employee { DisplayName = "Liwayway Cruz", Position = "Vice President", Image = "beach.jpg" });
            employees.Add(new Employee { DisplayName = "John Dee", Position = "Director", Image = "beach.jpg" });
            employees.Add(new Employee { DisplayName = "Mark Cruz", Position = "Supervisor", Image = "beach.jpg" });
            employees.Add(new Employee { DisplayName = "Peter Doe", Position = "Manager", Image = "beach.jpg" });
        }
    }
}