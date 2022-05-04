using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] Mas = new int[20];
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Random rand = new Random();
            for (int i = 0; i < 20; i++)
            {
                Mas[i] = rand.Next() / 1000000;
                listBox1.Items.Add("Mas[" + i.ToString() + "] = " + Mas[i].ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            int Max = 0;
            for (int i = 1; i < 20; i++)
            {
                if (Mas[Max] < Mas[i])
                    Max = i;
            }
            int temp = Mas[Max];
            Mas[Max] = Mas[0];
            Mas[0] = temp;
            for (int i = 0; i < 20; i++)
            {
                listBox2.Items.Add("Mas[" + Convert.ToString(i) + "] = " + Mas[i].ToString());

            }
        }
    }
}

