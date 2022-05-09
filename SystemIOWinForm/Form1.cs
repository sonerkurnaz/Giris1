using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemIOWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string klasor = lstKlasörler.SelectedItem.ToString();
            string[] klasorler = Directory.GetDirectories(klasor);
            string[] dosyalar = Directory.GetFiles(klasor);
            lstDosyalar.Items.Clear();
            foreach (string d in klasorler)
            {
                lstDosyalar.Items.Add(d);
            }
            foreach (var d in dosyalar)
            {
                lstDosyalar.Items.Add(d);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DriveInfo[] tumsuruculer = DriveInfo.GetDrives();
            foreach (DriveInfo drive in tumsuruculer)
            {
                lstDriver.Items.Add(drive.Name);
            }
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstDriver_SelectedIndexChanged(object sender, EventArgs e)
        {
            string drive = lstDriver.SelectedItem.ToString();
            string[] directories = Directory.GetDirectories(drive);
            lstKlasörler.Items.Clear();
            foreach (var d in directories)
            {
                lstKlasörler.Items.Add(d);
            }
        }
    }
}
