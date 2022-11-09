using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsControls
{
    public partial class MyControl: UserControl
    {
        public MyControl()
        {
            InitializeComponent();
        }

        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        public bool IsChecked
        {
            get => CheckBox.Checked;
            set
            {
                CheckBox.Checked = value;
            }
        }

        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        public string TextBoxText
        {
            get => TextBox.Text;
            set
            {
                TextBox.Text = value;
            }
        }

        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        public bool GetCheckBoxValue()
        {
            return this.CheckBox.Checked;
        }

        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        public string GetTextBoxValue()
        {
            return this.TextBox.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
