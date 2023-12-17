using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SU_First_KI_last_word_game
{
    public partial class Form1 : Form
    {
        int status;
        string rettex = "再挑戦";

        public Form1()
        {
            InitializeComponent();
            init();
        }
        public void init()
        {
            status = 3;
            inp.Show();
            su.Show();
            ki.Show();
            btn.Show();
            ki.Location = new Point(68, 27);
            btn.Text = "確定";
            chg(3, "5文字");
        }
        public void chg(int len,string text)
        {
            inp.Text = string.Empty;
            inp.MaxLength = len;
            xmozi.Text = text;
            inp.Focus();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(btn.Text == rettex)
            {
                init();
                return;
            }
            switch (status)
            {
                case 3:
                    if(inp.Text.Length != 3)
                    {
                        chg(3, "5文字");
                        break;
                    }
                    chg(2, "4文字");
                    --status;
                    break;
                case 2:
                    if (inp.Text.Length != 2)
                    {
                        chg(2, "4文字");
                        break;
                    }
                    chg(1, "3文字");
                    --status;
                    break;
                case 1:
                    if (inp.Text.Length != 1)
                    {
                        chg(1, "3文字");
                        break;
                    }
                    chg(0, "2文字");
                    inp.Hide();
                    ki.Location = new Point(22, 27);
                    --status;
                    break;
                case 0:
                    chg(0, "私もすき♡");
                    su.Hide();
                    ki.Hide();
                    btn.Text = rettex;
                    break;
            }
        }
        private void inp_TextChanged(object sender, EventArgs e)
        {
            if (inp.MaxLength == 0) inp.Text = string.Empty;
        }
    }
}
