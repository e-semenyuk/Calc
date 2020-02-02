using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Presentation;
using Model;

namespace Calc
{
    public partial class Form2 : Form, ICalcView
    {
        private readonly ApplicationContext _context;
        public event Delegates.Calculate Calculate;
        public event Delegates.GetValues GetValues;
        public event Delegates.GetInitialValues GetInitialValues;

        double[] values;
        string initValues;
        public Form2( ApplicationContext context)
        {
            _context = context;
            InitializeComponent();
            string data = GetInitialValues?.Invoke();

            values = initValues.Split(' ').Select(Double.Parse).ToArray();

            label1.Text = string.Join("; ", values);
            listBox1.Items.Add(label1.Text);
        }

/*        class Factorial
        {
            public double display(double n)
            {
                double res = 1;
                while (n != 1)
                {
                    res = res * n;
                    n = n - 1;
                }
                return res;
            }
        }*/

        public void button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            //CalcService cs = new CalcService();
            //CalcPresenter cp = new CalcPresenter(this, cs);
            //cp.Calculate(values, Convert.ToDouble(textBox1.Text), button.Text);

            Calculate?.Invoke(values, Convert.ToDouble(textBox1.Text), button.Text);

            //cs.StringValues = "123";
            string x = GetValues?.Invoke();
            //string x = cp.GetValues();
            listBox1.Items.Add(x);

            #region
            /*                switch (button.Text)
                            {
                                case "Прибавить":

                                    for (int i = 0; i < values.Length; i++)
                                    {
                                        values[i] = values[i] + Convert.ToDouble(textBox1.Text);
                                        label1.Text = string.Join("; ", values);
                                    }
                                    listBox1.Items.Add(label1.Text);
                                    s(button.Text);
                                    break;

                                case "Отнять":

                                    for (int i = 0; i < values.Length; i++)
                                    {
                                        values[i] = values[i] - Convert.ToDouble(textBox1.Text);
                                        label1.Text = string.Join("; ", values);
                                    }
                                    listBox1.Items.Add(label1.Text);
                                    break;

                                case "Умножить":

                                    for (int i = 0; i < values.Length; i++)
                                    {
                                        values[i] = values[i] * Convert.ToDouble(textBox1.Text);
                                        label1.Text = string.Join("; ", values);
                                    }
                                    listBox1.Items.Add(label1.Text);
                                    break;

                                case "Разделить":
                                    if (textBox1.Text == "0")
                                        MessageBox.Show("Деление на 0", "Ошибка");
                                    else
                                    {
                                        for (int i = 0; i < values.Length; i++)
                                        {
                                            values[i] = values[i] / Convert.ToDouble(textBox1.Text);
                                            label1.Text = string.Join("; ", values);
                                        }
                                        listBox1.Items.Add(label1.Text);
                                    }
                                    break;

                                case "Возвести в квадрат":

                                    for (int i = 0; i < values.Length; i++)
                                    {
                                        values[i] = Math.Pow(values[i], 2);
                                        label1.Text = string.Join("; ", values);
                                    }
                                    listBox1.Items.Add(label1.Text);
                                    break;

                                case "Возвести в степень":
                                    if (Convert.ToDouble(textBox1.Text) % 1 != 0)
                                        MessageBox.Show("Степень не целое число", "Ошибка");
                                    else
                                    {
                                        for (int i = 0; i < values.Length; i++)
                                        {
                                            values[i] = Math.Pow(values[i], Convert.ToDouble(textBox1.Text));
                                            label1.Text = string.Join("; ", values);
                                        }
                                        listBox1.Items.Add(label1.Text);
                                    }
                                    break;

                                case "Квадратный корень":
                                    for (int i = 0; i < values.Length; i++)
                                    {
                                        if (values[i] < 0)
                                            MessageBox.Show("Под корнем отрицательное число", "Ошибка");
                                        else
                                        {
                                            values[i] = Math.Sqrt(values[i]);
                                            label1.Text = string.Join("; ", values);
                                        }
                                    }
                                    listBox1.Items.Add(label1.Text);
                                    break;

                                case "Корень заданной степени":
                                    if (Convert.ToDouble(textBox1.Text) % 1 != 0)
                                        MessageBox.Show("Степень не целое число", "Ошибка");
                                    else
                                    {
                                        for (int i = 0; i < values.Length; i++)
                                        {
                                            if (values[i] < 0)
                                                MessageBox.Show("Под корнем отрицательное число", "Ошибка");
                                            else
                                            {
                                                values[i] = Math.Pow(values[i], 1.0 / Convert.ToDouble(textBox1.Text));
                                                label1.Text = string.Join("; ", values);
                                            }
                                        }
                                        listBox1.Items.Add(label1.Text);
                                    }
                                    break;
                                case "Логарифм по заданному основанию":

                                    for (int i = 0; i < values.Length; i++)
                                    {
                                        if (Convert.ToDouble(textBox1.Text) < 0 | values[i] < 0)
                                            MessageBox.Show("Логарифм отрицательного числа", "Ошибка");
                                        else
                                        {
                                            values[i] = Math.Log(values[i]) / Math.Log(Convert.ToDouble(textBox1.Text));
                                            label1.Text = string.Join("; ", values);
                                        }
                                    }
                                    listBox1.Items.Add(label1.Text);
                                    break;
                                case "Факториал":

                                    for (int i = 0; i < values.Length; i++)
                                    {
                                        if (Convert.ToDouble(values[i]) % 1 != 0)
                                        {
                                            MessageBox.Show("Факториал не целого числа", "Ошибка");
                                            break;
                                        }
                                        else
                                        {
                                            Factorial fact = new Factorial();
                                            values[i] = fact.display(values[i]);
                                            label1.Text = string.Join("; ", values);
                                        }
                                        listBox1.Items.Add(label1.Text);
                                    }
                                    break;

                                case "Медиана":

                                    Array.Sort(values);
                                    if (values.Length % 2 == 0)
                                    {
                                        double med = (values[values.Length / 2] + values[values.Length / 2 - 1]) / 2;
                                        Array.Resize(ref values, 1);
                                        values[0] = med;
                                    }
                                    else
                                    {
                                        double med = values[values.Length / 2];
                                        Array.Resize(ref values, 1);
                                        values[0] = med;
                                    }
                                    label1.Text = string.Join("; ", values);
                                    listBox1.Items.Add(label1.Text);

                                    break;

                                case "Стандартное отклонение":

                                    double av = 0;
                                    double t = 0;
                                    foreach (double i in values)
                                        av += i;
                                    av = av / values.Length;
                                    foreach (double i in values)
                                        t += Math.Pow(i - av, 2);
                                    t = t / values.Length;
                                    Array.Resize(ref values, 1);
                                    values[0] = Math.Sqrt(t);

                                    label1.Text = string.Join("; ", values);
                                    listBox1.Items.Add(label1.Text);

                                    break;
                                default:
                                    break;
                            }*/
            #endregion
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string k = listBox1.SelectedItem.ToString();
                values = k.Split(';').Select(Double.Parse).ToArray();
                for(int i = listBox1.SelectedIndex + 1; i < listBox1.Items.Count;)
                    listBox1.Items.RemoveAt(i);
                label1.Text = string.Join("; ", values);
            }
        }

        public void ShowError(string message)
        {
            MessageBox.Show(message);
        }
        public new void Show(string s)
        {
            initValues = s;
            _context.MainForm = this;
            base.Show();
        }
    }
}
