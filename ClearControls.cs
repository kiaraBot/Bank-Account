// Alix Field           afield@cnm.edu          FieldP6_CSharp
// File: Form1.cs           _ClearControls.cs

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FieldP6_CSharp
{
    class ClearControls
    {

        public static void ResetAllControls(Control form)
        {
            foreach (Control control in form.Controls)
            {
                // Wasn't Sure how to clear radio buttons w/in a groupbox from a class


                if (control is TextBox)
                {
                    TextBox textBox = (System.Windows.Forms.TextBox)control;
                    textBox.Text = null;
                }

                if (control is ComboBox)
                {
                    ComboBox comboBox = (ComboBox)control;
                    if (comboBox.Items.Count > 0)
                        comboBox.SelectedIndex = 0;
                }

                if (control is CheckBox)
                {
                    CheckBox checkBox = (CheckBox)control;
                    checkBox.Checked = false;
                }

                if (control is ListBox)
                {
                    ListBox listBox = (ListBox)control;
                    listBox.ClearSelected();
                }

                if(control is RadioButton)
                {
                    RadioButton radioButton = (RadioButton)control;
                    radioButton.Checked = false;
                }
            }
        }
    }
}
