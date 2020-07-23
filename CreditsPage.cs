using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UltraAutoClicker
{
    public partial class CreditsPage : Form
    {
        public CreditsPage()
        {
            InitializeComponent();
        }

        private void CreditsPage_Load(object sender, EventArgs e)
        {
            label2.Text = 'v' + Application.ProductVersion;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/adryzz/UltraAutoClicker/releases/latest");
        }
    }
}
