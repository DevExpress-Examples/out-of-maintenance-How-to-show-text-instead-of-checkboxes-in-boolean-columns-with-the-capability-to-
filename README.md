<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/180361838/21.1.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T830436)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
# How to show text instead of checkboxes in boolean columns with the capability to search by this text

This example demonstrates how to show the required text for checkboxes in a column's cells and drop-down filter.

1\. To specify an editor for an individual property, use the GridEditor [Data Annotation Attribute](https://docs.devexpress.com/WPF/16863/mvvm-framework/data-annotation-attributes) for a corresponding data source field as follows:

   ```C#
   using DevExpress.Mvvm.DataAnnotations;
   
   //...
 
   [GridEditor(TemplateKey = "TextEditSettingsTemplate")]
   public bool IsChecked_Attribute { get; set; }
   ```

   TemplateKey is the key of a corresponding template that you can put into your Window/UserControl's or application's resources. Note that GridControl will take  [Data Annotation Attributes](https://docs.devexpress.com/WPF/16863/mvvm-framework/data-annotation-attributes) into account when either the [**EnableSmartColumnsGeneration**](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.DataControlBase.EnableSmartColumnsGeneration) or  [GridColumn.IsSmart](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.ColumnBase.IsSmart) property is set to **True**.

  
2\. If you do not have the opportunity to modify the data source's structure manually, you can use **MetadataLocator** as described in the [DevExpress MVVM Framework. Using DataAnnotation attributes and DevExpress Fluent API](https://community.devexpress.com/blogs/wpf/archive/2014/03/31/devexpress-mvvm-framework-using-dataannotation-attributes-and-devexpress-fluent-api.aspx) blog post.  
  
The attached sample illustrates both these approaches with the GridEditor [Data Annotation Attribute](https://docs.devexpress.com/WPF/16863/mvvm-framework/data-annotation-attributes) and MetadataLocator.

3\. Alternatively, you can specify a column editor in XAML, for example:
   ```xaml
   <dxg:GridColumn FieldName="IsChecked">
       <dxg:GridColumn.EditSettings>
           <!--Use TextEditSettings if you want to display your custom text in cells as well-->
           <dxe:CheckEditSettings DisplayTextConverter="{dxmvvm:BooleanToObjectConverter TrueValue=Yes, FalseValue=No}"/>
       </dxg:GridColumn.EditSettings>
   </dxg:GridColumn>
   ```
