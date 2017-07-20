using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Math_Quiz
{
    public partial class Form1 : Form
    {
        // ランダムな整数を生成するためのインスタンス生成
        Random randomizer = new Random();

        // ランダムな整数を格納するための変数
        int addend1;
        int addend2;

        // 残り時間を格納するための変数
        int timeLeft;

        public void StartTheQuiz()
        {
            // addendに0～51のランダムな整数を代入
            addend1 = randomizer.Next(51);
            addend2 = randomizer.Next(51);

            // plus..Labelのテキストを変更
            plusLeftLabel.Text = addend1.ToString();
            plusRightLabel.Text = addend2.ToString();

            sum.Value = 0;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            StartTheQuiz();
            startButton.Enabled = false;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(timeLeft > 0)
            {
                timeLeft = timeLeft - 1;
                timeLabel.Text = timeLeft + "second";
            }
            else
            {
                timer1.Stop();
                timeLabel.Text = "Time is up!";
                sum.Value = addend1 + addend2;
                startButton.Enabled = true;
            }
        }
    }
}
