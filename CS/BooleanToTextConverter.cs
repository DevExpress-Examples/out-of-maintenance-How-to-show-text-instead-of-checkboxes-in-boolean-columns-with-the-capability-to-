using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Markup;

namespace WpfApplication75 {
    public class BooleanToTextConverter : MarkupExtension, IValueConverter {

        #region IValueConverter Members

        public object Convert(object value, System.Type targetType, object parameter, System.Globalization.CultureInfo culture) {
            if (value == null) return "null";
            if ((bool)value)
                return "Yes";
            else
                return "No";
        }

        public object ConvertBack(object value, System.Type targetType, object parameter, System.Globalization.CultureInfo culture) {
            throw new System.NotImplementedException();
        }

        #endregion

        public override object ProvideValue(System.IServiceProvider serviceProvider) {
            return this;
        }
    }
}