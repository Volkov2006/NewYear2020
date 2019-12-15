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

            words = new string[] { "карнавал", "праздник", "дед мороз", "сюрприз", "елочка" };
            current_word = "";
            show_text = "";
            count_success = 0;
            count_spaces = 0;
            lives = lives_image.Length;

            start_game(richTextBox1, lives_image);
        }

        public static void start_game(RichTextBox wordArea)
        {
            Random random = new Random();
            int words_array_length = words.Length;
            int index_word = random.Next(0, words_array_length);
            current_word = words[index_word];
            count_success = 0;
            count_spaces = 0;
            show_text = get_show_text(current_word);
            wordArea.Text = show_text;
            centering_text(wordArea);
            lives = lives_image.Length;
   
        }

        public static void start_game(RichTextBox wordArea, PictureBox[] lives_image)
        {
            start_game(wordArea);
            var bmp = new Bitmap(Properties.Resources.live);
            for (int i = 0; i < lives_image.Length; i++)
            {
                lives_image[i].SizeMode = PictureBoxSizeMode.Zoom;
                lives_image[i].Image = bmp;
            }
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
            for (int i = 0; i < word.Length; i++) 
            {
                if (word[i] == symbol)
                {
                    return true;
                }
                    

            }
            return false;
        }

        public static string get_new_show_text(string word, char symbol, string old_show_text)
        {
            string result = "";
            for (int i = 0; i < old_show_text.Length; i+= 2)
            {
                if(word[i/2] == symbol)
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
                    
            }else if((count_success + count_spaces) == current_word.Length)
            {
                using(Success s = new Success())
                {
                    s.ShowDialog();
                }
                startButton.PerformClick();
            }
        } 



        private void Button3_Click(object sender, EventArgs e)
        {

        }

        private void Button18_Click(object sender, EventArgs e)
        {
            button_symbol_click(richTextBox1, 'с', button18, button33);
        }

        private void Button28_Click(object sender, EventArgs e)
        {
            button_symbol_click(richTextBox1, 'ы', button28, button33);
        }

        private void Button30_Click(object sender, EventArgs e)
        {
            button_symbol_click(richTextBox1, 'э', button30, button33);
        }

        private void Button32_Click(object sender, EventArgs e)
        {
            button_symbol_click(richTextBox1, 'я', button32, button33);
        }

        private void Button26_Click(object sender, EventArgs e)
        {
            button_symbol_click(richTextBox1, 'щ', button26, button33);
        }
        

        private void Button27_Click(object sender, EventArgs e)
        {
            button_symbol_click(richTextBox1, 'ъ', button27, button33);
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
            button_symbol_click(richTextBox1, 'ж', button7, button33);
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

        private void Button6_Click(object sender, EventArgs e)
        {
            button_symbol_click(richTextBox1, 'е', button6, button33);
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            button_symbol_click(richTextBox1, 'з', button8, button33);
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            button_symbol_click(richTextBox1, 'и', button9, button33);
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            button_symbol_click(richTextBox1, 'й', button10, button33);
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            button_symbol_click(richTextBox1, 'к', button11, button33);
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            button_symbol_click(richTextBox1, 'л', button12, button33);
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            button_symbol_click(richTextBox1, 'м', button13, button33);
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            button_symbol_click(richTextBox1, 'н', button14, button33);
        }

        private void Button15_Click(object sender, EventArgs e)
        {
            button_symbol_click(richTextBox1, 'о', button15, button33);
        }

        private void Button16_Click(object sender, EventArgs e)
        {
            button_symbol_click(richTextBox1, 'п', button16, button33);
        }

        private void Button17_Click(object sender, EventArgs e)
        {
            button_symbol_click(richTextBox1, 'р', button17, button33);
        }

        private void Button19_Click(object sender, EventArgs e)
        {
            button_symbol_click(richTextBox1, 'т', button19, button33);
        }

        private void Button20_Click(object sender, EventArgs e)
        {
            button_symbol_click(richTextBox1, 'у', button20, button33);
        }

        private void Button21_Click(object sender, EventArgs e)
        {
            button_symbol_click(richTextBox1, 'ф', button21, button33);
        }

        private void Game_Load(object sender, EventArgs e)
        {

        }

        private void Button22_Click(object sender, EventArgs e)
        {
            button_symbol_click(richTextBox1, 'х', button22, button33);
        }

        private void Button23_Click(object sender, EventArgs e)
        {
            button_symbol_click(richTextBox1, 'ц', button23, button33);
        }

        private void Button24_Click(object sender, EventArgs e)
        {
            button_symbol_click(richTextBox1, 'ч', button24, button33);
        }

        private void Button25_Click(object sender, EventArgs e)
        {
            button_symbol_click(richTextBox1, 'ш', button25, button33);
        }

        private void Button29_Click(object sender, EventArgs e)
        {
            button_symbol_click(richTextBox1, 'ь', button29, button33);
        }

        private void Button31_Click(object sender, EventArgs e)
        {
            button_symbol_click(richTextBox1, 'ю', button31, button33);
        }

        private void Button33_Click(object sender, EventArgs e)
        {
            start_game(richTextBox1, lives_image);

            Button[] buttons = new Button[] { button1, button2, button3, button4, button5,
            button6, button7, button8, button9, button10, button11, button12, button13, button14,
            button15, button16, button17, button18, button19, button20, button21, button22, button23,
            button24, button25, button26, button27, button28, button29, button30, button31, button32};

            for (int i = 0; i < buttons.Length; i++)
            {
                buttons[i].Enabled = true;
            }

               
        }
    }
}
