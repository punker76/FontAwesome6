﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Data;
using System.Windows.Markup;
using System.Windows.Media;

using FontAwesome6.Fonts.Extensions;

namespace FontAwesome6.Fonts.Converters
{
  public class DrawingConverter : IValueConverter
  {
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
      if (value.GetType() == typeof(EFontAwesomeIcon))
      {
        var icon = (EFontAwesomeIcon)value;
        var brush = parameter is Brush b ? b : Brushes.Black;

        return icon.CreateDrawing(brush);
      }

      throw new NotImplementedException();
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
      throw new NotImplementedException();
    }
  }
}
