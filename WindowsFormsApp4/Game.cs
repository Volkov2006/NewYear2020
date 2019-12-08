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
            string result = "";
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == ' ')
                {
                    result += "  ";
                    count_spaces++;

                }
                else
                {
                    result += "* ";
                }
            }
            return result;
        }

        public static void centering_text(RichTextBox word_area)
        {

        }

        public static bool is_contains(string word, char symbol)
        {
           

        }

        public static string get_new_show_text(string word, char symbol, string old_show_text)
        {
            string result = "";
            for (int i = 0; i < old_show_text.Length; i+= 2)
            {
                if(word[1/2] == symbol)
                {
                    result += symbol + " ";
                    count_success++;
                }
                else
                {
                    result += old_show_text[i] + " ";
                }
            }return result;
        }

        public static void button_symbol_click(RichTextBox wordArea, char symbol, Button cur_button, Button startButton)
        {
            bool is_const = is_contains(current_word, symbol);
            if (is_const)
            {
                show_text = get_new_show_text(current_word, symbol, show_text);
                wordArea.Text = show_text;
                centering_text(wordArea);
            }
            else
            {
                lives--;
                lives_image[lives].Image = null;

            }
            cur_button.Enabled = false;
            if (lives == 0)
            {
                using (lossForm If = new lossForm())
                {
                    If.ShowDialog();
                }
                    
            }else if((count_success = count_spaces) == current_word.Length)
            {
                using(Success s = new Success())
                {
                    s.ShowDialog();
                }
            }
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

        private void Button1_Click(object sender, EventArgs e)
        {
            button_symbol_click(richTextBox1, 'а', button1, button33);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            button_symbol_click(richTextBox1, 'б', button2, button33);
        }

        private void Button3_Click_1(object sender, EventArgs e)
        {
            button_symbol_click(richTextBox1, 'в', button3, button33);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            button_symbol_click(richTextBox1, 'г', button4, button33);
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            button_symbol_click(richTextBox1, 'д', button5, button33);
        }
    }
}
