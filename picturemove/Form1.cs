using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace picturemove
{
    public partial class Form1 : Form
    {
        private bool isDragging = false;
        private int oldX;
        private int oldY;

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
            oldX = e.X;
            oldY = e.Y;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if(isDragging == true)
            {
                pictureBox1.Top = pictureBox1.Top + (e.Y - oldY);
                pictureBox1.Left = pictureBox1.Left + (e.X - oldX);
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }
    }
}
