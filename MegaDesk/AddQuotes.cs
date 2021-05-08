using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MegaDesk
{
    public partial class AddQuotes : Form
    {
        public AddQuotes()
        {
            InitializeComponent();
        }
        private void btnCalculateQuote_Click(object sender, EventArgs e)
        {
            try
            {
                int width = int.Parse(txtWidth.Text);
                int depth = int.Parse(txtDepth.Text);
                int numberOfDrawers = int.Parse(lsNumberOfDrawers.SelectedItem.ToString());

                Desk desk = new Desk(width, depth, numberOfDrawers);

                int totalQuote = desk.calculateQuote(width, depth, numberOfDrawers, GetSurface(), lstRushOrder.SelectedItem.ToString());
                DisplayQuote displayQuoteForm = new DisplayQuote(txtName.Text, width, depth, numberOfDrawers, lstSurfaceMaterial.SelectedItem.ToString(), lstRushOrder.SelectedItem.ToString(), totalQuote);
                displayQuoteForm.Show();

            }
            catch (Exception)
            {

                throw;
            }
        }

        public Desk.Surface GetSurface()
        {
            switch (lstSurfaceMaterial.SelectedIndex)
            {
                case 0:
                    return Desk.Surface.laminate;
                case 1:
                    return Desk.Surface.oak;
                case 2:
                    return Desk.Surface.pine;
                case 3:
                    return Desk.Surface.rosewood;
                case 4:
                    return Desk.Surface.veneer;
                default:
                    return Desk.Surface.None;
            }
        }

        private void txtWidth_TextChanged(object sender, EventArgs e)
        {
            int value;
            if(!int.TryParse(txtWidth.Text, out value))
            {
                errorProvider1.SetError(txtWidth, "Please enter only integer values");
            } else
            {
                errorProvider1.Clear();
            }

            if(value>96 || value < 24)
            {
                errorProvider1.SetError(txtWidth, "Please enter a value between 24 and 96");
            } else
            {
                errorProvider1.Clear();
            }
        }

        private void txtDepth_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtDepth_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar))
            {
                errorProvider1.SetError(txtDepth, "Please enter only integer values");
            } else
            {
                errorProvider1.Clear();
            }
        }
    }
}
