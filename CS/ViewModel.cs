using DevExpress.Mvvm.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication75 {

    public class ViewModel {
        public ObservableCollection<TestData> List { get; set; }
        public ViewModel() {
            List = new ObservableCollection<TestData>();
            for (int i = 0; i < 30; i++) {
                var t = new TestData() { Text = "Element" + i.ToString(), Number = i, IsChecked = i % 2 == 0, IsChecked_Attribute = i % 2 != 0 };
                List.Add(t);
            }
        }
    }


    public class TestData : INotifyPropertyChanged {
        int number;
        string text;
        bool isChecked;
        bool isChecked_Attribute;
        public int Number {
            get { return number; }
            set {
                if (number == value)
                    return;
                number = value;
                NotifyChanged("Number");
            }
        }
        public string Text {
            get { return text; }
            set {
                if (text == value)
                    return;
                text = value;
                NotifyChanged("Text");
            }
        }
        public bool IsChecked {
            get { return isChecked; }
            set {
                if (isChecked == value)
                    return;
                isChecked = value;
                NotifyChanged("IsChecked");
            }
        }

        [GridEditor(TemplateKey = "ComboBoxEditSettingsTemplate")]
        public bool IsChecked_Attribute {
            get { return isChecked_Attribute; }
            set {
                if (isChecked_Attribute == value)
                    return;
                isChecked_Attribute = value;
                NotifyChanged("IsChecked_Attribute");
            }
        }
        void NotifyChanged(string propertyName) {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        #region INotifyPropertyChanged Members
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion
    }
}