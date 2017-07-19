using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureViewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            // ファイルを開くためのダイアログを表示する。
            // OKがクリックされた場合ユーザーが選択したファイルを読み込む。
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // pictureBoxに選択した画像を読み込む（表示する）
                pictureBox1.Load(openFileDialog1.FileName);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // pictureBoxの画像をクリア
            pictureBox1.Image = null;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            // 終了する
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                // pictureBoxをパネルのサイズに合わせる
                pictureBox1.Dock = DockStyle.Fill;

                // stretchにチェックが入っている場合、画像をpintureBoxのサイズに引き延ばす
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                // pictureBoxを画像サイズに合わせる
                pictureBox1.Dock = DockStyle.None;

                // チェックが入っていない場合は、元の画像サイズで表示する
                pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            }
        }
    }
}
