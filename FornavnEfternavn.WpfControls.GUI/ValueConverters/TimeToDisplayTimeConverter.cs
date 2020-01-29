using System;
using System.Globalization;

namespace FornavnEfternavn.WpfControls.GUI
{
    /// <summary>
    /// A converter that takes in date and converts it to a user friendly time
    /// </summary>
    public class TimeToDisplayTimeConverter : BaseValueConverter<TimeToDisplayTimeConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            //Get the time passed in
            var time = (DateTime)value;           

            //Return a full date
            return time.ToLocalTime().ToString("dd MM yyyy");
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
