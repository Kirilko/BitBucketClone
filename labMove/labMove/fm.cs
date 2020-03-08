using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labMove
{
    public partial class fm : Form
    {
        private Point StartPoint { get; set; }
        public fm()
        {
            InitializeComponent();
            panel1.MouseDown += All_MouseDown;
            panel1.MouseMove += AllPMouseMove;
            panel2.MouseDown += All_MouseDown;
            panel2.MouseMove += AllPMouseMove;
            pictureBox1.MouseDown += All_MouseDown;
            pictureBox1.MouseMove += AllPMouseMove;
        }

        private void All_MouseDown(object sender, MouseEventArgs e)
        {
            StartPoint = new Point(e.X, e.Y);
        }

        private void AllPMouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point x = new Point(Cursor.Position.X - StartPoint.X, Cursor.Position.Y - StartPoint.Y);
                if (sender is Control)
                    ((Control)sender).Location = PointToClient(x);
            }
        }
    }
}
