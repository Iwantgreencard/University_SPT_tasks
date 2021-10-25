using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rock_Paper_and_Scissors
{
    public partial class Game : Form
    {

        // Ініціюю змінні: rps - числова змінна, куди я записую значення від 1 до 3, щоб визначити що вибрав користувач, ножниці, камінь чи папір
        // computer_rps - те ж саме, що rps але для запису вибора комп'ютераю. counter - для запису перемог, програшів та нічиїх
        int rps;
        int computer_rps;
        int counter_wins;
        int counter_falls;
        int counter_noone;

        public Game()
        {
            InitializeComponent();
        }

        // Три функції, які записують вибір гравця в змінну rps та викликають функцію Choise
        private void paper_Click(object sender, EventArgs e)
        {
            rps = 2;
            Choise(scissors, rock, paper);
        }

        private void rock_Click(object sender, EventArgs e)
        {
            rps = 1;
            Choise(scissors, paper, rock);
        }

        private void scissors_Click(object sender, EventArgs e)
        {
            rps = 3;
            Choise(rock, paper, scissors);
        }

        // Функція що спрацьовує при натиску на кнопку "грати"
        private void button1_Click(object sender, EventArgs e)
        {
            // Рандомно визначаю вибір комп'ютера
            Random rand = new Random();
            computer_rps = (rand.Next(3) + 1);
            // Перевіряю, чи зробив вибір гравець 
            if (rps > 0)
            {
                // Текствово вивожу вибір комп'ютера
                switch (computer_rps)
                {
                    case 1:
                        bot_choice.Image = Properties.Resources.icons8_hand_rock_100;
                        label2.Text = "Камінь!!!";
                        break;
                    case 2:
                        bot_choice.Image = Properties.Resources.icons8_hand_100;
                        label2.Text = "Папір!!!";
                        break;
                    case 3:
                        bot_choice.Image = Properties.Resources.icons8_hand_scissors_100;
                        label2.Text = "Ножиці!!!";
                        break;
                }

                bot_choice.Image.RotateFlip(RotateFlipType.Rotate180FlipY);

                // Відразу перевіряю нічію
                if (computer_rps == rps)
                {
                    MessageBox.Show("Нічія: ");
                    counter_noone++;
                }

                // Якщо не нічія, то перевіряю можливі комбінації
                else
                {
                    switch (rps)
                    {
                        case 1:
                            if (computer_rps == 3)
                            {
                                MessageBox.Show("Виграш");
                                counter_wins++;
                            }
                            else
                            {
                                MessageBox.Show("Програш");
                                counter_falls++;
                            }
                            break;
                        case 2:
                            if (computer_rps == 1)
                            {
                                MessageBox.Show("Виграш");
                                counter_wins++;
                            }
                            else
                            {
                                MessageBox.Show("Програш");
                                counter_falls++;
                            }
                            break;
                        case 3:
                            if (computer_rps == 2)
                            {
                                MessageBox.Show("Виграш");
                                counter_wins++;
                            }
                            else
                            {
                                MessageBox.Show("Програш");
                                counter_falls++;
                            }
                            break;
                    }
                }

                // Вивожу обновлену інформацію на екран та кнопку "знову", щоб гравець міг почати нову партію
                button1.Enabled = false;
                button2.Show();
                WinsLabel.Text = "Перемоги: " + counter_wins.ToString();
                FallsLabel.Text = "Програші: " + counter_falls.ToString();
                NoOneLabel.Text = "Нічії: " + counter_noone.ToString();
            }
            // Якщо гравець не зробив вибір прошу його це зробити
            else
            {
                MessageBox.Show("Зробіть ваш вибір натиснувши на картинку зліва");
            }
        }

        // Функція, центрує картинку з вибором гравця, та ховає інші
        public void Choise(PictureBox hide, PictureBox hide2, PictureBox to_visible)
        {
            hide.Visible = false;
            hide2.Visible = false;
            flowLayoutPanel1.Size = new Size(flowLayoutPanel1.Width, to_visible.Size.Height);
            flowLayoutPanel1.Location = new Point(flowLayoutPanel1.Location.X, bot_choice.Location.Y);
        }

        // Функція, що спрацьовує при натиску на кнопку "знову", збиває значення "вибору" на нуль, виводіть картинки для вибору
        private void button2_Click(object sender, EventArgs e)
        {
            rps = 0;
            computer_rps = 0;
            paper.Show();
            rock.Show();
            scissors.Show();
            button1.Enabled = true;
            bot_choice.Image = Properties.Resources.icons8_concerned_face_100;
            label2.Text = "Робот думає...";
            button2.Hide();
            flowLayoutPanel1.Size = new Size(flowLayoutPanel1.Width, (127*3));
            flowLayoutPanel1.Location = new Point(flowLayoutPanel1.Location.X, 60);
        }

        // Функція що записує ім'я гравця, беручи його з форми MainMenu
        public void setName()
        {
            MainMenu menu = new MainMenu();
            NameLabel.Text += Program.name;
            menu.button1.BackColor = Color.FromArgb(53, 31, 57);
        }
    }
}
