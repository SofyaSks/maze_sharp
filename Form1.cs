using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace maze_sharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            moveToStart();
        }

        private void label_finish_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("VICTORY");
            Form Form2 = new Form(); // откроется вторая форма 
            Form2.Show();
        }

        private void moveToStart()
        {
            Point startp = panel1.Location;
            startp.Offset(35, 25);
            Cursor.Position = PointToScreen(startp);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            moveToStart();
        }
    }
}
