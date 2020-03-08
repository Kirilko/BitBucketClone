using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labEvent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button2.Click += Button2_Click;
            button3.Click += delegate
            {
                MessageBox.Show("Способ3");
            };
            button4.Click += (sender, e) => MessageBox.Show("Способ4");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Способ2");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Способ1");
        }
    }
}
