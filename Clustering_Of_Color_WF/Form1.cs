using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clustering_Of_Color_WF
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

        List<Cluster> clusterList = new List<Cluster>();

        

        

        //ранжируем объекты по кластерам
        private void Btn_Ranging_Click(object sender, EventArgs e)
        {
            Subject_Ranging sr = new Subject_Ranging();
            sr.Ranging(int.Parse(Txb_Object.Text), int.Parse(Txb_Cluster.Text), out clusterList);

            Bitmap bmp = new Bitmap(700, 700);
            Pbx_Ranging.Image = bmp;
            Graphics g = Graphics.FromImage(Pbx_Ranging.Image);
            int j = 0;
            for (int i = 0; i < int.Parse(Txb_Cluster.Text); i++)
            {
                j = 0;
                foreach (Subject subject in clusterList[i].c_subjectList)
                    {
                        j++;
                        SolidBrush brush = new SolidBrush(Color.FromArgb(subject.red_intensity, subject.green_intensity, subject.blue_intensity));
                        g.FillRectangle(brush, i * 20, j * 20, 20, 20);
                    } 
            }
            
        }


        private void Btn_Definition_Click(object sender, EventArgs e)
        {
            int cluster_id;
            Bitmap bmp = new Bitmap(700, 700);
            Pbx_Definition.Image = bmp;
            Graphics g = Graphics.FromImage(Pbx_Definition.Image);
            Color_Definition cd = new Color_Definition();
            cd.Color_Def(int.Parse(Txb_Red.Text), int.Parse(Txb_Green.Text), int.Parse(Txb_Blue.Text), clusterList, out cluster_id);
            SolidBrush brush = new SolidBrush(Color.FromArgb(int.Parse(Txb_Red.Text), int.Parse(Txb_Green.Text), int.Parse(Txb_Blue.Text)));
            g.FillRectangle(brush, 0, 0, 50, 50);
            SolidBrush brush2 = new SolidBrush(Color.Black);
            Point p = new Point(60, 25);
            g.DrawString("номер кластера: " + (cluster_id + 1), Font, brush2, p);
            System.Threading.Thread.Sleep(1000);

        }




        private void Txb_Object_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txb_cluster_TextChanged(object sender, EventArgs e)
        {
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        
        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        
    }
}
