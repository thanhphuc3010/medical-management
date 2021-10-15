using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace medical_management
{
    public static class Helper
    {
        public static void FillCombo(string sql, ComboBox cbo, string ma, string ten)
        {

            DataTable data = Database.Instance.excuteQuery(sql);
            cbo.DisplayMember = ten; //Trường hiển thị
            cbo.ValueMember = ma; //Trường giá trị
            cbo.DataSource = data;
        }


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
         * <param name="isVisible">state of control: true if control is visible else false</param>
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

        public static void setHint(this TextBox textBox, string hint)
        {
            string placeHolder = hint;
            System.Drawing.Color DefaultColor;
            // get default color of text
            DefaultColor = textBox.ForeColor;
            // Add event handler for when the control gets focus
            textBox.GotFocus += (object sender, EventArgs e) =>
            {
                textBox.Text = String.Empty;
                textBox.ForeColor = DefaultColor;
            };

            // add event handling when focus is lost
            textBox.LostFocus += (Object sender, EventArgs e) =>
            {
                if (String.IsNullOrEmpty(textBox.Text) || textBox.Text == placeHolder)
                {
                    textBox.ForeColor = System.Drawing.Color.Gray;
                    textBox.Text = hint;
                }
                else
                {
                    textBox.ForeColor = DefaultColor;
                }
            };

            if (!string.IsNullOrEmpty(placeHolder))
            {
                // change style   
                textBox.ForeColor = System.Drawing.Color.Gray;
                // Add text
                placeHolder = hint;
                textBox.Text = placeHolder;
            }
        }

        public static void binding(this TextBox textBox, object dataSoure, string field)
        {
            textBox.DataBindings.Clear();
            textBox.DataBindings.Add(new Binding("Text", dataSoure, field));
        }

        public static void superBinding(List<TextBox> list, List<String> fields, object dataSoure)
        {
            if (list.Count != fields.Count) return;
            foreach (TextBox txt in list)
            {
                int index = list.IndexOf(txt);
                string field = fields[index];
                txt.binding(dataSoure, field);
            }
        }

        public static void showMessage(string message)
        {
            MessageBox.Show(message, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void showMessageRole()
        {
            MessageBox.Show("Bạn không có quyền sử dụng chức năng này", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
