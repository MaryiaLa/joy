namespace Joy
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.textBoxIsConnected = new System.Windows.Forms.TextBox();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.textBoxButtonClicked = new System.Windows.Forms.TextBox();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.timer2 = new System.Windows.Forms.Timer(this.components);
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(12, 12);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(115, 36);
			this.button1.TabIndex = 0;
			this.button1.Text = "Check if joystick is connected";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(12, 76);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(115, 38);
			this.button2.TabIndex = 1;
			this.button2.Text = "Subscribe on buttons click";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// textBoxIsConnected
			// 
			this.textBoxIsConnected.Location = new System.Drawing.Point(168, 21);
			this.textBoxIsConnected.Name = "textBoxIsConnected";
			this.textBoxIsConnected.Size = new System.Drawing.Size(100, 20);
			this.textBoxIsConnected.TabIndex = 2;
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// textBoxButtonClicked
			// 
			this.textBoxButtonClicked.Location = new System.Drawing.Point(168, 86);
			this.textBoxButtonClicked.Name = "textBoxButtonClicked";
			this.textBoxButtonClicked.Size = new System.Drawing.Size(100, 20);
			this.textBoxButtonClicked.TabIndex = 3;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(306, 76);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(115, 38);
			this.button3.TabIndex = 4;
			this.button3.Text = "Unsubscribe";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(12, 140);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(115, 36);
			this.button4.TabIndex = 5;
			this.button4.Text = "Subscribe to UP button";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// timer2
			// 
			this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(448, 357);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.textBoxButtonClicked);
			this.Controls.Add(this.textBoxIsConnected);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.TextBox textBoxIsConnected;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.TextBox textBoxButtonClicked;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Timer timer2;
	}
}

