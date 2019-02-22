using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TikTokGame
{
    public partial class FormTikToc : Form
    {
        private int whoMove = 1;
        private int[] moved = new int[9];
        public FormTikToc()
        {
            InitializeComponent();
        }

        private void WhoWin()
        {
            for (int i = 0; i < 7; i++)
            {
                if (i == 0)
                {
                    if (moved[i] == 1 && moved[i + 1] == 1 && moved[i + 2] == 1)
                    {
                        MessageBox.Show("Победили крестики", "Поздравляем");
                        label3.Text = (int.Parse(label3.Text) + 1).ToString();
                        Reset();
                    }

                    if (moved[i] == 1 && moved[i + 3] == 1 && moved[i + 6] == 1)
                    {
                        MessageBox.Show("Победили крестики", "Поздравляем");
                        label3.Text = (int.Parse(label3.Text) + 1).ToString();
                        Reset();
                    }

                    if (moved[i] == 1 && moved[i + 4] == 1 && moved[i + 8] == 1)
                    {
                        MessageBox.Show("Победили крестики", "Поздравляем");
                        label3.Text = (int.Parse(label3.Text) + 1).ToString();
                        Reset();
                    }
                }
                if (i == 1)
                {
                    if (moved[i] == 1 && moved[i + 3] == 1 && moved[i + 6] == 1)
                    {
                        MessageBox.Show("Победили крестики", "Поздравляем");
                        label3.Text = (int.Parse(label3.Text) + 1).ToString();
                        Reset();
                    }
                }
                if (i == 2)
                {
                    if (moved[i] == 1 && moved[i + 3] == 1 && moved[i + 6] == 1)
                    {
                        MessageBox.Show("Победили крестики", "Поздравляем");
                        label3.Text = (int.Parse(label3.Text) + 1).ToString();
                        Reset();
                    }

                    if (moved[i] == 1 && moved[i + 2] == 1 && moved[i + 4] == 1)
                    {
                        MessageBox.Show("Победили крестики", "Поздравляем");
                        label3.Text = (int.Parse(label3.Text) + 1).ToString();
                        Reset();
                    }
                }
                if (i == 3)
                {
                    if (moved[i] == 1 && moved[i + 1] == 1 && moved[i + 2] == 1)
                    {
                        MessageBox.Show("Победили крестики", "Поздравляем");
                        label3.Text = (int.Parse(label3.Text) + 1).ToString();
                        Reset();
                    }
                }
                if (i == 6)
                {
                    if (moved[i] == 1 && moved[i + 1] == 1 && moved[i + 2] == 1)
                    {
                        MessageBox.Show("Победили крестики", "Поздравляем");
                        label3.Text = (int.Parse(label3.Text) + 1).ToString();
                        Reset();
                    }
                }
            }

            for (int i = 0; i < 7; i++)
            {
                if (i == 0)
                {
                    if (moved[i] == 2 && moved[i + 1] == 2 && moved[i + 2] == 2)
                    {
                        MessageBox.Show("Победили нолики", "Поздравляем");
                        label4.Text = (int.Parse(label3.Text) + 1).ToString();
                        Reset();
                    }

                    if (moved[i] == 2 && moved[i + 3] == 2 && moved[i + 6] == 2)
                    {
                        MessageBox.Show("Победили нолики", "Поздравляем");
                        label4.Text = (int.Parse(label3.Text) + 1).ToString();
                        Reset();
                    }

                    if (moved[i] == 2 && moved[i + 4] == 2 && moved[i + 8] == 2)
                    {
                        MessageBox.Show("Победили нолики", "Поздравляем");
                        label4.Text = (int.Parse(label3.Text) + 1).ToString();
                        Reset();
                    }
                }
                if (i == 1)
                {
                    if (moved[i] == 2 && moved[i + 3] == 2 && moved[i + 6] == 2)
                    {
                        MessageBox.Show("Победили нолики", "Поздравляем");
                        label4.Text = (int.Parse(label3.Text) + 1).ToString();
                        Reset();
                    }
                }
                if (i == 2)
                {
                    if (moved[i] == 2 && moved[i + 3] == 2 && moved[i + 6] == 2)
                    {
                        MessageBox.Show("Победили нолики", "Поздравляем");
                        label4.Text = (int.Parse(label3.Text) + 1).ToString();
                        Reset();
                    }

                    if (moved[i] == 2 && moved[i + 2] == 2 && moved[i + 4] == 2)
                    {
                        MessageBox.Show("Победили нолики", "Поздравляем");
                        label4.Text = (int.Parse(label3.Text) + 1).ToString();
                        Reset();
                    }
                }
                if (i == 3)
                {
                    if (moved[i] == 2 && moved[i + 1] == 2 && moved[i + 2] == 2)
                    {
                        MessageBox.Show("Победили нолики", "Поздравляем");
                        label4.Text = (int.Parse(label3.Text) + 1).ToString();
                        Reset();
                    }
                }
                if (i == 6)
                {
                    if (moved[i] == 2 && moved[i + 1] == 2 && moved[i + 2] == 2)
                    {
                        MessageBox.Show("Победили нолики", "Поздравляем");
                        label4.Text = (int.Parse(label3.Text) + 1).ToString();
                        Reset();
                    }
                }
            }
            int count = 0;
            for (int i = 0; i < 9; i++)
            {
                if (moved[i] != 0) count++;
            }
            if (count == 9)
            {
                MessageBox.Show("        Ничья");
                Reset();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (button9.Text == "")
            {
                if (whoMove == 1)
                {
                    button9.Text = "X";
                    moved[8] = 1;
                }
                else
                {
                    button9.Text = "O";
                    moved[8] = 2;
                }
                changeMovedPlayer();
                WhoWin();
            }
            else
            {
                MessageBox.Show("Поле занято", "Ошибка Хода");
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (button1.Text == "")
            {
                if (whoMove == 1)
                {
                    button1.Text = "X";
                    moved[0] = 1;
                }
                else
                {
                    button1.Text = "O";
                    moved[0] = 2;
                }
                changeMovedPlayer();
                WhoWin();
            }
            else
            {
                MessageBox.Show("Поле занято", "Ошибка Хода");
            }
        }

        private void changeMovedPlayer()
        {
            whoMove = -whoMove;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.Text == "")
            {
                if (whoMove == 1)
                {
                    button4.Text = "X";
                    moved[3] = 1;
                }
                else
                {
                    button4.Text = "O";
                    moved[3] = 2;
                }
                changeMovedPlayer();
                WhoWin();
            }
            else
            {
                MessageBox.Show("Поле занято", "Ошибка Хода");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (button7.Text == "")
            {
                if (whoMove == 1)
                {
                    button7.Text = "X";
                    moved[6] = 1;
                }
                else
                {
                    button7.Text = "O";
                    moved[6] = 2;
                }
                changeMovedPlayer();
                WhoWin();
            }
            else
            {
                MessageBox.Show("Поле занято", "Ошибка Хода");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == "")
            {
                if (whoMove == 1)
                {
                    button2.Text = "X";
                    moved[1] = 1;
                }
                else
                {
                    button2.Text = "O";
                    moved[1] = 2;
                }
                changeMovedPlayer();
                WhoWin();
            }
            else
            {
                MessageBox.Show("Поле занято", "Ошибка Хода");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text == "")
            {
                if (whoMove == 1)
                {
                    button3.Text = "X";
                    moved[2] = 1;
                }
                else
                {
                    button3.Text = "O";
                    moved[2] = 2;
                }
                changeMovedPlayer();
                WhoWin();
            }
            else
            {
                MessageBox.Show("Поле занято", "Ошибка Хода");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (button6.Text == "")
            {
                if (whoMove == 1)
                {
                    button6.Text = "X";
                    moved[5] = 1;
                }
                else
                {
                    button6.Text = "O";
                    moved[5] = 2;
                }
                changeMovedPlayer();
                WhoWin();
            }
            else
            {
                MessageBox.Show("Поле занято", "Ошибка Хода");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (button8.Text == "")
            {
                if (whoMove == 1)
                {
                    button8.Text = "X";
                    moved[7] = 1;
                }

                else
                {
                    button8.Text = "O";
                    moved[7] = 2;
                }
                changeMovedPlayer();
                WhoWin();
            }
            else
            {
                MessageBox.Show("Поле занято", "Ошибка Хода");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button5.Text == "")
            {
                if (whoMove == 1)
                {
                    button5.Text = "X";
                    moved[4] = 1;
                }
                else
                {
                    button5.Text = "O";
                    moved[4] = 2;
                }
                changeMovedPlayer();
                WhoWin();
            }
            else
            {
                MessageBox.Show("Поле занято", "Ошибка Хода");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        private void начатьИгруToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label3.Text = "0";
            label4.Text = "0";
            Reset();
        }

        private void Reset()
        {
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            whoMove = 1;
            for (int i = 0; i < 9; i++)
            {
                moved[i] = 0;
            }
        }

        private void сбросToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
