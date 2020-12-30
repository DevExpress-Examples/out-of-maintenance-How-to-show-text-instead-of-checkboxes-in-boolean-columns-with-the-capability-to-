using DevExpress.Mvvm.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApplication75 {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            MetadataLocator.Default = MetadataLocator.Create().AddMetadata<bool, EditorProvider>();
            InitializeComponent();
        }
    }
    public class EditorProvider : IMetadataProvider<bool> {
        public void BuildMetadata(MetadataBuilder<bool> builder) {
            builder.GridEditor("CheckEditSettingsTemplate");
        }
    }
}