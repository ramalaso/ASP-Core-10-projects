using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MegaDesk
{
    public partial class DisplayQuote : Form
    {
        public DisplayQuote(string name, int width, int depth, int numberOfDrawers, string surface, 
            string rushDays, int totalQuote)
        {
            InitializeComponent();
            txtFullName.Text = name;
            txtSize.Text = (width * depth).ToString();
            txtRushDays.Text = rushDays.ToString();
            txtNDrawers.Text = numberOfDrawers.ToString();
            txtSurface.Text = surface;
            txtTotalQuote.Text = totalQuote.ToString();
        }
        
        private void DisplayQuote_Load(object sender, EventArgs e)
        {
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
