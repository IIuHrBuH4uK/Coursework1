using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursework1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Material.Visible = false;
            Test.Visible = false;
            CodePan.Visible = false;
            Code.Visible = false;
            InfoPan.Visible = false;
            Info.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Material.Visible = true;
            Test.Visible = false;
            CodePan.Visible = false;
            Code.Visible = false;
            InfoPan.Visible = false;
            Info.Visible = false;

        }
        private void button2_Click(object sender, EventArgs e)
        {
            Material.Visible = false;
            Test.Visible = true;
            CodePan.Visible = false;
            Code.Visible = false;
            InfoPan.Visible = false;
            Info.Visible = false;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            int q1 = 0, q2 = 0, q3 = 0, q4 = 0, q5 = 0, q6 = 0, q7 = 0, q8 = 0, q9 = 0, res = 0;
            if (radioButton2.Checked)
                q1 = 2;
            if (radioButton4.Checked)
                q2 = 2;
            if (radioButton8.Checked)
                q3 = 2;
            if (checkBox2.Checked && checkBox3.Checked)
                q4 = 2;
            if (radioButton16.Checked)
                q5 = 2;
            if (radioButton23.Checked)
                q6 = 2;
            if (radioButton14.Checked)
                q7 = 2;
            if (checkBox5.Checked && checkBox6.Checked)
                q8 = 2;
            if (radioButton26.Checked)
                q9 = 2;
            res = q1 + q2 + q3 + q4 + q5 + q6 + q7 + q8 + q9;
            if (res > 16)
                MessageBox.Show("Вы сдали!😄" + Environment.NewLine + "Ваша сумма балов: " + res);
            else
                MessageBox.Show("Вы не сдали😢😭. Попробуйте ещё раз" + Environment.NewLine + "Ваша сумма балов: " + res);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Material.Visible = false;
            Test.Visible = false;
            CodePan.Visible = true;
            Code.Visible = true;
            InfoPan.Visible = false;
            Info.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Material.Visible = false;
            Test.Visible = false;
            CodePan.Visible = false;
            Code.Visible = false;
            InfoPan.Visible = true;
            Info.Visible = true;
        }
    }
}
