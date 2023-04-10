using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            result2.Text = "";
            int count = 0;
            char[] f = new char[3] { ' ', ',', ';' };
            string[] arr = arr_txt.Text.Split(f, StringSplitOptions.RemoveEmptyEntries);
            Array.Sort(arr);
            if (arr.Length > 0)
                result1.Text = arr[0];
            else
            {
                result1.Text = "Масив не заповнений";
            }
            for(int i = 0; i < arr.Length; i++)
            {
                for (int j =  0; j < arr[i].Length; j++)
                {
                    if (arr[i][j] == 'd') {
                        count++;
                    }
                }
                if(count == 2)
                {
                    count = 0;
                    result2.Text += arr[i] + "; ";
                }
            }
        }
    }
}
