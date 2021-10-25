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
    public partial class MainMenu : Form
    {
        // Це основний файл проекта, саме він виконується при запуску програми і відкриває головне меню гри
        public MainMenu()
        {
            InitializeComponent();

        }

        // Дві змінні, в одній інформація про те, чи є відкритою форма Game, яка являється уже самою грою і друга, за допомогою якої я викликаю форму Game в цьому файлі
        Form gameOpened = Application.OpenForms["Game"];
        Game game = new Game();
        
        // Функція, яка запускається при кліці на кнопку номер 1 "Нажми для початку"
        public void button1_Click(object sender, EventArgs e)
        {
            // перевіряю, чи відкрита форма Game, якщо ні, створю нову
            if(gameOpened == null)
            {
                game = new Game();
            }

            // записую ім'я, що ввів користувач в глобальну змінну name
            Program.name = textBox1.Text;
            // Ховаю елементы формы Main menu та запускаю форму Game
            button1.Hide();
            textBox1.Hide();
            label1.Hide();
            game.TopLevel = false;
            this.Controls.Add(game);
            game.Dock = DockStyle.Fill;
            button2.BackColor = Color.FromArgb(53, 31, 57);
            game.Show();
            game.setName();
        }

        // функція виходу до головного меню, що виводить елементи головного меню
        public void toMainMenu()
        {
            button1.Show();
            textBox1.Show();
            label1.Show();
            button2.BackColor = Color.Transparent;
        }

        // Функція End, що закриває форму Game
        public void End()
        {
            game.Close();
        }

        // Кнопка виходу до головного меню, просто викликає функцію End да toMainMenu
        public void button2_Click(object sender, EventArgs e)
        {
            toMainMenu();
            End();
        }
    }
}
