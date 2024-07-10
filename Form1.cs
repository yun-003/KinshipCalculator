using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace KinshipCalculator
{
    public partial class KinshipCalculator : Form
    {
        public KinshipCalculator()
        {
            InitializeComponent();
        }

        List<string> rl_list = new List<string>();
        int rl_cnt = 0;
        


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            output.Text = "我";
            input.Text = "我";
            rl_list.Clear();
            rl_cnt = 0;
        }

        private void but14_Click(object sender, EventArgs e)
        {
            try
            {
                string jsonString = File.ReadAllText("relationships.json"); // 读取 JSON 文件
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading JSON file: " + ex.Message);
            }



        }

        private void but13_Click(object sender, EventArgs e)
        {
            output.Text = "功能还未开发哦！";
        }

        private void but12_Click(object sender, EventArgs e)
        {
            if(rl_cnt == 0)
            {
                rl_cnt++;
                rl_list.Add("我");
            }

            Button btn = (Button)sender;
            string real = btn.Text;

            switch (real)
            {
                case "父":
                    real = "爸爸";
                    break;
                case "母":
                    real = "妈妈";
                    break;
                case "姐":
                    real = "姐姐";
                    break;
                case "妹":
                    real = "妹妹";
                    break;
                case "兄":
                    real = "哥哥";
                    break;
                case "弟":
                    real = "弟弟";
                    break;
                case "夫":
                    real = "丈夫";
                    break;
                case "妻":
                    real = "媳妇";
                    break;
                case "子":
                    real = "儿子";
                    break;
                case "女":
                    real = "女儿";
                    break;
            }

            rl_list.Add(real);
            rl_cnt++;

            string result = String.Join("的", rl_list);
            input.Text = result;

        }

        private void but2_Click(object sender, EventArgs e)
        {
            if (rl_cnt > 1)
            {
                rl_list.RemoveAt(--rl_cnt);
                //rl_cnt--;

                string result = String.Join("的", rl_list);
                input.Text = result;
            }
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
