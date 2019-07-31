using Xamarin.Forms;
using System;
public class DateTimeToStringConverter: IValueConverter
{
	public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
	{
		if (value is DateTime dateTime)
		{
			if (parameter is string pattern)
			{
				return dateTime.ToString(pattern);
			}
			else
			{
				return dateTime.ToString();
			}

		}
	}
	public virtual object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
	{
		return value;
	}
}
