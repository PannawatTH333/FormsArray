using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsArray
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] student = new string[5];
            student[0] = "ต้น";
            student[1] = "มือ";
            student[2] = "แขน";
            student[3] = "อาร์ม";
            student[4] = "ปราง";

            string test = "";
            int n=student.Length;
            for (int i = 0; i < n; i++)
            {
                test += student[i] + Environment.NewLine;
            }
            MessageBox.Show(test);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] Fruit = { "ส้ม", "มะม่วง", "มะขาม", "มะยม", "ส้มโอ" };
            string myFruit = "";
            foreach (string str in Fruit)
            {
                myFruit += str + ", ";
            }
            MessageBox.Show(myFruit, "ผลไม้ของไผ๋");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] Fruit = { "ส้ม", "มะม่วง", "มะขาม", "มะยม", "ส้มโอ" };
            comboBox1.Items.AddRange(Fruit);
            listBox1.Items.AddRange(Fruit);
            checkedListBox1.Items.AddRange(Fruit);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string[] data = textBox1.Lines;  //นำข้อมูลแต่ละบรรทัดไปใส่
            string result = "";
            foreach (string str in data)
            {
                if (str != "")
                {
                    result += str + Environment.NewLine;
                }
                
            }
            label1.Text = result;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string[] data = textBox1.Lines;
            string result = "";
            int sum = 0;
            foreach (var str in data)
            {

                
                int x = 0;
                if (int.TryParse(str,out x))
                {
                    result += x.ToString() + Environment.NewLine;
                    sum += x;
                }
            }
            label1.Text = result;
            MessageBox.Show(sum.ToString(), "ผลรวมของตัวเลข");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string[,] student = new string[3,2];
            student[0, 0] = "ต้น";
            student[0, 1] = "อุดร";
            student[1, 0] = "ขาม";
            student[1, 1] = "หนองแสง";
            student[2, 0] = "เอ็ก";
            student[2, 1] = "หนองคาย";
            string ResultData = "";
            int m = student.GetLength(0);
            int n = student.GetLength(1);
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    ResultData += student[i, j] + "_";
                }
                ResultData += Environment.NewLine;
            }
            MessageBox.Show(ResultData, "แสดงข้อมูล Array 2มิติ");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = comboBox1.SelectedIndex.ToString()  + "_";
            str += comboBox1.SelectedItem;
            MessageBox.Show(str);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = listBox1.SelectedIndex.ToString() + "_";
            str += listBox1.SelectedItem;
            MessageBox.Show(str);
        }
    }
}
