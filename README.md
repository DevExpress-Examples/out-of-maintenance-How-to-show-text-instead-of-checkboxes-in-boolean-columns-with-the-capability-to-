# How-to-show-text-instead-of-checkboxes-in-boolean-columns-with-the-capability-to-search-by-this-text
.NET, WPF, GridControl

This example demonstrates how to show the required text instead of checkboxes in column cells. To specify an editor for an individual property, use the GridEditor [Data Annotation Attribute](https://docs.devexpress.com/WPF/16863/mvvm-framework/data-annotation-attributes) for a corresponding data source field as follows:

```C#
using DevExpress.Mvvm.DataAnnotations;

//...
 
[GridEditor(TemplateKey = "TextEditSettingsTemplate")]
public bool IsChecked_Attribute { get; set; }
```

TemplateKey is the key of a corresponding template that you can put into your Window/UserControl's or application's resources. Note that GridControl will take  [Data Annotation Attributes](https://docs.devexpress.com/WPF/16863/mvvm-framework/data-annotation-attributes) into account when either the [**EnableSmartColumnsGeneration**](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.DataControlBase.EnableSmartColumnsGeneration) or  [GridColumn.IsSmart](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.ColumnBase.IsSmart) property is set to **True**.

  
If you do not have the opportunity to modify the data source's structure manually, you can use **MetadataLocator** as described in the [DevExpress MVVM Framework. Using DataAnnotation attributes and DevExpress Fluent API](https://community.devexpress.com/blogs/wpf/archive/2014/03/31/devexpress-mvvm-framework-using-dataannotation-attributes-and-devexpress-fluent-api.aspx) blog post.  
  
The attached sample illustrates both these approaches with the GridEditor [Data Annotation Attribute](https://docs.devexpress.com/WPF/16863/mvvm-framework/data-annotation-attributes) and MetadataLocator.
