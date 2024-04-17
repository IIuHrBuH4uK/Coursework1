using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Coursework1
{
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
            panel1.Hide();
            panel2.Hide();
            panel3.Hide();
            panel4.Hide();
            panel5.Hide();
            panel6.Hide();
            panel7.Hide();
            panel8.Hide();
            panel9.Hide();
            panel10.Hide();
            button21.Hide();
        }

            // Переход между вопросами
        private void button4_Click(object sender, EventArgs e)
        {
            panel1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            panel2.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel2.Hide();
            panel3.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            panel3.Hide();
            panel4.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            panel4.Hide();
            panel5.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            panel5.Hide();
            panel6.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            panel6.Hide();
            panel7.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            panel7.Hide();
            panel8.Show();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            panel8.Hide();
            panel9.Show();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            panel9.Hide();
            panel10.Show();
        }
            // Проверка ответов
        private void button20_Click(object sender, EventArgs e)
        {
            int q1 = 0, q2 = 0, q3 = 0, q4 = 0, q5 = 0, q6 = 0, q7 = 0, q8 = 0, q9 = 0, res = 0;
            if (radioButton2.Checked)
                q1 = 2;
            if (radioButton4.Checked)
                q2 = 2;
            if (radioButton8.Checked)
                q3 = 2;
            if (checkBox5.Checked && checkBox6.Checked)
                q4 = 2;
            if (radioButton13.Checked)
                q5 = 2;
            if (radioButton17.Checked)
                q6 = 2;
            if (radioButton20.Checked)
                q7 = 2;
            if (checkBox2.Checked && checkBox1.Checked)
                q8 = 2;
            if (radioButton26.Checked)
                q9 = 2;
            res = q1 + q2 + q3 + q4 + q5 + q6 + q7 + q8 + q9;
            if (res > 16)
                MessageBox.Show("Вы сдали!😄" + Environment.NewLine + "Ваша сумма балов: " + res);
            else
                MessageBox.Show("Вы не сдали😢😭. Попробуйте ещё раз" + Environment.NewLine + "Ваша сумма балов: " + res);
            if (res > 16)
                button21.Hide();
                else button21.Show();
        }
            // Повторение теста
        private void ResetTest()
        {
            // Сброс всех ответов
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            radioButton6.Checked = false;
            radioButton7.Checked = false;
            radioButton8.Checked = false;
            radioButton9.Checked = false;
            radioButton13.Checked = false;
            radioButton14.Checked = false;
            radioButton15.Checked = false;
            radioButton16.Checked = false;
            radioButton17.Checked = false;
            radioButton18.Checked = false;
            radioButton19.Checked = false;
            radioButton20.Checked = false;
            radioButton21.Checked = false;
            radioButton25.Checked = false;
            radioButton26.Checked = false;
            radioButton27.Checked = false;

            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;

            // Скрывание всех панелей
            panel1.Hide();
            panel2.Hide();
            panel3.Hide();
            panel4.Hide();
            panel5.Hide();
            panel6.Hide();
            panel7.Hide();
            panel8.Hide();
            panel9.Hide();
            panel10.Hide();
            button21.Hide();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            ResetTest();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Правильный ответ - Сокрытие данных и реализация методов доступа к данным");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Правильный ответ - private");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Правильный ответ - Механизм для чтения и записи значения приватного поля класса.");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Тут два правильных ответа - Поля и Методы");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Правильный ответ - private");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Правильный ответ - Метод инициализации объекта.");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Правильный ответ - Сокрытие деталей реализации и защита данных от непосредственного доступа.");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Тут два правильных ответа - Свойства и Классы");

        }

        private void button18_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Правильный ответ - Метод, который используется для чтения или записи приватных данных класса.");
        }
    }
}
