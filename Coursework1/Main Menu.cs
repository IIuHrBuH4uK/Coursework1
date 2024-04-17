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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }
        private void Material_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
        private void Test_FormClosed (object sender, FormClosedEventArgs e)
        { 
            this.Show(); 
        }
        private void Code_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Material material = new Material();
            material.Show();
            this.Hide();
            material.FormClosed += Material_FormClosed;

        }
        private void button2_Click(object sender, EventArgs e)
        {
            Test test = new Test();
            test.Show();
            this.Hide();
            test.FormClosed += Test_FormClosed;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Code code = new Code();
            code.Show();
            this.Hide();
            code.FormClosed += Code_FormClosed;
        }

        private void button4_Click(object sender, EventArgs e)
        {
        }
    } 
}
