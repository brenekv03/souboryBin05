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

namespace souboryBin05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("pomocnik.dat", FileMode.OpenOrCreate, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            bw.Write(5.21);
            bw.Write(10);
            bw.Write(-84.5);
            bw.Write(3);
            bw.Write(69);
            fs.Close();
            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                FileStream fs1 = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.ReadWrite);
                BinaryReader br1 = new BinaryReader(fs1);
                BinaryWriter bw1 = new BinaryWriter(fs1);
                while(br1.BaseStream.Position<br1.BaseStream.Length)
                {
                    double cislo = br1.ReadDouble();
                    if (cislo < 0)
                    {
                        bw.Write()
                    }
                }
            }

        }
    }
}
