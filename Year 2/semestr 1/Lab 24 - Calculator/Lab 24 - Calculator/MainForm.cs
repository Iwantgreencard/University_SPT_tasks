using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Lab_24___Calculator
{

    public partial class MainForm : Form
    {
        char[] allowed_symbols = new char[] { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', '+', '-', '*', '/', '.', 'E' };
        public MainForm()
        {
            InitializeComponent();
            this.ActiveControl = richTextBox1;
        }
        private void action_button(string text_to_append) {
            richTextBox1.Text += text_to_append;
            richTextBox1.SelectionStart = richTextBox1.Text.Length;
            richTextBox1.ScrollToCaret();
        }
        private void result_button_Click(object sender, EventArgs e)
        {
            string expresion = richTextBox1.Text;
            try
            {
                using (var dt = new DataTable())
                {
                    double res = Convert.ToDouble(dt.Compute(expresion, ""));
                    Console.WriteLine(Convert.ToString(res));
                    label1.Text = expresion+" =";
                    richTextBox1.Text = Convert.ToString(res).Replace(',', '.');
                }
            }
            catch (Exception a)
            {
                label1.Text = "Помилка";
            }
            
        }

        private void richTextBox1_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            string line = richTextBox1.Text;
            if (e.KeyCode == Keys.Enter)
            {
                result_button_Click(sender, e);
            }
            else if (e.KeyCode == Keys.Back && line.Length == 0)
            {
                clear_action_button.Hide();
            }
            
        }

        private void input_one_Click(object sender, EventArgs e)
        {
            action_button("1");
        }

        private void input_two_Click(object sender, EventArgs e)
        {
            action_button("2");
        }

        private void input_three_Click(object sender, EventArgs e)
        {
            action_button("3");
        }

        private void input_four_Click(object sender, EventArgs e)
        {
            action_button("4");
        }

        private void input_five_Click(object sender, EventArgs e)
        {
            action_button("5");
        }

        private void input_six_Click(object sender, EventArgs e)
        {
            action_button("6");
        }

        private void input_seven_Click(object sender, EventArgs e)
        {
            action_button("7");
        }

        private void input_eight_Click(object sender, EventArgs e)
        {
            action_button("8");
        }

        private void input_nine_Click(object sender, EventArgs e)
        {
            action_button("9");
        }

        private void input_zero_Click(object sender, EventArgs e)
        {
            action_button("0");
        }

        private void plus_action_button_Click(object sender, EventArgs e)
        {
            action_button("+");
        }

        private void minus_action_button_Click(object sender, EventArgs e)
        {
            action_button("-");
        }

        private void Times_action_button_Click(object sender, EventArgs e)
        {
            action_button("*");
        }

        private void Divide_action_button_Click(object sender, EventArgs e)
        {
            action_button("/");
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            List<int> indexes = new List<int> { };
            string line = richTextBox1.Text;
            if (line.Length > 0)
            {
                clear_action_button.Show();
            }
            else {
                clear_action_button.Hide();
            }
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

        private void clear_action_button_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            clear_action_button.Hide();
            label1.Text = "";
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Shift && e.KeyCode == Keys.T)
            {
                int openedForms = Application.OpenForms.Count;
                if (openedForms > 1)
                {
                    return;
                }
                AuthorBox r = new AuthorBox
                {
                    TopLevel = false,
                    TopMost = true
                };
                this.Controls.Add(r);
                r.BringToFront();
                r.Dock = DockStyle.Fill;
                r.Show();
            }
        }
        
    }
}
