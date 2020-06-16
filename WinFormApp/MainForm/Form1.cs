using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LBLButtonStyle.Text = FlatStyle.Standard.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LBLButtonStyle.Text = FlatStyle.Popup.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LBLButtonStyle.Text = FlatStyle.Flat.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LBLButtonStyle.Text = FlatStyle.System.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LBLButtonStyle.Text = "결과표시";  
            // 메인폼을 바꾸고 싶을때 메인폼로드에서 만들어준다
        }
    }
}
