using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace lab1
{
    public partial class Form1 : Form
    {
        TextBox SelectedTextBox;
        public Form1()
        {
            InitializeComponent();
            button_point.Text = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;
        }


        private void button_Click(object sender, EventArgs e)
        {

            Button button = (Button)sender;
            if (SelectedTextBox != null)
                SelectedTextBox.Text = SelectedTextBox.Text + button.Text;


        }
        private void ClearTextBox()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
            };

            func(Controls);
        }

        private void calculate_click(object sender, EventArgs e)
        {
            double a1, a2, a3, a4, b1, b2, b3, b4;
            if (!double.TryParse(textBox1.Text, out a1) ||
                       !double.TryParse(textBox2.Text, out a2) ||
                       !double.TryParse(textBox3.Text, out a3) ||
                       !double.TryParse(textBox4.Text, out a4) ||
                       !double.TryParse(textBox5.Text, out b1) ||
                       !double.TryParse(textBox6.Text, out b2) ||
                       !double.TryParse(textBox7.Text, out b3) ||
                       !double.TryParse(textBox8.Text, out b4))
            {
                ClearTextBox();
                MessageBox.Show("You entered incorrect parameters. Try again", "Error occured", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            else
            {
                a1 = Convert.ToDouble(textBox1.Text);
                a2 = Convert.ToDouble(textBox2.Text);
                a3 = Convert.ToDouble(textBox3.Text);
                a4 = Convert.ToDouble(textBox4.Text);
                b1 = Convert.ToDouble(textBox5.Text);
                b2 = Convert.ToDouble(textBox6.Text);
                b3 = Convert.ToDouble(textBox7.Text);
                b4 = Convert.ToDouble(textBox8.Text);

                double[] poly1 = { a1, a2, a3, a4 };
                double[] poly2 = { b1, b2, b3, b4 };
                int n = 4; int m = 4;

                double[] res = Polynomial.multiply(poly1, poly2, n, m);
                textBox9.Text = res[0].ToString();
                textBox10.Text = res[1].ToString();
                textBox11.Text = res[2].ToString();
                textBox12.Text = res[3].ToString();
                textBox13.Text = res[4].ToString();
                textBox14.Text = res[5].ToString();
                textBox15.Text = res[6].ToString();
            }

        }


        private void txt_cleaner(object sender, EventArgs e)
        {
            ClearTextBox();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            SelectedTextBox = sender as TextBox;
        }
    }
}
