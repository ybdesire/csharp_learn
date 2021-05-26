using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void types()
        {
            string x1 = "hello";
            double x2 = 1.23;
            int x3 = 4;
            float x5 = 6;
            bool x6 = true;

            System.Double y1 = 1.23;
            System.Int64 y2 = 3;
        }

        public void type_convert()
        {
            string x1 = "1.23";
            double x2 = double.Parse(x1);
            string x3 = x2.ToString();
        }

        public void condition()
        {
            int x1 = 1;
            int x2 = 3;
            int x3 = 4;
            if(x1>x2)
            {
                x3 = 3;
            }
            if(String.Compare("aaa","bbb")==0)
            {
                MessageBox.Show("same string");
            }
        }

        public void loop()
        {
            int sum = 0;
            for(int i=0;i<10;i++)
            {
                sum += i;
            }
            while(sum>0)
            {
                sum--;
            }
            MessageBox.Show(sum.ToString());
        }

        public void file_read()
        {
            try
            {
                StreamReader inputFile = File.OpenText("test.txt");
                string content = "";
                while (!inputFile.EndOfStream)
                {
                    content += inputFile.ReadLine();
                }
                MessageBox.Show(content);
                inputFile.Close();
            }catch(Exception e)
            {
                MessageBox.Show(e);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            file_read();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
