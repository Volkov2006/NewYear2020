using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Game : Form
    {
        static string[] words;
        static string current_word;
        static string show_text;
        static int count_success;
        static int count_spaces;
        static int lives;
        static PictureBox[] lives_image;

        public Game()
        {
            InitializeComponent();
            lives_image = new PictureBox[] { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6 };

            words = new string[] { "карнавал", "праздник", "дед мороз", "сюрприз", "ёлочка" };
            current_word = "";
            show_text = "";
            count_success = 0;
            count_spaces = 0;
            lives = lives_image.Length;
        }

        public static void start_game(RichTextBox wordArea)
        {
            Random random = new Random();
            int index = random.Next(0, words.Length);
        }

        public static void start_game(RichTextBox wordArea, PictureBox[] lives_image)
        {

        }

        public static string get_show_text(string word)
        {
          
        }

        public static void centering_text(RichTextBox word_area)
        {

        }

        public static bool is_contains(string word, char symbol)
        {

        }

        public static string get_new_show_text(string word, char symbol, string old_show_text)
        {

        }

        public static void button_symbol_click(RichTextBox wordArea, char symbol, Button cur_button, Button startButton)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {

        }

        private void Button18_Click(object sender, EventArgs e)
        {

        }

        private void Button28_Click(object sender, EventArgs e)
        {

        }

        private void Button30_Click(object sender, EventArgs e)
        {

        }

        private void Button32_Click(object sender, EventArgs e)
        {

        }

        private void Button26_Click(object sender, EventArgs e)
        {

        }

        private void Button27_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void Button7_Click(object sender, EventArgs e)
        {

        }
    }
}
