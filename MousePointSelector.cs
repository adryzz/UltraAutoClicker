using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UltraAutoClicker
{
    public partial class MousePointSelector : Form
    {
        Form1 Form1;
        public MousePointSelector(Form1 f1)
        {
            InitializeComponent();
            Form1 = f1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F2)
            {
                Form1.xCoordinateSelector.Value = Cursor.Position.X;
                Form1.yCoordinateSelector.Value = Cursor.Position.Y;
                Close();
            }
        }

        private void MousePointSelector_Load(object sender, EventArgs e)
        {

        }
    }
}
