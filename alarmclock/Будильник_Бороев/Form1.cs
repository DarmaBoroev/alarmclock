using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Будильник_Бороев
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string music, music1, music2, music3, music4;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

            OpenFileDialog open = new OpenFileDialog();
            open.Filter = String.Empty;
            open.Filter = "Музыкальные файлы|*.mp3; *.mp2; *.wma; *.wav; *.ogg; *.ogm; *.au; *.aif;";
            if (open.ShowDialog() == DialogResult.OK)
            {
                music = open.FileName;
                textBox2.Text = open.SafeFileName;
                

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
            timer2.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.Hour.ToString("00") + ":" + DateTime.Now.Minute.ToString("00") + ":" + DateTime.Now.Second.ToString("00");
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (label1.Text == label2.Text)
            {
                if (label3.Text == "______________")
                {
                    label3.Text = "";
                }
                axWindowsMediaPlayer1.URL = music1;
                DialogResult result = MessageBox.Show(label3.Text, "Будильник", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (result == DialogResult.OK)
                {
                    axWindowsMediaPlayer1.Ctlcontrols.stop();
                    if (label3.Text == "")
                    {
                        label3.Text = "______________";
                    }
                }
            }
            
            if (label1.Text == label4.Text)
            {
                if (label5.Text == "______________")
                {
                    label5.Text = "";
                }
                
                axWindowsMediaPlayer1.URL = music2;
                DialogResult result = MessageBox.Show(label5.Text, "Будильник", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (result == DialogResult.OK)
                {
                    axWindowsMediaPlayer1.Ctlcontrols.stop();
                    if (label5.Text == "")
                    {
                        label5.Text = "______________";
                    }
                }
            }
            if (label1.Text == label6.Text)
            {
                if (label7.Text == "______________")
                {
                    label7.Text = "";
                }
                
                axWindowsMediaPlayer1.URL = music3;
                DialogResult result = MessageBox.Show(label7.Text, "Будильник", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (result == DialogResult.OK)
                {
                    axWindowsMediaPlayer1.Ctlcontrols.stop();
                    if (label7.Text == "")
                    {
                        label7.Text = "______________";
                    }
 
                }
            }
            if (label1.Text == label8.Text)
            {
                if (label9.Text == "______________")
                {
                    label9.Text = "";
                }
                axWindowsMediaPlayer1.URL = music4;
                DialogResult result = MessageBox.Show(label9.Text, "Будильник", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (result == DialogResult.OK)
                {
                    axWindowsMediaPlayer1.Ctlcontrols.stop();
                    if (label9.Text == "")
                    {
                        label9.Text = "______________";
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //13242423423423423424242343242
                if ((label2.Text != "") && (label2.Text != "________"))
                {
                    string a = label2.Text;
                    DialogResult error = MessageBox.Show("В данный момент в будильник уже записано время. Вы уверены, что хотите перезаписать его?", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (error == DialogResult.Yes)
                    {
                        music1 = music;
                        label23.Text = textBox2.Text;
                        label3.Text = textBox1.Text;
                        label2.Text = numericUpDown_My1.Text + ":" + numericUpDown_My2.Text + ":" + numericUpDown_My3.Text;
                    }
                    else return;
                }
         
                string f = textBox1.Text;
                music1 = music;
                label23.Text = textBox2.Text;
                label3.Text = f;
                label2.Text = numericUpDown_My1.Text + ":" + numericUpDown_My2.Text + ":" + numericUpDown_My3.Text;
                timer2.Start();

                if (textBox1.Text == "")
                {
                    label3.Text = "______________";
                }
      
                if (((label2.Text == label4.Text) || (label2.Text == label6.Text) || (label2.Text == label8.Text) || (numericUpDown_My1.Text == "") || (numericUpDown_My2.Text == "") || (numericUpDown_My3.Text == "")) == false)
                {

                    if (textBox2.Text == "")
                    {
                        label23.Text = "___________";
                        DialogResult error = MessageBox.Show("Вы не выбрали мелодию для данного будильника! Выбрать мелодию?", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (error == DialogResult.Yes)
                        {
                            OpenFileDialog open = new OpenFileDialog();
                            open.Filter = String.Empty;
                            open.Filter = "Музыкальные файлы|*.mp3; *.mp2; *.wma; *.wav; *.ogg; *.ogm; *.au; *.aif;";
                            if (open.ShowDialog() == DialogResult.OK)
                            {
                                music1 = open.FileName;
                                label23.Text = open.SafeFileName;
                            }
                        }
                        else label23.Text = "___________";

                    }

                }

                if ((label2.Text == label4.Text) || (label2.Text == label6.Text) || (label2.Text == label8.Text))
                {
                    label2.Text = "________";
                    label3.Text = "______________";
                    label23.Text = "___________";
                    DialogResult error = MessageBox.Show("Вы уже ранее вводили данное время! Повторите попытку! ", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if ((numericUpDown_My1.Text == "") || (numericUpDown_My2.Text == "") || (numericUpDown_My3.Text == ""))
                {

                    label2.Text = "________";
                    label3.Text = "______________";
                    label23.Text = "___________";
                    DialogResult error = MessageBox.Show("Попытка ввести некорректные данные! Повторите попытку!  (Поля ввода часов, минут или секунд не могут быть пустыми)", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    numericUpDown_My1.Text = "00";
                    numericUpDown_My2.Text = "00";
                    numericUpDown_My3.Text = "00";
                    return;

                }
            
            textBox2.Text = "";
            textBox1.Text = "";
            numericUpDown_My1.Value = 0;
            numericUpDown_My2.Value = 0;
            numericUpDown_My3.Value = 0;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((label4.Text != "") && (label4.Text != "________"))
            {
                DialogResult error = MessageBox.Show("В данный будильник уже записано время. Вы уверены, что хотите перезаписать его?", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (error == DialogResult.Yes)
                {
                    music2 = music;
                    label24.Text = textBox2.Text;
                    label5.Text = textBox1.Text;
                    label4.Text = numericUpDown_My1.Text + ":" + numericUpDown_My2.Text + ":" + numericUpDown_My3.Text;
                }
                else return;
            }

            string f = textBox1.Text;
            music2 = music;
            label24.Text = textBox2.Text;
            label5.Text = f;
            label4.Text = numericUpDown_My1.Text + ":" + numericUpDown_My2.Text + ":" + numericUpDown_My3.Text;
            timer2.Start();

            if (textBox1.Text == "")
            {
                label5.Text = "______________";
            }

            if (((label4.Text == label2.Text) || (label4.Text == label6.Text) || (label4.Text == label8.Text) || (numericUpDown_My1.Text == "") || (numericUpDown_My2.Text == "") || (numericUpDown_My3.Text == "")) == false)
            {
                if (textBox2.Text == "")
                {
                    label24.Text = "__________";
                    DialogResult error = MessageBox.Show("Вы не выбрали мелодию для данного будильника! Выбрать мелодию?", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (error == DialogResult.Yes)
                    {
                        OpenFileDialog open = new OpenFileDialog();
                        open.Filter = String.Empty;
                        open.Filter = "Музыкальные файлы|*.mp3; *.mp2; *.wma; *.wav; *.ogg; *.ogm; *.au; *.aif;";
                        if (open.ShowDialog() == DialogResult.OK)
                        {
                            music2 = open.FileName;
                            label24.Text = open.SafeFileName;
                        }
                    }
                    else label24.Text = "___________";

                }
            }

            if ((label4.Text == label2.Text) || (label4.Text == label6.Text) || (label4.Text == label8.Text))
            {
                label4.Text = "________";
                label5.Text = "______________";
                label24.Text = "__________";
                DialogResult error = MessageBox.Show("Вы уже ранее вводили данное время, введите заново! ", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
  
            if ((numericUpDown_My1.Text == "") || (numericUpDown_My2.Text == "") || (numericUpDown_My3.Text == ""))
            {
                label4.Text = "________";
                label5.Text = "______________";
                label24.Text = "__________";
                DialogResult error = MessageBox.Show("Попытка ввести некорректные данные! Повторите попытку!  (Поля ввода часов, минут или секунд не могут быть пустыми)", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numericUpDown_My1.Text = "00";
                numericUpDown_My2.Text = "00";
                numericUpDown_My3.Text = "00";
                return;
            }

          
            textBox2.Text = "";
            textBox1.Text = "";
            numericUpDown_My1.Value = 0;
            numericUpDown_My2.Value = 0;
            numericUpDown_My3.Value = 0;
       
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if ((label6.Text != "") && (label6.Text != "________"))
            {
                DialogResult error = MessageBox.Show("В данный будильник уже записано время. Вы уверены, что хотите перезаписать его?", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (error == DialogResult.Yes)
                {
                    music3 = music;
                    label27.Text = textBox2.Text;
                    label7.Text = textBox1.Text;
                    label6.Text = numericUpDown_My1.Text + ":" + numericUpDown_My2.Text + ":" + numericUpDown_My3.Text;
                }
                else return;
            }

            string f = textBox1.Text;
            label7.Text = f;
            music3 = music;
            label27.Text = textBox2.Text;
            label6.Text = numericUpDown_My1.Text + ":" + numericUpDown_My2.Text + ":" + numericUpDown_My3.Text;
            timer2.Start();

            if (textBox1.Text == "")
            {
                label7.Text = "______________";
            }

            if (((label6.Text == label2.Text) || (label6.Text == label4.Text) || (label6.Text == label8.Text) || (numericUpDown_My1.Text == "") || (numericUpDown_My2.Text == "") || (numericUpDown_My3.Text == "")) == false)
            {
                if (textBox2.Text == "")
                {
                    label27.Text = "___________";
                    DialogResult error = MessageBox.Show("Вы не выбрали мелодию для данного будильника! Выбрать мелодию?", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (error == DialogResult.Yes)
                    {
                        OpenFileDialog open = new OpenFileDialog();
                        open.Filter = String.Empty;
                        open.Filter = "Музыкальные файлы|*.mp3; *.mp2; *.wma; *.wav; *.ogg; *.ogm; *.au; *.aif;";
                        if (open.ShowDialog() == DialogResult.OK)
                        {
                            music3 = open.FileName;
                            label27.Text = open.SafeFileName;
                        }
                    }
                    else label27.Text = "___________";

                }
            }

            if ((label6.Text == label2.Text) || (label6.Text == label4.Text) || (label6.Text == label8.Text))
            {
                label6.Text = "________";
                label7.Text = "______________";
                label27.Text = "__________";
                DialogResult error = MessageBox.Show("Вы уже ранее вводили данное время! Повторите попытку!  ", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
          
            if ((numericUpDown_My1.Text == "") || (numericUpDown_My2.Text == "") || (numericUpDown_My3.Text == ""))
            {
                label6.Text = "________";
                label7.Text = "______________";
                label27.Text = "__________";
                DialogResult error = MessageBox.Show("Попытка ввести некорректные данные! Повторите попытку!  (Поля ввода часов, минут или секунд не могут быть пустыми)", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numericUpDown_My1.Text = "00";
                numericUpDown_My2.Text = "00";
                numericUpDown_My3.Text = "00";
                return;
            }
        
            textBox2.Text = "";
            textBox1.Text = "";
            numericUpDown_My1.Value = 0;
            numericUpDown_My2.Value = 0;
            numericUpDown_My3.Value = 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if ((label8.Text != "") && (label8.Text != "________"))
            {
                DialogResult error = MessageBox.Show("В данный будильник уже записано время. Вы уверены, что хотите перезаписать его?", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (error == DialogResult.Yes)
                {
                    music4 = music;
                    label29.Text = textBox2.Text;
                    label9.Text = textBox1.Text;
                    label8.Text = numericUpDown_My1.Text + ":" + numericUpDown_My2.Text + ":" + numericUpDown_My3.Text;
                }
                else return;
            }
            
            string f = textBox1.Text;
            label9.Text = f;
            music4 = music;
            label29.Text = textBox2.Text;
            label8.Text = numericUpDown_My1.Text + ":" + numericUpDown_My2.Text + ":" + numericUpDown_My3.Text;
            timer2.Start();

            if (textBox1.Text == "")
            {
                label9.Text = "______________";
            }

            if (((label8.Text == label2.Text) || (label8.Text == label6.Text) || (label8.Text == label4.Text) || (numericUpDown_My1.Text == "") || (numericUpDown_My2.Text == "") || (numericUpDown_My3.Text == "")) == false)
            {
                if (textBox2.Text == "")
                {

                    label29.Text = "___________";
                    DialogResult error = MessageBox.Show("Вы не выбрали мелодию для данного будильника! Выбрать мелодию?", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (error == DialogResult.Yes)
                    {
                        OpenFileDialog open = new OpenFileDialog();
                        open.Filter = String.Empty;
                        open.Filter = "Музыкальные файлы|*.mp3; *.mp2; *.wma; *.wav; *.ogg; *.ogm; *.au; *.aif;";
                        if (open.ShowDialog() == DialogResult.OK)
                        {
                            music4 = open.FileName;
                            label29.Text = open.SafeFileName;
                        }
                    }
                    else label29.Text = "___________";

                }
            }
            if ((label8.Text == label2.Text) || (label8.Text == label6.Text) || (label8.Text == label4.Text))
            {
                label8.Text = "________";
                label29.Text = "___________";
                label9.Text = "______________";
                DialogResult error = MessageBox.Show("Вы уже ранее вводили данное время! Повторите попытку!  ", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if ((numericUpDown_My1.Text == "") || (numericUpDown_My2.Text == "") || (numericUpDown_My3.Text == ""))
            {
                label8.Text = "________";
                label29.Text = "___________";
                label9.Text = "______________";
                DialogResult error = MessageBox.Show("Попытка ввести некорректные данные! Повторите попытку!  (Поля ввода часов, минут или секунд не могут быть пустыми)", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numericUpDown_My1.Text = "00";
                numericUpDown_My2.Text = "00";
                numericUpDown_My3.Text = "00";
                return;
            }
          
            textBox2.Text = "";
            textBox1.Text = "";
            numericUpDown_My1.Value = 0;
            numericUpDown_My2.Value = 0;
            numericUpDown_My3.Value = 0;
        }

        private void numericUpDown_My1_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown_My1.Value > 23)
            {
                DialogResult error = MessageBox.Show("Попытка ввести некорректные данные! Повторите попытку! (Часы не могут быть больше 23)", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numericUpDown_My1.Value = 0;
            }
        }

        private void numericUpDown_My2_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown_My2.Value > 59)
            {
                DialogResult error = MessageBox.Show("Попытка ввести некорректные данные! Повторите попытку! (Минуты не могут быть больше 59)", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numericUpDown_My2.Value = 0;
            }
        }

        private void numericUpDown_My3_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown_My3.Value > 59)
            {
                DialogResult error = MessageBox.Show("Попытка ввести некорректные данные! Повторите попытку! (Секунды не могут быть больше 59)", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numericUpDown_My3.Value = 0;
            }
        }

        private void numericUpDown_My1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 59) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void numericUpDown_My2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 59) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void numericUpDown_My3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 59) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            label2.Text = "________";
            label3.Text = "______________";
            label23.Text = "__________";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label4.Text = "________";
            label5.Text = "______________";
            label24.Text = "__________";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label6.Text = "________";
            label7.Text = "______________";
            label27.Text = "__________";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            label8.Text = "________";
            label9.Text = "______________";
            label29.Text = "__________";
        }

        private void groupBox8_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void groupBox14_Enter(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }
    }
}
