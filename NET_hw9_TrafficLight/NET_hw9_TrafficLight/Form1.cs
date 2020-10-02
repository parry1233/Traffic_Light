using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NET_hw9_TrafficLight
{
	public partial class Form1 : Form
	{
		private Image green;
		private Image yellow;
		private Image red;
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			green = imageList1.Images[0];
			yellow = imageList1.Images[1];
			red = imageList1.Images[2];
			pictureBox1.Image = green;
		}

		private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
		{
			//MessageBox.Show(e.Button.ToString());
			if (e.Button == MouseButtons.Left||e.Button==MouseButtons.Middle)
			{
				pictureBox1.Image = red;
			}
			else if(e.Button==MouseButtons.Right)
			{
				pictureBox1.Image = yellow;
			}
		}

		private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
		{
			pictureBox1.Image = green;
		}
	}
}
