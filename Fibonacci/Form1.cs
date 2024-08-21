using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Fibonacci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int current = 1;
        int previous = 0;
        int next;
        int iterationer;

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
            {
                iterationer = 30;
            }
            else
            {
                iterationer = int.Parse(textBox1.Text);
            }
            
            listBox1.Items.Add("0");
            listBox1.Items.Add("1");

            for (int i = 0; i < iterationer; i++)
            {
                next = current + previous;
                previous = current;
                current = next;

                if (current < 0)
                {
                    listBox1.Items.Add((current * -1).ToString());
                }
                else
                {
                    listBox1.Items.Add(current.ToString());
                }
            }
        }
    }
}
