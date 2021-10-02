using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace medical_management
{
    public static class Helper
    {
        public static void disable(this Control control)
        {
            control.Enabled = false;
        }

        public static void enable(this Control control)
        {
            control.Enabled = true;
        }

        public static void visible(this Control control)
        {
            control.Visible = true;
        }

        public static void gone(this Control control)
        {
            control.Visible = false;
        }

        public static bool isVisible(this Control control)
        {
            return control.Visible;
        }

        public static void visibleOrGone(this Control control, bool isVisible)
        {
            if (isVisible)
            {
                control.Visible = false;
            }
            else
            {
                control.Visible = true;
            }
        }
    }
}
