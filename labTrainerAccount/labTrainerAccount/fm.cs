using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labTrainerAccount
{
    public partial class fm : Form
    {
        private Game g;
        public fm()
        {
            InitializeComponent();
            g = new Game();
            g.Change += Event_Change;
            g.Reset();
            buYes.Click += delegate
            {
                g.Answer(true);
            };
            buNo.Click += delegate {
                g.Answer(false);
            };
        }

        private void Event_Change(object sender, EventArgs e)
        {
            laCorrect.Text = String.Format("Верно: {0}", g.CntCorrect.ToString());
            laWrong.Text = String.Format("Неверно: {0}", g.CntWrong.ToString());
            laCode.Text = g.CodeText;
        }
    }
}
