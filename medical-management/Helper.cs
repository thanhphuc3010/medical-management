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
        /**
         * <summary>Disable a control like: button, textbox, label,...</summary>
         */
        public static void disable(this Control control)
        {
            control.Enabled = false;
        }

        /**
         * <summary>Enable a control like: button, textbox, label,...</summary>
         */
        public static void enable(this Control control)
        {
            control.Enabled = true;
        }

        /**
         * <summary>Show a cotrol</summary>
         */
        public static void visible(this Control control)
        {
            control.Visible = true;
        }

        /**
         * <summary>Hide a cotrol</summary>
         */
        public static void gone(this Control control)
        {
            control.Visible = false;
        }

        /**
         * <summary>Return state of control</summary>
         * <returns>
         * - Return true if control is visible
         * - Return fale if control is unvisible (hide)
         * </returns>
         */
        public static bool isVisible(this Control control)
        {
            return control.Visible;
        }

        /**
         * <summary>Hide or show control following visible state of control</summary>
         * <param name="isVisible">A bool value if isVisible = true then hide control, othewise show control</param>
         */
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
