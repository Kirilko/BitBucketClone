using labGenPassword.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labGenPassword
{
    public partial class fm : Form
    {
        public fm()
        {
            InitializeComponent();

            buGen.Click += delegate
            {
                textBox.Text = Utils.RandomStr((int)edLength.Value, chDown.Checked,
                    chUp.Checked, chNum.Checked, chSpec.Checked);
            };
        }

        
    }
}
