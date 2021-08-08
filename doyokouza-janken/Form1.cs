using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace doyokouza_janken
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        public string 敵の手()
        {
            Random p = new Random();
            int 乱数 = p.Next(1, 4); //1から3までの乱数を生成

            string 出力;

            if (乱数 == 1)
            {
                出力 = "グー";
            }
            else if (乱数 == 2)
            {
                出力 = "チョキ";
            }
            else
            {
                出力 = "パー";
            }

            return 出力;
        }

        public void 相手の画像(string 相手の手)
        {
            if (相手の手 == "グー")
            {
                picture.Image = Resource.gu;
            }
            else if (相手の手 == "チョキ")
            {
                picture.Image = Resource.choki;
            }
            else
            {
                picture.Image = Resource.pa;
            }
        }

        public void 処理 (string 自分の手)
        {

            string 相手の手 = 敵の手();

            Refresh(); //画像変更の前に画像を初期化
            相手の画像(相手の手);
            
            string 結果 = "";

            if (自分の手 == 相手の手)
            {
                結果 = "あいこ";
            }
            else if (自分の手 == "グー" && 相手の手 == "パー")
            {
                結果 = "負け";
            }
            else if (自分の手 == "グー" && 相手の手 == "チョキ")
            {
                結果 = "勝ち";
            }
            else if (自分の手 == "チョキ" && 相手の手 == "グー")
            {
                結果 = "負け";
            }
            else if (自分の手 == "チョキ" && 相手の手 == "パー")
            {
                結果 = "勝ち";
            }
            else if (自分の手 == "パー" && 相手の手 == "グー")
            {
                結果 = "勝ち";
            }
            else if (自分の手 == "パー" && 相手の手 == "チョキ")
            {
                結果 = "負け";
            }

            MessageBox.Show("結果は " + 結果 + " です。");
        }

        public string 自分の手;

        private void rock_Click(object sender, EventArgs e)
        {
            処理("グー");
        }

        private void scissors_Click(object sender, EventArgs e)
        {
            処理("チョキ");
        }

        private void paper_Click(object sender, EventArgs e)
        {
            処理("パー");
        }
    }
}
