using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GlobalDBTool.WPF
{
    /// <summary>
    /// Конвертер для цветовых палитр, представленных класами Windows.Media.Color (WPF) и Drawing.Color (WindowsForm)
    /// </summary>
    static class WPFColorConverter
    {
        public static System.Windows.Media.Color GetMColor(System.Drawing.Color drawingColor)
        {
            return System.Windows.Media.Color.FromArgb(drawingColor.A, drawingColor.R, drawingColor.G, drawingColor.B);
        }


        public static System.Drawing.Color GetDColor(System.Windows.Media.Color mediaColor)
        {
            return System.Drawing.Color.FromArgb(mediaColor.A, mediaColor.R, mediaColor.G, mediaColor.B);
        }


        public static System.Windows.Media.SolidColorBrush GetMBrush(System.Drawing.Color drawingColor)
        {
            return new System.Windows.Media.SolidColorBrush(GetMColor(drawingColor));
        }


        public static System.Drawing.Color GetDColor(System.Windows.Media.SolidColorBrush brush)
        {
            return System.Drawing.Color.FromArgb(brush.Color.A, brush.Color.R, brush.Color.G, brush.Color.B);
        }
    }
}
