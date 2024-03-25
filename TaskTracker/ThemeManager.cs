using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskTracker
{
    public static class ThemeManager
    {
        public static string GetColor(string theme)
        {
            switch (theme)
            {
                case "color1":
                    return "#DCE6EC";
                case "color2":
                    return "#9BB1BE";
                case "color3":
                    return "#4F6C81";
                case "color4":
                    return "#26364C";
                default:
                    return "#DCE6EC";
            }
        }
    }
}
