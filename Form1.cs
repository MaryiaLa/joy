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
using Timer = System.Windows.Forms.Timer;

namespace Joy
{
	public partial class Form1 : Form
	{
		private Joystick joystick;
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			joystick = new Joystick();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			bool isConnected = joystick.CheckIfIsConnected();
			textBoxIsConnected.Text = isConnected ? "Connected" : "Not connected";
		}

		private void button2_Click(object sender, EventArgs e)
		{
			timer1.Start();
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			int clickedButton = joystick.CheckWhichButtonIsClicked();
			if (clickedButton != 0)
			{
				textBoxButtonClicked.Clear();
				textBoxButtonClicked.Text = $@"Button {clickedButton} is pressed";
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			timer1.Stop();
			textBoxButtonClicked.Clear();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			timer2.Start();
		}

		private void timer2_Tick(object sender, EventArgs e)
		{
			bool isUpClicked = joystick.CheckIfUpButtonIsClicked();
			if (isUpClicked)
			{
				MessageBox.Show("Up is clicked", "UP", MessageBoxButtons.OKCancel);
			}
		}
	}
}
