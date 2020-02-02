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

namespace Calc
{
    public partial class Form1 : Form, ILaunchView
    {
        private readonly ApplicationContext _context;
        public Form1(ApplicationContext context)
        {
            _context = context;
            InitializeComponent();
        }
        public event Delegates.Launch Launch;
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                Launch?.Invoke(this.textBox1.Text);
            }
        }
        public new void Show(string s)
        {
            _context.MainForm = this;
            base.Show();
        }
        public void ShowError(string message)
        {
            MessageBox.Show(message);
        }
    }
}
