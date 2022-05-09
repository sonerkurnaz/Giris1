using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinMayinTarlasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 154; i++)
            {
                PictureBox box = new PictureBox();
                box.Height = 30;
                box.Width = 30;
                box.Name = "box1" + i;
                box.BackColor = Color.Aqua;
                FlowLayoutPanel.Controls.Add(box);
            }



        }
    }
}
