using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_24
{
    public partial class Form1 : Form
    {
        char[] allowed_symbols = new char[] { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', '+', '-', '*', '/' };
        public Form1()
        {
            InitializeComponent();
            this.ActiveControl = this.richTextBox1;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            List<int> indexes = new List<int> { };
            string line = richTextBox1.Text;
            bool to_index = false;
            for (int i = 0; i < line.Length; i++)
            {
                for (int j = 0; j < allowed_symbols.Length; j++)
                {
                    if (line[i] == allowed_symbols[j])
                    {
                        to_index = false;
                        break;
                    }
                    else
                    {
                        to_index = true;
                    }
                }
                if (to_index)
                {
                    indexes.Add(i);
                }
            }
            foreach (int index in indexes)
            {
                Console.WriteLine(index);
                richTextBox1.Text = richTextBox1.Text.Remove(index, 1);
            }
            richTextBox1.SelectionStart = richTextBox1.Text.Length;
        }

        private void result_button_Click(object sender, EventArgs e)
        {
            string expresion = richTextBox1.Text;
            try
            {
                using (var dt = new DataTable())
                {
                    double res = Convert.ToDouble(dt.Compute(expresion, ""));
                    Console.WriteLine(res);
                }
            }
            catch (Exception a)
            {
                Console.WriteLine(a.Message);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
