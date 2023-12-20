using Syncfusion.Maui.DataGrid;
using Syncfusion.Maui.DataGrid.DataPager;
using Syncfusion.Maui.DataGrid.Helper;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SfDataGridSample.Behaviors
{
    public class DataGridBehavior : Behavior<ContentPage>
    {
        private SfDataGrid? dataGrid;
        private EmployeeViewModel? employeeViewModel;

        protected override void OnAttachedTo(ContentPage page)
        {
            base.OnAttachedTo(page);
            employeeViewModel = new EmployeeViewModel();
            dataGrid = page.FindByName<SfDataGrid>("dataGrid");
            dataGrid.ItemsSource = employeeViewModel.Employees;
            dataGrid.DefaultStyle.HeaderRowBackground = Colors.Red;
        }

        protected override void OnDetachingFrom(ContentPage page)
        {
            base.OnDetachingFrom(page);
        }
    }
}
