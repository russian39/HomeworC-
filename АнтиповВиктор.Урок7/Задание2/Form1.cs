using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Задание2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Угадайка";
            lblDescription.Text = "Угадайте число от 1 до 100.\nДля того, чтобы начать игру нажмите кнопку 'новая игра'";
            btnPlay.Text = "новая игра";
        }

        private int btnPlay_Click(object sender, EventArgs e)
        {
            Random num = new Random();
            int n = num.Next(1, 100);
            return n;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int num = int.Parse(textBox1.Text);
            int trueN = btnPlay_Click();
            if (num == trueN)
            {
                
            }
        }
    }
}
