using System;
using System.Collections;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace lab3
{
    public partial class Form1 : Form
    {
        //Ініціалізуємо компоненти
        public Form1()
        {
            InitializeComponent();
        }
        double begin, end, iteration_lenght;
        int iteration_number;


        
        private void TextBox_Key_Press(object sender, KeyPressEventArgs e)
        {
            if ((!Char.IsDigit(e.KeyChar)) && !(e.KeyChar.Equals((char)Keys.Back)))
            {
                e.Handled = true;
            }
        }
        private void TextBox_Key_Press_(object sender, KeyPressEventArgs e)
        {
            TextBox t = (TextBox)sender;
            if ((!Char.IsNumber(e.KeyChar)) && !(e.KeyChar.Equals((char)Keys.Back)) && !(e.KeyChar.Equals(',') && !Dots_Contatin(t.Text)) && !(e.KeyChar.Equals('-') && t.Text.Length == 0))
            {
                e.Handled = true;
            }
        }
        //Перевірка для десяткових чисел
        private bool Dots_Contatin(string s)
        {
            foreach (char a in s)
            {
                if (a.Equals(','))
                { return true; }
            }
            return false;
        }
        //Перевірка на коректність введених меж зміни аргументу
        private bool ambit_check()
        {
            if (Double.TryParse(textBox1.Text, out begin) && Double.TryParse(textBox2.Text, out end))
            {
                double x1, x2;
                x1 = double.Parse(textBox1.Text);
                x2 = double.Parse(textBox2.Text);
                if (x1 >= x2)
                { return false; }
            }
            return true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void labelMax_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text))
            {
                button1.Enabled = false;
            }
            else { button1.Enabled = true; }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string[][] row;
            ArrayList rows = new ArrayList();
            this.dataGridView1.Rows.Clear();
            this.chart1.Series.Clear();
            if (Double.TryParse(textBox1.Text, out begin) && Double.TryParse(textBox2.Text, out end) && Int32.TryParse(textBox3.Text, out iteration_number))
            {
                if (!ambit_check())
                { MessageBox.Show("Please, enter correct data!"); return; }
                if (radioButton1.Checked)
                {
                    try
                    {
                        begin = double.Parse(textBox1.Text);
                        end = double.Parse(textBox2.Text);
                        iteration_number = int.Parse(textBox3.Text);
                        iteration_lenght = Math.Abs(begin - end) / iteration_number;
                        row = new string[iteration_number + 1][];
                        for (int i = 0; i <= iteration_number; i++)
                        {
                            row[i] = new string[2];
                        }
                        dataGridView1.ColumnCount = 2;
                        this.chart1.Series.Add("f(x)");
                        this.chart1.Series["f(x)"].ChartType = SeriesChartType.Spline;
                        dataGridView1.Columns[0].Name = "x";
                        dataGridView1.Columns[1].Name = "f(x)";
                        double x = begin;
                        for (int i = 0; i <= iteration_number; i++)
                        {
                            row[i][0] = x.ToString();
                            row[i][1] = (Math.Acos((1 - x * x) / (1 + x * x))).ToString();
                            this.chart1.Series["f(x)"].Points.AddXY(x.ToString(), Double.Parse(row[i][1]));
                            x += iteration_lenght;
                        }
                        double max = double.Parse(row[0][1]);
                        for (int i = 0; i <= iteration_number; i++)
                        {
                            if (double.Parse(row[i][1]) > max)
                            {
                                max = double.Parse(row[i][1]);
                            }
                        }
                        labelMax.Text = labelMax.Text + max.ToString();
                        double min = double.Parse(row[0][1]);
                        for (int i = 0; i <= iteration_number; i++)
                        {
                            if (double.Parse(row[i][1]) < min)
                            {
                                min = double.Parse(row[i][1]);
                            }
                        }
                        labelMin.Text = labelMin.Text + min.ToString();
                        for (int i = 0; i <= iteration_number; i++)
                        {
                            rows.Add(row[i]);
                        }
                        foreach (string[] row1 in rows)
                        {
                            dataGridView1.Rows.Add(row1);

                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show(e.ToString());
                    }
                }
                else if (radioButton2.Checked)
                {
                    try
                    {
                        begin = double.Parse(textBox1.Text);
                        end = double.Parse(textBox2.Text);
                        iteration_number = int.Parse(textBox3.Text);
                        iteration_lenght = Math.Abs(begin - end) / iteration_number;
                        row = new string[iteration_number + 1][];
                        for (int i = 0; i <= iteration_number; i++)
                        {
                            row[i] = new string[5];
                        }
                        dataGridView1.ColumnCount = 5;
                        dataGridView1.Columns[0].Name = "t";
                        dataGridView1.Columns[1].Name = "x(t)";
                        dataGridView1.Columns[2].Name = "y(t)";
                        this.chart1.Series.Add("x(t)");
                        this.chart1.Series.Add("y(t)");
                        this.chart1.Series["x(t)"].ChartType = SeriesChartType.Spline;
                        this.chart1.Series["y(t)"].ChartType = SeriesChartType.Spline;
                        /////////////////////////////////
                        dataGridView1.Columns[3].Name = "x(y)";
                        dataGridView1.Columns[4].Name = "y(x)";
                        this.chart1.Series.Add("x(y)");
                        this.chart1.Series.Add("y(x)");
                        this.chart1.Series["x(y)"].ChartType = SeriesChartType.Spline;
                        this.chart1.Series["y(x)"].ChartType = SeriesChartType.Spline;
                        ////////////////////////////////

                        double x = begin;
                        for (int i = 0; i <= iteration_number; i++)
                        {
                            row[i][0] = x.ToString();
                            row[i][1] = (2 * x - x * x).ToString();
                            row[i][2] = (3 * x - Math.Pow(x, 3)).ToString();
                            this.chart1.Series["x(t)"].Points.AddXY(x.ToString(), Double.Parse(row[i][1]));
                            this.chart1.Series["y(t)"].Points.AddXY(x.ToString(), Double.Parse(row[i][2]));
                            ///////////////////////////////
                            ///x(y(t))
                            row[i][3] = (double.Parse(row[i][2]) * (2 - double.Parse(row[i][2]))).ToString();
                            ///y(x(t))
                            row[i][4] = (double.Parse(row[i][1]) * (3 - double.Parse(row[i][1]) * double.Parse(row[i][1]))).ToString();
                            this.chart1.Series["x(y)"].Points.AddXY(x.ToString(), Double.Parse(row[i][3]));
                            this.chart1.Series["y(x)"].Points.AddXY(x.ToString(), Double.Parse(row[i][4]));
                            //////////////////////////////
                            x += iteration_lenght;
                        }
                        double maxX = double.Parse(row[0][1]);
                        for (int i = 0; i <= iteration_number; i++)
                        {
                            if (double.Parse(row[i][1]) > maxX)
                            {
                                maxX = double.Parse(row[i][1]);
                            }
                        }
                        labelMax.Text = "Func x(t) max:" + maxX.ToString();
                        double minX = double.Parse(row[0][1]);
                        for (int i = 0; i <= iteration_number; i++)
                        {
                            if (double.Parse(row[i][1]) < minX)
                            {
                                minX = double.Parse(row[i][1]);
                            }
                        }
                        labelMin.Text = "Func x(t) min: " + minX.ToString();
                        double maxY = double.Parse(row[0][2]);
                        for (int i = 0; i <= iteration_number; i++)
                        {
                            if (double.Parse(row[i][2]) > maxY)
                            {
                                maxY = double.Parse(row[i][2]);
                            }
                        }
                        labelMax.Text = labelMax.Text + ", func y(t) max: " + maxY.ToString();
                        double minY = double.Parse(row[0][2]);
                        for (int i = 0; i <= iteration_number; i++)
                        {
                            if (double.Parse(row[i][2]) < minY)
                            {
                                minY = double.Parse(row[i][2]);
                            }
                        }
                        labelMin.Text = labelMin.Text + " , func y(t) min: " + minY.ToString();
                        for (int i = 0; i <= iteration_number; i++)
                        {
                            rows.Add(row[i]);
                        }
                        foreach (string[] row1 in rows)
                        {
                            dataGridView1.Rows.Add(row1);

                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show(e.ToString());
                    }
                }
            }
        }
    }
}
