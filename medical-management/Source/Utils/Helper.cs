using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace medical_management
{
    public static class Helper
    {
        public static void FillCombo(this ComboBox cbo, string sql, string value, string display, object[] param)
        {
            DataTable data = Database.Instance.excuteQuery(sql, param);
            cbo.DisplayMember = display; //Trường hiển thị
            cbo.ValueMember = value; //Trường giá trị
            cbo.DataSource = data;
        }

        public static void FillCombo(this ComboBox cbo, string value, string display, DataTable dataSource)
        {
            cbo.DisplayMember = display; //Trường hiển thị
            cbo.ValueMember = value; //Trường giá trị
            cbo.DataSource = dataSource;
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

        public static void formatCurrency(this Control control, decimal value)
        {
            CultureInfo culture = new CultureInfo("vi-VN");
            control.Text = value.ToString("c", culture);
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

        public static string formatCurrencyVN(decimal value)
        {
            CultureInfo culture = new CultureInfo("vi-VN");
            string result = value.ToString("c", culture);
            return result;
        }

        public static string createId(string prefix, string query, string field)
        {
            DataTable data = Database.Instance.excuteQuery(query);
            int key = 0;
            if (data.Rows.Count > 0)
            {
                string lastID = data.Rows[0][field].ToString();
                string index = lastID.Substring(prefix.Length);
                key = Convert.ToInt16(index) + 1;
            }
            else
            {
                key = 1;
            }
           
            return formatStringNumber(key, prefix);
        }

        public static string formatStringNumber(int i, string prefix)
        {
            string result;
            if (i < 10)
            {
                result = prefix + "0000" + i.ToString().Trim();
            }
            else if (i < 100)
            {
                result = prefix + "000" + i.ToString().Trim();
            }
            else if (i < 1000)
            {
                result = prefix + "00" + i.ToString().Trim();
            }
            else if (i < 10000)
            {
                result = prefix + "0" + i.ToString().Trim();
            }
            else result = prefix + i.ToString().Trim();
            return result;
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
            textBox.DataBindings.Add(new Binding("Text", dataSoure, field)
            {
                DataSourceUpdateMode = DataSourceUpdateMode.Never,
                //ControlUpdateMode = ControlUpdateMode.Never
            });
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

        public static void showDialogConfirmDelete(string message, Action callback)
        {
            DialogResult dialogResult = MessageBox.Show(message, "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            if (dialogResult == DialogResult.Yes)
            {
                callback();
            }
            else
            {
                return;
            }
        }

        public static void showErrorMessage(string message)
        {
            MessageBox.Show(message, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void showSuccessMessage(string message)
        {
            MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void showMessageRole()
        {
            MessageBox.Show("Bạn không có quyền sử dụng chức năng này", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
