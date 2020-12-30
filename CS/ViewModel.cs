using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication75 {

    public class ViewModel : ViewModelBase {
        public ObservableCollection<TestData> List {
            get { return GetProperty(() => List); }
            set { SetProperty(() => List, value); }
        }
        public ViewModel() {
            List = new ObservableCollection<TestData>();
            for (int i = 0; i < 30; i++) {
                var t = new TestData() { Text = "Element" + i.ToString(), Number = i, IsChecked = i % 2 == 0, IsChecked_Attribute = i % 2 != 0 };
                List.Add(t);
            }
        }
    }


    public class TestData : BindableBase {
        public int Number {
            get { return GetProperty(() => Number); }
            set { SetProperty(() => Number, value); }
        }
        public string Text {
            get { return GetProperty(() => Text); }
            set { SetProperty(() => Text, value); }
        }
        public bool IsChecked {
            get { return GetProperty(() => IsChecked); }
            set { SetProperty(() => IsChecked, value); }
        }

        [GridEditor(TemplateKey = "ComboBoxEditSettingsTemplate")]
        public bool IsChecked_Attribute {
            get { return GetProperty(() => IsChecked_Attribute); }
            set { SetProperty(() => IsChecked_Attribute, value); }
        }
    }
}