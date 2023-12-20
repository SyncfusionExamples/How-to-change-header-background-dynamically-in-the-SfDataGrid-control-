# How to change header background dynamically in the SfDataGrid control?

The [.NET MAUI DataGrid](https://www.syncfusion.com/maui-controls/maui-datagrid) allows you to change the header row background color dynamically by using [HeaderRowBackground](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridStyle.html#Syncfusion_Maui_DataGrid_DataGridStyle_HeaderRowBackground) in `SfDataGrid.DefaultStyle`. 

The below code example illustrates how to change header background dynamically.
```Behavior.cs
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
```

Please find the sample from the below link.

[View sample in Github](https://github.com/SyncfusionExamples/How-to-change-header-background-dynamically-in-the-SfDataGrid-control-/tree/master)

Take a moment to explore this [documentation](https://help.syncfusion.com/maui/datagrid/overview), where you can find more information about Syncfusion .NET MAUI DataGrid (SfDataGrid) with code examples. Please refer to this [link](https://www.syncfusion.com/maui-controls/maui-datagrid) to learn about the essential features of Syncfusion .NET MAUI DataGrid (SfDataGrid).

##### Conclusion

I hope you enjoyed learning about How to change header background dynamically in the SfDataGrid control? in .NET MAUI DataGrid (SfDataGrid).

You can refer to our [.NET MAUI DataGrid’s feature tour](https://www.syncfusion.com/maui-controls/maui-datagrid) page to learn about its other groundbreaking feature representations. You can also explore our [.NET MAUI DataGrid Documentation](https://help.syncfusion.com/maui/datagrid/getting-started) to understand how to present and manipulate data. 
For current customers, you can check out our .NET MAUI components on the [License and Downloads](https://www.syncfusion.com/sales/teamlicense) page. If you are new to Syncfusion, you can try our 30-day [free trial](https://www.syncfusion.com/downloads/maui) to explore our .NET MAUI DataGrid and other .NET MAUI components.

If you have any queries or require clarifications, please let us know in the comments below. You can also contact us through our [support forums](https://www.syncfusion.com/forums), [Direct-Trac](https://support.syncfusion.com/create) or [feedback portal](https://www.syncfusion.com/feedback/maui?control=sfdatagrid), or the feedback portal. We are always happy to assist you!

